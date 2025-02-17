using AutoMapper;
using ServiceMate.Models.Domain;
using ServiceMate.Models.DTO;

namespace ServiceMate.Mappings;

public class UserMappingProfile: Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}