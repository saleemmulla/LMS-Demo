using LMSRestFullWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSRestFullWebAPI.Repository
{
    public interface ILeaveRepository
    {
        IEnumerable<Leave> GetLeaves();
        Leave GetLeaveByID(int leaveID);
        bool ApplyLeave(Leave leave);
        bool ApproveOrRejectLeave(int LeaveId, int statusCode); // 0 - Pending, 1- Approved , 2 Rejected
        bool UpdateLeave(Leave leave); // only leave is in pending status;
        void Save();
    }
}
