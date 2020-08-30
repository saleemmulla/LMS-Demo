using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LMS.WEB.Portal.Models
{
    public class LeaveModel
    {
        [Key]
        public int ID { get; set; }
        public int BadgeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string ManagerName { get; set; }
        public int LeaveTypeId { get; set; }
        [Display(Name = "LeaveFromDate")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DateGreaterThanAttribute(ErrorMessage = "Leave from date is required.")]
        public DateTime LeaveFromDate { get; set; }
        [Display(Name = "LeaveToDate")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DateGreaterThanAttribute(ErrorMessage = "Leave to date is required.")]
        public DateTime LeaveToDate { get; set; }
        public int NumberOfLeaves { get; set; }
        public DateTime RequestedOn { get; set; }
        public string Reason { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public IEnumerable<LeaveType> LeaveType{ get;set;}
    }
}
