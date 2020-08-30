using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Repository
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataBaseContext _dbContext;
        public StatusRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<tbl_Status> GetStatus()
        {
           return  _dbContext.tbl_Status.ToList();
        }
    }
}
