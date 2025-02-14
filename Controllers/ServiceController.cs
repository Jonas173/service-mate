using Microsoft.AspNetCore.Mvc;
using ServiceMate.Data;
using ServiceMate.Models;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiceController: ControllerBase {
    private readonly ServiceDbContext _dbContext;

    public ServiceController(ServiceDbContext dbContext) {
        this._dbContext = dbContext;
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
