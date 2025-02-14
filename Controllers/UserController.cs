using Microsoft.AspNetCore.Mvc;
using ServiceMate.Models.DTO;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Microsoft.AspNetCore.Components.Route("api/users")]
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
        var createdUser = await _service.createUser(addUserRequestDto);

        if (!createdUser) return BadRequest();

        return Ok(createdUser);
    }
}