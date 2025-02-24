using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceMate.Repositories;
using ServiceMate.Services;

namespace ServiceMate.Controllers;

[ApiController]
[Route("api/scheduled-maintenances")]
[Authorize]
public class ScheduledMaintenancesController: ControllerBase
{
    private readonly ScheduledMaintenanceService _service;

    public ScheduledMaintenancesController(ScheduledMaintenanceService service)
    {
        _service = service;
    }
}