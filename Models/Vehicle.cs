namespace ServiceMate.API.Models.Domain {
    public class Vehicle {
        public Guid Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int powerKw { get; set; }
    }
}