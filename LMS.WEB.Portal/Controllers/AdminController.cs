using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.Common;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.Repository;
using LMSUtilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.WEB.Portal.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly ILeaveRepository _leaveRepository;
        private readonly ILeaveMasterRepository _leaveMasterRepository;
        public AdminController(IUserDetailRepository userDetailRepository
            , ILeaveRepository leaveRepository, ILeaveMasterRepository leaveMasterRepository)
        {
            _userDetailRepository = userDetailRepository;
            _leaveRepository = leaveRepository;
            _leaveMasterRepository = leaveMasterRepository;
        }
        // GET: Admin
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
        private static void SendEmail(string EmployeeName, DateTime fromDate, DateTime todate, string status, string emailId)
        {
            string HtmlBody = @"<p>Hi  " + EmployeeName + @"</p>
                                <p>
                                    Kindly note the following update regarding your leave request. <br /><br/>
                                    Start Date : " + fromDate.ToString("yyyy-MM-dd") + @"<br /><br />
                                    End Date : " + todate.ToString("yyyy-MM-dd") + @" <br /><br />
                                    Status : " + status + @"<br/><br/>

                                    LMS link https://localhost:44331/Account/LogIn
                                <br />";
            Email.body = HtmlBody;
            Email.subject = EmployeeName + " leave request " + status;
            Email.emailToAddress = emailId;
            Email.SendEmail();
        }

    }
}