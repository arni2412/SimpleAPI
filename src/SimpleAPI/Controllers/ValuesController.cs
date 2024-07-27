using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
             var values = new string[] { "pradeep1", "amar" };
            return (values); // Return an HTTP 200 response with the list of strings
       
        }

        //GET: api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "pradeep kumar";
        }

    }
}