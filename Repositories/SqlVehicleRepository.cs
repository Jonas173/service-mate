using ServiceMate.Data;
using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public class SqlVehicleRepository: IVehicleRepository
{
    private readonly ServiceDbContext _dbContext;

    public SqlVehicleRepository(ServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Vehicle[] GetVehicles()
    {
        return _dbContext.Vehicles.ToArray();
    }
}