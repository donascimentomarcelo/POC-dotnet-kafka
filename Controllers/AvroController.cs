using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Confluent.Kafka;
using POC_dotnet_kafka.Models;

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

            var producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            // var producer = new ProducerBuilder<Null, string>(producerConfig).build();

            // while (true)
            // {
            //     var userName = Faker.Name.FristName();

            //     Console.WriteLine(userName);

            //     producer.Producer("")
            // }

            return Ok(dto);
        }
    }
}
