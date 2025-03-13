namespace CarParking.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string PlateNumber { get; set; }

        public string CarType { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public List<Parking> Parkings { get; set; } = new();



    }
}
