using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.Mappers;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Repository
{
    public class UserDetailRepository : IUserDetailRepository
    {
        private readonly DataBaseContext _dbContext;
        private readonly IEmployeeDetailsMapper _employeeDetailsMapper;
        private readonly ILeaveTypeMapper _leaveTypeMapper;
        public UserDetailRepository(DataBaseContext dbContext
            , IEmployeeDetailsMapper employeeDetailsMapper
            , ILeaveTypeMapper leaveTypeMapper)
        {
            _dbContext = dbContext;
            _employeeDetailsMapper = employeeDetailsMapper;
            _leaveTypeMapper = leaveTypeMapper;
        }

        public string GetManagerNameByBadgeNumber(int BadgeNumber)
        {
            var mgr = (from e in _dbContext.tbl_EmpDetails where e.BadgeNumber == BadgeNumber select e).FirstOrDefault();
            return mgr.FirstName + " " + mgr.LastName;
        }
        public Userdetails GetUserDetailByBadgeNumber(int BadgeNumber)
        {
            Userdetails userDetail = null;
            tbl_EmpDetails tbl_EmpDetailsOB= (from e in _dbContext.tbl_EmpDetails where e.BadgeNumber == BadgeNumber select e).FirstOrDefault();
            var department = _dbContext.tbl_Departments.Where(d => d.ID == tbl_EmpDetailsOB.DeptId).FirstOrDefault();
            tbl_EmpDetailsOB.Department = department;
            userDetail =_employeeDetailsMapper.GetUserDetilsFromTbl_EmpDetailsOB(tbl_EmpDetailsOB);
            return userDetail;
        }
        public string GetUserEmailIdByBadgeNumber(int BadgeNumber)
        {
            return (from e in _dbContext.tbl_EmpDetails where e.BadgeNumber == BadgeNumber select e.EmailId).FirstOrDefault();
        }
        public string GetUserMgrEmailIdByUserBadgeNumber(int BadgeNumber)
        {
            string emailID = string.Empty;
            var user = _dbContext.tbl_EmpDetails.Where(e=> e.BadgeNumber == BadgeNumber).FirstOrDefault();
            var mgrUser = _dbContext.tbl_EmpDetails.Where(e=> e.BadgeNumber == user.ManagerBadgeNumber).FirstOrDefault();
            emailID = string.IsNullOrEmpty(mgrUser.EmailId) ? "lmsappemail@gmail.com" : mgrUser.EmailId;
            return emailID;
        }
        public Userdetails GetUserDetailByName(string userName)
        {
            try
            {
                tbl_EmpDetails userdetailsOB = null;
                userdetailsOB = (from e in _dbContext.tbl_EmpDetails
                 where e.UserName == userName
                 select e
                        ).FirstOrDefault();
                if(userdetailsOB!=null)
                {
                    tbl_Department dept = (from d in _dbContext.tbl_Departments where d.ID == userdetailsOB.DeptId select d).FirstOrDefault();
                    userdetailsOB.Department = dept;

                }
                Userdetails userDetail = null;
                userDetail = _employeeDetailsMapper.GetUserDetilsFromTbl_EmpDetailsOB(userdetailsOB);
                return userDetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<LeaveModel> GetEmployeeLeave(string UserName)
        {
            IEnumerable<LeaveModel> employeeleaves = null;
            employeeleaves =  ( from l in _dbContext.tbl_Leaves
                                from s in _dbContext.tbl_Status
                                from d in _dbContext.tbl_Departments
                                from u in _dbContext.tbl_EmpDetails
                                where  l.BadgeNumber==u.BadgeNumber
                                        && l.Status==s.StatusId
                                        && l.DeptId==d.ID
                                        && u.UserName==UserName
                                    select new LeaveModel
                                    {
                                        BadgeNumber = l.BadgeNumber,
                                        EmployeeName = l.EmployeeName,
                                        DepartmentName = d.departmentName,
                                        LeaveFromDate = l.LeaveFromDate,
                                        LeaveToDate = l.LeaveToDate,
                                        NumberOfLeaves = l.NumberOfLeaves,
                                        Reason = l.Reason,
                                        Status = l.Status,
                                        StatusName = s.StatusName,
                                        LeaveTypeId=l.LeaveTypeId,
                                        LeaveType = _leaveTypeMapper.GetListofLeaveTypeFromLeaveTypeOB(_dbContext.tbl_LeaveTypes.Where(ltype => ltype.LeaveTypeId == l.LeaveTypeId).ToList())

                                    }
                            ).ToList();
            return employeeleaves;
        }

        public IEnumerable<LeaveModel> GetMyEmployeeLeaveAR(string UserName)
        {
            IEnumerable<LeaveModel> employeeleaves = null;
            employeeleaves = (from l in _dbContext.tbl_Leaves
                              from s in _dbContext.tbl_Status
                              from d in _dbContext.tbl_Departments
                              from u in _dbContext.tbl_EmpDetails
                              where l.ManagerBadgeNumber == u.BadgeNumber
                                      && l.Status == s.StatusId
                                      && l.DeptId == d.ID
                                      && u.UserName == UserName
                              select new LeaveModel
                              {
                                  BadgeNumber = l.BadgeNumber,
                                  EmployeeName = l.EmployeeName,
                                  DepartmentName = d.departmentName,
                                  LeaveFromDate = l.LeaveFromDate,
                                  LeaveToDate = l.LeaveToDate,
                                  NumberOfLeaves = l.NumberOfLeaves,
                                  Reason = l.Reason,
                                  Status = l.Status,
                                  StatusName = s.StatusName,
                                  LeaveType = _leaveTypeMapper.GetListofLeaveTypeFromLeaveTypeOB( _dbContext.tbl_LeaveTypes.Where(ltype=>ltype.LeaveTypeId==l.LeaveTypeId).ToList())
                                  ,ID=l.ID
                              }
                            ).ToList();
            return employeeleaves;
        }

        public IEnumerable<LeaveType> LeaveType()
        {
            IEnumerable<tbl_LeaveType> tbl_LeaveTypes = _dbContext.tbl_LeaveTypes.ToList();
            return _leaveTypeMapper.GetListofLeaveTypeFromLeaveTypeOB(tbl_LeaveTypes);

        }

        public IEnumerable<LeaveMaster> GetUserLeaveMasterByUserName(string UserName)
        {
            IEnumerable<LeaveMaster> leaveMaster = null;
            leaveMaster = (from lm in _dbContext.tbl_LeaveMasters
                           from lt in _dbContext.tbl_LeaveTypes
                           where lm.UserName == UserName && lm.LeaveTypeId == lt.LeaveTypeId
                           select new LeaveMaster
                           {
                               LeaveMasterId = lm.LeaveMasterId,
                               LeaveTypeId = lm.LeaveTypeId,
                               LeaveTypeName = lt.LeaveTypeName,
                               AllotedLeaves = lm.AllotedLeaves,
                               UsedLeaves = lm.UsedLeaves,
                               BalanceLeave = lm.BalanceLeave,
                               Year = lm.Year,
                               UserName = lm.UserName
                           }).ToList();


            return leaveMaster;
        }
    }
}
