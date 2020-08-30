using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Repository
{
    public interface IStatusRepository
    {
        IEnumerable<tbl_Status> GetStatus();
    }
}
