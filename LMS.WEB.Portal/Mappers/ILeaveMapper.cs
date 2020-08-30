using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.OBModels;
using LMS.WEB.Portal.Models;
namespace LMS.WEB.Portal.Mappers
{
    public interface ILeaveMapper
    {
        LeaveModel GetLeaveModelFromLeavesOB(tbl_Leaves LeavesOB);
        tbl_Leaves GetLeavsOBFromLeaveModel(LeaveModel leaveModel);

        IEnumerable<LeaveModel> GetListofLMFromLeavesOB(IEnumerable<tbl_Leaves> leavesOB);
    }
}
