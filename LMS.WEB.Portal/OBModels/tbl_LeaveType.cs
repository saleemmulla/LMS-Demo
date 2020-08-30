using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.OBModels
{
    public class tbl_LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
    }
}
