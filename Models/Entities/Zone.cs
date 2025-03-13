using System.Text.Json.Serialization;

namespace CarParking.Models.Entities
{
    public class Zone
    {
        public int Id { get; set; }

        public string ZoneName { get; set; }

        public double PricePerHour  { get; set; }

        public TimeSpan OpeningTime { get; set; }

        public TimeSpan EndingTime { get; set; }
        [JsonIgnore]
        public List<Parking> Parkings { get; set; }



    }
}
