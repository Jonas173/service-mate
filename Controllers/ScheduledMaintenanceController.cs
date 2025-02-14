using Microsoft.AspNetCore.Mvc;
using ServiceMate.Repositories;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/scheduled-maintenances")]
public class ScheduledMaintenanceController: ControllerBase
{
    private readonly ScheduledMaintenanceService _service;

    public ScheduledMaintenanceController(ScheduledMaintenanceService service)
    {
        _service = service;
    }
}