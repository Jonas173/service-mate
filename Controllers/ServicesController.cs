using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceMate.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController: ControllerBase {
        [HttpGet]
        public IActionResult GetAllServices() {
            return Ok("Done");
        }
    }
}