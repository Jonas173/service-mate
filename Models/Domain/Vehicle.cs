namespace ServiceMate.Models.Domain;

public class Vehicle 
{
    public Guid Id { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int PowerKw { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }
}
