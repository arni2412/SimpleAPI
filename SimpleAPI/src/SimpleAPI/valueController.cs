using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class valueController : ControllerBase
    {
       // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "pradeep", "amar" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            return "pradeep";
        }

        
    }  
    }
