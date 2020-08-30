using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Repository
{
    public interface ILeaveRepository
    {
        IEnumerable<LeaveModel> GetLeaves();
        LeaveModel GetLeaveByID(int leaveID);
        bool ApplyLeave(LeaveModel leave);
        bool ApproveOrRejectLeave(int LeaveId, int statusCode); // 1 - Pending, 2- Approved , 3 Rejected
        bool UpdateLeave(LeaveModel leave); // only leave is in pending status;
        void Save();
    }
}
