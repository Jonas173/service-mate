using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ServiceMate.Models.DTO;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly UserService _service;

    public UsersController(UserService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] AddUserRequestDto addUserRequestDto)
    {
        var createdUser = _service.CreateUser(addUserRequestDto);

        if (createdUser == null) return BadRequest();

        return Created();
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _service.GetAllUsers();
        
        return Ok(users);
    }
}