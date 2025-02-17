using Microsoft.AspNetCore.Mvc;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController: ControllerBase {
    private readonly ServiceService _service;

    public ServicesController(ServiceService service) {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllServices() {
        return Ok("Ok");
    }

    [HttpGet("abc")]
    public async Task<IActionResult> Post() {
        return Ok("Ok");
    }
}
