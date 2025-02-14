namespace ServiceMate.Models.Domain;

// Grossly simplified for now
public enum MaintenanceItem
{
    EngineOilChange,
    SparkPlugChange,
    CoolantChange,
    TransmissionOilChange
}

// Also very simplified, should not be associated with a specific Vehicle but rather a certain model, but that would
// be too complex for now.
public class ScheduledMaintenance
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public MaintenanceItem[] MaintenanceItems { get; set; }

    public int DueAfterKm { get; set; }
    public int? DueAfterMonths { get; set; }
    
    public Guid VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
}