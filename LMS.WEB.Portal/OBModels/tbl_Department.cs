using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.OBModels
{
    public class tbl_Department
    {
        [Key]
        public int ID { get; set; }
        public string departmentName {get;set;}
    }
}
