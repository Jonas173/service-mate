using ServiceMate.Data;
using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public class SqlScheduledMaintenanceRepository: IScheduledMaintenanceRepository
{
    private readonly ServiceDbContext _dbContext;

    public SqlScheduledMaintenanceRepository(ServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ScheduledMaintenance[] GetScheduledMaintenances()
    {
        return _dbContext.ScheduledMaintenances.ToArray();
    }
}