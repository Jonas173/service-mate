using ServiceMate.Models.Domain;
using ServiceMate.Models.DTO;
using ServiceMate.Repositories;

namespace ServiceMate.Services;

public class UserService
{
    private readonly IUserRepository _repository;
    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public UserDto CreateUser(AddUserRequestDto userDto)
    {
        var newEntry = new User
        {
            Username = userDto.Username,
            Email = userDto.Email,
            Password = userDto.Password, // TODO hash
            FirstName = userDto.FirstName,
            LastName = userDto.LastName
        };

        var newUser = _repository.CreateUser(newEntry);

        if (newUser == null) return null;

        return new UserDto { 
            Id = newUser.Id, 
            Username = newUser.Username, 
            Email = newUser.Email, 
            FirstName = newUser.FirstName, 
            LastName = newUser.LastName 
        };
    }
}