using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var values = new string[] { "pradeep1", "amar" };
            return Ok(values); // Return an HTTP 200 response with the list of strings
        }

        // // GET: api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     // Simple logic to return a specific value based on ID
        //     var values = new Dictionary<int, string>
        //     {
        //         { 1, "pradeep kumar" },
        //         { 2, "amar" }
        //     };

        //     if (values.TryGetValue(id, out var value))
        //     {
        //         return Ok(value); // Return an HTTP 200 response with the string value
        //     }

        //     return NotFound(); // Return HTTP 404 if the ID is not found
        // }
    }
}
