using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParking.Models.Entities
{

  
    public class Parking
    {

        public int Id { get; set; }

        public DateOnly StartTime { get; set; }

        public DateOnly StopTime { get; set; }

        public double TotalPrice {  get; set; }

        public DateOnly CreatedAt { get; set; }

        public DateOnly UpdatedAt { get; set; }
        
        public int VehicleID { get; set; }

        public int ZoneID { get; set; }

      //  public int UserID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }

        public Zone Zone { get; set; }

        //public User User { get; set; }


    }
}
