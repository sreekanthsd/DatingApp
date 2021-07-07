using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
              [HttpGet("Test")]
        public string Test()
        {
            string str="test";
            return str;
        }  
    }
}