using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manual.Testers.Api.Host.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Manual.Testers.Api.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*
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
        */

        // POST api/values
        [Route("Order")]
        [Authorize]
        [HttpPost]
        public int Post([FromBody]Order order)
        {
            var a = User.Identity.Name;
        }
    }
}
