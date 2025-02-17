using ServiceMate.Models.Domain;

namespace ServiceMate.Repositories;

public interface IServiceRepository
{
    Service[] GetServices();
}