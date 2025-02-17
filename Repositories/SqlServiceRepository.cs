using ServiceMate.Data;
using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public class SqlServiceRepository : IServiceRepository
{
    private readonly ServiceDbContext _dbContext;

    public SqlServiceRepository(ServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Service[] GetServices()
    {
        return _dbContext.Services.ToArray();
    }
}