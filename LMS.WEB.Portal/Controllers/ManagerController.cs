using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.Common;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using LMS.WEB.Portal.Repository;
using LMSUtilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.WEB.Portal.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly ILeaveRepository _leaveRepository;
        private readonly ILeaveMasterRepository _leaveMasterRepository;
        public ManagerController(IUserDetailRepository userDetailRepository
            , ILeaveRepository leaveRepository
            , ILeaveMasterRepository leaveMasterRepository)
        {
            _userDetailRepository = userDetailRepository;
            _leaveRepository = leaveRepository;
            _leaveMasterRepository = leaveMasterRepository;
        }
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ApproveOrReject()
        {
            IEnumerable<LeaveModel> leavesModel = null;
            if (HttpContext.Session != null && HttpContext.Session.Keys.Contains("userId"))
            {
                string userName = HttpContext.Session.GetString("userId");
                leavesModel = _userDetailRepository.GetMyEmployeeLeaveAR(userName);
            }
            return View(leavesModel);
        }
        [HttpPost]
        public ActionResult ApproveOrReject(int id, int sCode)
        {
            bool IsLeaveApprovedOrRejected = true;
            IsLeaveApprovedOrRejected = _leaveRepository.ApproveOrRejectLeave(id, sCode);
            string userName = HttpContext.Session.GetString("userId");
            IEnumerable<LeaveModel> leavesModel = _userDetailRepository.GetMyEmployeeLeaveAR(userName);
            var approvedOrRejected = leavesModel.Where(lm => lm.ID == id).FirstOrDefault();
            string emailID = _userDetailRepository.GetUserEmailIdByBadgeNumber(approvedOrRejected.BadgeNumber);
            if (IsLeaveApprovedOrRejected)
            {
                ViewBag.Result = "Saved Succesfully";
                TempData["Success"] = "Added Successfully!";
               HelperClass.SendEmailFromManager(approvedOrRejected.EmployeeName,
                approvedOrRejected.LeaveFromDate,
                approvedOrRejected.LeaveToDate,
                approvedOrRejected.StatusName,
                emailID);
            }
            return View(leavesModel);
        }
        public ActionResult ApproveOrRejectLeave(int id, int sCode)
        {
            bool IsLeaveApprovedOrRejected = false;
            IEnumerable<LeaveModel> leavesModelR = null;
            IsLeaveApprovedOrRejected = _leaveRepository.ApproveOrRejectLeave(id, sCode);
            string userName = HttpContext.Session.GetString("userId");
            IEnumerable<LeaveModel> leavesModel = _userDetailRepository.GetMyEmployeeLeaveAR(userName);
            var approvedOrRejected = leavesModel.Where(lm => lm.ID == id).FirstOrDefault();
            string emailID = _userDetailRepository.GetUserEmailIdByBadgeNumber(approvedOrRejected.BadgeNumber);
            if (IsLeaveApprovedOrRejected)
            {
                ViewBag.Result = "Saved Succesfully";
                TempData["Success"] = "Added Successfully!";
                HelperClass.SendEmailFromManager(approvedOrRejected.EmployeeName,
                approvedOrRejected.LeaveFromDate,
                approvedOrRejected.LeaveToDate,
                approvedOrRejected.StatusName,
                emailID);

                if (HttpContext.Session != null && HttpContext.Session.Keys.Contains("userId"))
                {
                    leavesModelR = _userDetailRepository.GetMyEmployeeLeaveAR(HttpContext.Session.GetString("userId"));
                }

            }
            return View("Index");
        }
        public IActionResult ViewDashboard()
        {
            IEnumerable<LeaveModel> leavesModel = null;
            if (HttpContext.Session != null && HttpContext.Session.Keys.Contains("userId"))
            {
                string userName = HttpContext.Session.GetString("userId");
                leavesModel = _userDetailRepository.GetEmployeeLeave(userName);
                IEnumerable<LeaveMaster> leaveMaster = _leaveMasterRepository.GetLeaveMasterByUserName(userName);
                TempData["leaveMaster"] = leaveMaster;
            }
            return View(leavesModel);
        }
    }
}