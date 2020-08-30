using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using LMSRestFullWebAPI.Models;
using LMSRestFullWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LMSRestFullWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        // GET api/Departments
        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get()
        {
            IEnumerable<Department> departments = null;
            departments= _departmentRepository.GetDepartments();
            if (departments != null)
                return new OkObjectResult(departments);
            else
                return new NotFoundObjectResult("Department not found");
        }

        // GET api/Departments/5
        [HttpGet("{id}")]
        public ActionResult<Department> Get(int id)
        {
            Department department = null;
            department = _departmentRepository.GetDepartmentByID(id);
            if (department != null)
                return new OkObjectResult(department);
            else
                return new NotFoundObjectResult("Department not found");
        }

        // POST api/Departments
        [HttpPost]
        public IActionResult Post([FromBody] Department department)
        {
            Department dept = _departmentRepository.GetDepartmentByName(department.DepartmentName);
            if (dept == null)
            {
                using (var scope = new TransactionScope())
                {
                    _departmentRepository.Add(department);
                    scope.Complete();
                    return CreatedAtAction(nameof(Get), new { id = department.ID }, department);
                }
            }
            else
                return new ObjectResult(string.Format("Department '{0}' is exists. Please provide different name",department.DepartmentName));
        }

        // PUT api/Departments/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  Department department)
        {
            Department dept = _departmentRepository.GetDepartmentByID(department.ID);
            if (dept != null)
            {
                using (var scope = new TransactionScope())
                {
                    _departmentRepository.UpdateDepartment(department);
                    scope.Complete();
                    return CreatedAtAction(nameof(Get), new { id = department.ID }, department);
                }
            }
            else
                return new NotFoundObjectResult("Department not found. Hence not updated");
        }

        // DELETE api/Departments/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Department dept = _departmentRepository.GetDepartmentByID(id);
            //dept.STATUS = 1;
            if (dept != null)
            {
                using (var scope = new TransactionScope())
                {
                    _departmentRepository.UpdateDepartment(dept);
                    scope.Complete();
                    return CreatedAtAction(nameof(Get), new { id = dept.ID }, dept);
                }
            }
            else
                return new NotFoundObjectResult("Department not found");
        }
    }
}
