using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public interface IUserRepository
{
   User CreateUser(User user);
   User[] GetUsers();
}