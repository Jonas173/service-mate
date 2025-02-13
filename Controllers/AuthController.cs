using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceMate.API.Controllers {
    [ApiController]
    [Route("api")]
    public class AuthController: ControllerBase {
        [HttpPost("login")]
        public IActionResult Login() {
            return Ok("Logged in"); // TODO
        }

        [HttpGet("logout")]
        public IActionResult Logout() {
            return Ok("Logged out"); // TODO
        }
    }
}