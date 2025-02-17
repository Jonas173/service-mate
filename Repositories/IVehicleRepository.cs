using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public interface IVehicleRepository
{
    Vehicle[] GetVehicles();
}