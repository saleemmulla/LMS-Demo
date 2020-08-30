using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Repository
{
    public interface IUserDetailRepository
    {
        Userdetails GetUserDetailByName(string userName);
        string GetManagerNameByBadgeNumber(int BadgeNumber);
        Userdetails GetUserDetailByBadgeNumber(int BadgeNumber);
        IEnumerable<LeaveModel> GetEmployeeLeave(string UserName);
        IEnumerable<LeaveModel> GetMyEmployeeLeaveAR(string UserName);
        string GetUserEmailIdByBadgeNumber(int BadgeNumber);
        string GetUserMgrEmailIdByUserBadgeNumber(int BadgeNumber);
        IEnumerable<LeaveType> LeaveType();
        IEnumerable<LeaveMaster> GetUserLeaveMasterByUserName(string UserName);
    }
}
