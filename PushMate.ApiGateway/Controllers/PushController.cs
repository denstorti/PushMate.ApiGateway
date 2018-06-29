using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PushMate.FcmPushService.DTO;

namespace PushMate.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PushController : ControllerBase
    {
        // GET: api/Push
        [HttpGet]
        public IEnumerable<string> Get()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://localhost:9000/api/templating?templateText=Hi%20$name$&name=Denis");
            string text = result.Result.Content.ReadAsStringAsync().Result;

            return new string[] { "value1", "value2" };
        }

        // POST: api/Push
        [HttpPost]
        public void Post([FromBody] string message)
        {
            

        }
        
    }
}
