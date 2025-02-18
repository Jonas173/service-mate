using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ServiceMate.Models.Domain;
using ServiceMate.Models.DTO;
using ServiceMate.Repositories;

namespace ServiceMate.Services;

public class UserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;
    private readonly PasswordHasher<User> _passwordHasher;
    private readonly ILogger<UserService> _logger;
    
    public UserService(IUserRepository repository, IMapper mapper, ILogger<UserService> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _passwordHasher = new PasswordHasher<User>();
        _logger = logger;
    }

    public UserDto? CreateUser(AddUserRequestDto userDto)
    {
        var newEntry = new User
        {
            UserName = userDto.Username,
            Email = userDto.Email,
            FirstName = userDto.FirstName,
            LastName = userDto.LastName
        };

        newEntry.PasswordHash = _passwordHasher.HashPassword(newEntry, userDto.Password);
        
        try
        {
            var newUser = _repository.CreateUser(newEntry);
            return _mapper.Map<UserDto>(newUser);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating user with email {Email}", userDto.Email);
            return null;
        }
    }

    public UserDto[] GetAllUsers()
    {
        var users = _repository.GetUsers().ToList();

        return _mapper.Map<UserDto[]>(users);
    }
}