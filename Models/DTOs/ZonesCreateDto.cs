using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarParking.Models.DTOs
{
    public class ZonesCreateDto
    {

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "")]
        public double pricePerHours { get; set; }
        public TimeSpan CreatedDateTime { get; set; }
    }
}
