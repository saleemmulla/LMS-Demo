using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSRestFullWebAPI.Models
{
    public class Department
    {
        [JsonProperty(PropertyName = "Id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "DepartmentName")]
        public string DepartmentName { get; set; }
    }
}
