using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Confluent.Kafka;
using Confluent.SchemaRegistry.Serdes;
using Confluent.SchemaRegistry;
using POC_dotnet_kafka.Models;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace POC_dotnet_kafka.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvroController : ControllerBase
    {

        public AvroController()
        {

        }

        [HttpPost]
        public IActionResult Post([FromBody] AvroDTO dto)
        {
            using (var reader = new StreamReader(@"Data/data.csv"))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<User>();

                foreach (var record in records)
                {
                    Console.WriteLine($"Name: {record.name}, Age: {record.age}");
                }
            }
            return Ok(dto);
        }
    }
}

public class User
{
    public string name { get; set; }
    public int age { get; set; }
}