using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Models
{
    public class LoginViewModel
    {
        [Required]
        [Key]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
