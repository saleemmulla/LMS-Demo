using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LMSRestFullWebAPI.Models
{
    public class Leave
    {
        [JsonProperty(PropertyName = "Id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "BadgeNumber")]
        public int BadgeNumber { get; set; }

        [JsonProperty(PropertyName = "LeaveFromDate")]
        public DateTime LeaveFromDate { get; set; }

        [JsonProperty(PropertyName = "LeaveToDate")]
        public DateTime LeaveToDate { get; set; }

        [JsonProperty(PropertyName = "NumberOfLeaves")]
        public int NumberOfLeaves { get; set; }

        [JsonProperty(PropertyName = "RequestedOn")]
        public DateTime RequestedOn { get; set; }

        [JsonProperty(PropertyName = "Status")]
        public int Status { get; set; }
       
    }
}
