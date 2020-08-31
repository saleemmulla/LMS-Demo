﻿using System;
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
        public ActionResult ApproveOrRejectLeave(int id, int sCode)
        {
            bool IsLeaveApprovedOrRejected = false;
            IsLeaveApprovedOrRejected = _leaveRepository.ApproveOrRejectLeave(id, sCode);
            string userName = HttpContext.Session.GetString("userId");
            IEnumerable<LeaveModel> leavesModel = _userDetailRepository.GetMyEmployeeLeaveAR(userName);
            var approvedOrRejected = leavesModel.Where(lm => lm.ID == id).FirstOrDefault();
            string emailID = _userDetailRepository.GetUserEmailIdByBadgeNumber(approvedOrRejected.BadgeNumber);
            if (IsLeaveApprovedOrRejected)
            {
                ViewBag.Result = approvedOrRejected.StatusName + " Succesfully";
                TempData["Success"] = approvedOrRejected.StatusName + " Successfully!";
                HelperClass.SendEmailFromManager(approvedOrRejected.EmployeeName,
                approvedOrRejected.LeaveFromDate,
                approvedOrRejected.LeaveToDate,
                approvedOrRejected.StatusName,
                emailID);
            }
            return View("ApproveOrReject");
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
        public IActionResult ApplyLeave()
        {
            LeaveModel leavemodel = null;
            if (HttpContext.Session != null && HttpContext.Session.Keys.Contains("userId"))
            {
                string userName = HttpContext.Session.GetString("userId");
                Userdetails userdetails = null;
                userdetails = _userDetailRepository.GetUserDetailByName(userName);
                userdetails.ManagerName = _userDetailRepository.GetManagerNameByBadgeNumber(userdetails.ManagerBadgeNumber);
                TempData["userdetails"] = userdetails;
                leavemodel = new LeaveModel();
                leavemodel.BadgeNumber = userdetails.BadgeNumber;
                leavemodel.ManagerName = userdetails.ManagerName;
                leavemodel.DepartmentName = userdetails.DepartmentName;
                leavemodel.EmployeeName = userdetails.FirstName + " " + userdetails.LastName;
                leavemodel.Status = 1;
                leavemodel.RequestedOn = DateTime.Now;
                leavemodel.LeaveType = _userDetailRepository.LeaveType();
            }
            return View(leavemodel);
        }
        [HttpPost]
        public async Task<ActionResult> ApplyLeave(LeaveModel model)
        {
            model.LeaveType = _userDetailRepository.LeaveType();
            model.Status = 1;
            model.RequestedOn = DateTime.Now;
            if (ModelState.IsValid && ModelState.ErrorCount == 0)
            {
                if (model != null)
                {
                    int diif = model.LeaveToDate.Subtract(model.LeaveFromDate).Days;
                    model.NumberOfLeaves = diif == 0 ? 1 : diif + 1;
                }
                bool IsLeaveApplied = _leaveRepository.ApplyLeave(model);
                string mgrEmailID = _userDetailRepository.GetUserMgrEmailIdByUserBadgeNumber(model.BadgeNumber);
                if (IsLeaveApplied)
                {
                    ViewBag.Result = "Saved Succesfully";
                    TempData["Success"] = "Added Successfully!";
                    HelperClass.SendEmailFromEmployee(model.ManagerName, model.EmployeeName, model.LeaveFromDate, model.LeaveToDate, mgrEmailID);
                }
            }
            return View(model);
        }
    }
}