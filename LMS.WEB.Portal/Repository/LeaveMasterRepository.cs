using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Repository
{
    public class LeaveMasterRepository : ILeaveMasterRepository
    {
        private readonly DataBaseContext _dbContext;
        public LeaveMasterRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<tbl_LeaveMaster> GetLeaveMaster()
        {
            return _dbContext.tbl_LeaveMasters.ToList();
        }

        public IEnumerable<LeaveMaster> GetLeaveMasterByUserName(string UserName)
        {
            IEnumerable<LeaveMaster> leaveMaster=null;
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
                                UserName= lm.UserName
                           }).ToList();
                              

            return leaveMaster;
        }
    }
}
