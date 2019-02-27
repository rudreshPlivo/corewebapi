using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Console.WriteLine("ok get this now");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            return id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            Console.WriteLine(message.FromNumber);
            Console.WriteLine(message.ToNumber);
            Console.WriteLine(message.Text);
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

    public class Message
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string Text { get; set; }
    }
}
