using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Models
{
    public class ViewDahBoardModel
    {
        IEnumerable<LeaveModel> LeavesModel { get; set; }
        IEnumerable<LeaveMaster> LeaveMasters { get; set; }
    }
}
