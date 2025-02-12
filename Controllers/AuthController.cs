using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceMate.API.Controller {
    [ApiController]
    [Route("api/")]
    public class AuthController: ControllerBase {
        [Post("login")]
        public IActionResult Login() {
            // TODO
        }

        [Get("logout")]
        public IActionResult Logout() {
            // TODO
        }
    }
}