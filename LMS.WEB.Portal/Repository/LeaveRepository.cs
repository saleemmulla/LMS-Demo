using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.Mappers;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using LMS.WEB.Portal.Repository;
using Microsoft.EntityFrameworkCore;

namespace LMS.WEB.Portal.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly DataBaseContext _dbContext;
        private readonly ILeaveMapper _leavesMapper;
        private readonly IUserDetailRepository _userDetailRepository;
        public LeaveRepository(DataBaseContext dbContext
            , ILeaveMapper leavesMapper
            ,IUserDetailRepository userDetailRepository)
        {
            _dbContext = dbContext;
            _leavesMapper = leavesMapper;
            _userDetailRepository = userDetailRepository;
        }
        public bool ApplyLeave(LeaveModel leave)
        {
            try
            {
                tbl_Leaves leavesOB = _leavesMapper.GetLeavsOBFromLeaveModel(leave);
                 var usr = _userDetailRepository.GetUserDetailByBadgeNumber(leavesOB.BadgeNumber);
                leavesOB.DeptId = usr.DeptId;
                leavesOB.ManagerBadgeNumber = (int)usr.ManagerBadgeNumber;
                var lv = _dbContext.tbl_Leaves;
                var dptList = lv ==null ? new List<tbl_Leaves>():lv.ToList();
                _dbContext.tbl_Leaves.Add(leavesOB);
               
                var user = _dbContext.tbl_EmpDetails.Where(e => e.BadgeNumber == leave.BadgeNumber).FirstOrDefault();

                tbl_LeaveMaster leaveMaster= _dbContext.tbl_LeaveMasters.Where(lm => lm.UserName == user.UserName && lm.LeaveTypeId==leave.LeaveTypeId && lm.Year==DateTime.Now.Year).FirstOrDefault();
                var usedLeaved = leaveMaster.UsedLeaves;
                var balanceLeave = leaveMaster.BalanceLeave;
                var allotedLeaves = leaveMaster.AllotedLeaves;
                var numberOfLeaves = leave.NumberOfLeaves;

                leaveMaster.UsedLeaves = (usedLeaved + numberOfLeaves);
                leaveMaster.BalanceLeave = allotedLeaves- (usedLeaved + numberOfLeaves);

                var local = _dbContext.Set<tbl_LeaveMaster>()
                                       .Local
                                      .FirstOrDefault(entry => entry.LeaveMasterId.Equals(leaveMaster.LeaveMasterId));
                if (local != null)
                {
                    _dbContext.Entry(local).State = EntityState.Detached;
                }
                _dbContext.Entry(leaveMaster).State = EntityState.Modified;
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
                var leave = _dbContext.tbl_Leaves.Where(lv => lv.ID == LeaveId).FirstOrDefault();
                var leaveDetched = _dbContext.Set<tbl_Leaves>()
                                      .Local
                                     .FirstOrDefault(entry => entry.ID.Equals(LeaveId));
                if (leaveDetched != null)
                {
                    _dbContext.Entry(leaveDetched).State = EntityState.Detached;
                }
                leave.Status = statusCode;
                _dbContext.Entry(leave).State = EntityState.Modified;
                if (statusCode == 3)
                {
                    var user = _dbContext.tbl_EmpDetails.Where(e => e.BadgeNumber == leave.BadgeNumber).FirstOrDefault();
                    tbl_LeaveMaster leaveMaster = _dbContext.tbl_LeaveMasters.Where
                        (lm => lm.UserName == user.UserName
                        && lm.LeaveTypeId == leave.LeaveTypeId 
                        && lm.Year == DateTime.Now.Year).FirstOrDefault();

                    var usedLeave = leaveMaster.UsedLeaves;
                    var balanceLeave = leaveMaster.BalanceLeave;
                    var allotedLeaves = leaveMaster.AllotedLeaves;
                    var numberOfLeaves = leave.NumberOfLeaves;

                    leaveMaster.UsedLeaves = (usedLeave - leave.NumberOfLeaves);
                    leaveMaster.BalanceLeave =  (balanceLeave + numberOfLeaves);

                    var local = _dbContext.Set<tbl_LeaveMaster>()
                                           .Local
                                          .FirstOrDefault(entry => entry.LeaveMasterId.Equals(leaveMaster.LeaveMasterId));
                    if (local != null)
                    {
                        _dbContext.Entry(local).State = EntityState.Detached;
                    }
                    _dbContext.Entry(leaveMaster).State = EntityState.Modified;

                }

                Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public LeaveModel GetLeaveByID(int leaveID)
        {
            LeaveModel leaveModel = null;
            tbl_Leaves LeavesOB = (from lv in _dbContext.tbl_Leaves
                                     where lv.ID == leaveID
                                     select lv
                       ).FirstOrDefault();
            leaveModel=_leavesMapper.GetLeaveModelFromLeavesOB(LeavesOB);
            return leaveModel;
        }

        public IEnumerable<LeaveModel> GetLeaves()
        {
            try
            {
                IEnumerable<LeaveModel> leaveModels = null;
                var ob= _dbContext.tbl_Leaves.ToList();
                _leavesMapper.GetListofLMFromLeavesOB(ob);
                return leaveModels;
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

        public bool UpdateLeave(LeaveModel leave)
        {
            try
            {
                var local = _dbContext.Set<tbl_Leaves>()
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
