using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Repository
{
    public interface ILeaveMasterRepository
    {
        IEnumerable<tbl_LeaveMaster> GetLeaveMaster();
        IEnumerable<LeaveMaster> GetLeaveMasterByUserName(string UserName);
    }
}
