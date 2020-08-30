using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly DataBaseContext _dbContext;
        public LeaveTypeRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<tbl_LeaveType> GetLeaveType()
        {
           return  _dbContext.tbl_LeaveTypes.ToList();
        }
    }
}
