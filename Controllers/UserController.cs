using Microsoft.AspNetCore.Mvc;
using ServiceMate.Models.DTO;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] AddUserRequestDto addUserRequestDto)
    {
        var createdUser = _service.CreateUser(addUserRequestDto);

        if (createdUser == null) return BadRequest();

        return Ok(createdUser);
    }
}