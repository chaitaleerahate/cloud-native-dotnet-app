using Microsoft.AspNetCore.Mvc;

namespace GreetingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from GreetingService" });
        }
    }
}
