using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRestFullWebAPI.DBContexts;
using LMSRestFullWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSRestFullWebAPI.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly DataBaseContext _dbContext;
        public LeaveRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool ApplyLeave(Leave leave)
        {
            try
            {
                var dptList = _dbContext.Leaves.ToList();
                _dbContext.Leaves.Add(leave);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ApproveOrRejectLeave(int LeaveId, int statusCode)
        {
            try
            {
                var leave = _dbContext.Set<Leave>()
                                      .Local
                                     .FirstOrDefault(entry => entry.ID.Equals(LeaveId));
                if (leave != null)
                {
                    _dbContext.Entry(leave).State = EntityState.Detached;
                }
                leave.Status = statusCode;
                _dbContext.Entry(leave).State = EntityState.Modified;
                Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Leave GetLeaveByID(int leaveID)
        {
            Leave leave = (from lv in _dbContext.Leaves
                                     where lv.ID == leaveID
                                     select lv
                       ).FirstOrDefault();
            return leave;
        }

        public IEnumerable<Leave> GetLeaves()
        {
            try
            {
                return _dbContext.Leaves.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public bool UpdateLeave(Leave leave)
        {
            try
            {
                var local = _dbContext.Set<Leave>()
                                       .Local
                                      .FirstOrDefault(entry => entry.ID.Equals(leave.ID));
                if (local != null)
                {
                    _dbContext.Entry(local).State = EntityState.Detached;
                }
                _dbContext.Entry(leave).State = EntityState.Modified;
                Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
