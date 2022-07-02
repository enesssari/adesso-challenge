using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace AdessoChallange_WebApplication1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
       
        public IActionResult Get()
        {
            return Ok("Hello World!");
            
        }


        [HttpPost]

        public IActionResult Post(JObject payload)
        {
            return Ok(payload);

        }

    }
}
