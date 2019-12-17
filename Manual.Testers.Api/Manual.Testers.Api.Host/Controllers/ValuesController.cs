using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manual.Testers.Api.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manual.Testers.Api.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("Order")]
        [HttpPost]
        public void Post([FromBody]Order order)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
