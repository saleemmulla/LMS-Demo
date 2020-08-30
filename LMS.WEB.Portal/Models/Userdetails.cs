using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Models
{
    public partial class Userdetails
    {
        [Key]
        public int BadgeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpDesigName { get; set; }
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string EmailId { get; set; }
        public int ManagerBadgeNumber { get; set; }
        public string ManagerName { get; set; }
        public string UserName { get; set; }
        public string GetFullName()
        {
            return $"{this.FirstName + " " + this.LastName}";
        }
    }
}
