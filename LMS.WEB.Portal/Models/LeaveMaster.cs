using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Models
{
    public class LeaveMaster
    {
        [Key]
        public int LeaveMasterId { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int AllotedLeaves { get; set; }
        public int UsedLeaves { get; set; }
        public int BalanceLeave { get; set; }
        public int Year { get; set; }
        public string UserName { get; set; }
    }
}
