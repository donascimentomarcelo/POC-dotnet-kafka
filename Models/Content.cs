using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_dotnet_kafka.Models
{
    public class Content
    {
        public long CreatedAtUtc { get; set; }
        public string EventID { get; set; }
        public string Kind { get; set; }
        public string Source { get; set; }
    }
}