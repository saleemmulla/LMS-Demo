using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.OBModels
{
    public class tbl_Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}
