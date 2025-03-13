using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarParking.Models.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

      //  public List<Parking> Parkings { get; set; } = new();

        public List<Vehicle> Vehicles { get; set; } = new();
        
    }
}
