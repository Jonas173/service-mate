using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public interface IScheduledMaintenanceRepository
{
    ScheduledMaintenance[] GetScheduledMaintenances();
}