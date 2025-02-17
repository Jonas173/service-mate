using ServiceMate.Data;
using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public class SqlUserRepository : IUserRepository
{
    private readonly ServiceDbContext _dbContext;

    public SqlUserRepository(ServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User CreateUser(User user)
    {
        var entry = _dbContext.Users.Add(user);
        _dbContext.SaveChanges();

        return entry.Entity;
    }

    public User[] GetUsers()
    {
        return _dbContext.Users.ToArray();
    }
}