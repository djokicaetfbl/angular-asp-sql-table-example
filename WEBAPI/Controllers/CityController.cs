using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Atlanta", "New York", "Chicago", "Boston" }; // kad radimo sa API , ako ocemo da se odma reflektuje u browser-u 
                                                                       //Debug -> Start without debug mode
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Atlanta";
        }
    }
}
