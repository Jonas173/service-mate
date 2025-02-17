using AutoMapper;
using ServiceMate.Models.Domain;
using ServiceMate.Models.DTO;
using ServiceMate.Repositories;

namespace ServiceMate.Services;

public class UserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;
    
    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public UserDto? CreateUser(AddUserRequestDto userDto)
    {
        var newEntry = new User
        {
            Username = userDto.Username,
            Email = userDto.Email,
            Password = userDto.Password, // TODO hash
            FirstName = userDto.FirstName,
            LastName = userDto.LastName
        };

        User? newUser = null;
        try
        {
            newUser = _repository.CreateUser(newEntry);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // TODO use logger
        }
        
        if (newUser == null) return null;

        return _mapper.Map<UserDto>(newUser);
    }

    public UserDto[] GetAllUsers()
    {
        var users = _repository.GetUsers().ToList();

        return _mapper.Map<UserDto[]>(users);
    }
}