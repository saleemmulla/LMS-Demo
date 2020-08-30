using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Mappers
{
    public interface ILeaveTypeMapper
    {
        IEnumerable<LeaveType> GetListofLeaveTypeFromLeaveTypeOB(IEnumerable<tbl_LeaveType> leavesOB);
    }
}
