namespace ServiceMate.Models.Domain;

public class Service 
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int PerformedAtKm { get; set; }
    public DateTime PerformedAt { get; set; }

    public Guid ScheduledMaintenanceId { get; set; }
    public ScheduledMaintenance ScheduledMaintenance { get; set; }
}