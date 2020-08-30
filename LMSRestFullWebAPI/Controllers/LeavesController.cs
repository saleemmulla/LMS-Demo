using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using LMSRestFullWebAPI.Models;
using LMSRestFullWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSRestFullWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveRepository _leaveRepository;
        public LeavesController(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }
        // GET: api/Leaves
        [HttpGet]
        public ActionResult<IEnumerable<Leave>> Get()
        {
            IEnumerable<Leave> leaves = null;
            leaves = _leaveRepository.GetLeaves();
            if (leaves != null)
                return new OkObjectResult(leaves);
            else
                return new NotFoundObjectResult("Leaves list is empty");
        }

        // GET: api/Leaves/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Department> Get(int id)
        {
            Leave leave = null;
            leave = _leaveRepository.GetLeaveByID(id);
            if (leave != null)
                return new OkObjectResult(leave);
            else
                return new NotFoundObjectResult(string.Format("Leave record with id = {0} not found",id));
        }

        // POST: api/Leaves
        [HttpPost]
        public IActionResult Post([FromBody] Leave leave)
        {
            using (var scope = new TransactionScope())
            {
                _leaveRepository.ApplyLeave(leave);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = leave.ID }, leave);
            }
        }

        // PUT: api/Leaves/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  Leave leave)
        {
            if(id!=leave.ID)
                return new NotFoundObjectResult("Leave param id and leave body leave Id not matched");

            Leave lv = _leaveRepository.GetLeaveByID(id);
            if (lv != null)
            {
                if (lv.Status == 1)
                {
                    using (var scope = new TransactionScope())
                    {
                        _leaveRepository.UpdateLeave(leave);
                        scope.Complete();
                        return CreatedAtAction(nameof(Get), new { id = leave.ID }, leave);
                    }
                }
                else
                    return new NotFoundObjectResult("Levae can not be modified as it's either Approved/Rejected");
            }
            else
                return new NotFoundObjectResult(string.Format("Leave record with id = {0} not found", id));
        }
    }
}
