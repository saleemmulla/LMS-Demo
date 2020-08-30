using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.OBModels
{
    public class tbl_Leaves
    {
        [Key]
        public int ID { get; set; }
        public int BadgeNumber { get; set; }
        public string EmployeeName { get; set; }
        public int DeptId { get; set; }
        public int ManagerBadgeNumber { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime LeaveFromDate { get; set; }
        public DateTime LeaveToDate { get; set; }
        public int NumberOfLeaves { get; set; }
        public DateTime RequestedOn { get; set; }
        public string Reason { get; set; }
        public int Status { get; set; }
    }
}
