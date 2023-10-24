using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_dotnet_kafka.Models
{
    public class AvroDTO
    {
        public AccountType AccountType { get; set; }
        public BaseEvent BaseEvent { get; set; }
        public string CategoryType { get; set; }
        public string Description { get; set; }
    }
}