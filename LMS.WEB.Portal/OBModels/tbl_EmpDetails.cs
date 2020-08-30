using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.OBModels
{
    public class tbl_EmpDetails
    {
        [Key]
        public int BadgeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpDesigName { get; set; }
        
        public int DeptId { get; set; }
        public string EmailId { get; set; }
        public int? ManagerBadgeNumber { get; set; }
        public string UserName { get; set; }
        [ForeignKey("DeptId")]
        public virtual tbl_Department Department { get; set; }
    }
}
