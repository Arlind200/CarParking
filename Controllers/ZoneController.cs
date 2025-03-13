using Microsoft.AspNetCore.Mvc;
using CarParking.Data.UnitofWork;
using CarParking.Models.Entities;
using CarParking.Services;
using CarParking.Models.DTOs;

namespace CarParking.Controllers
{
    public class ZoneController : Controller
    {
        private readonly ZoneService _zoneService;
        public ZoneController(ZoneService zoneService)
        {

            _zoneService = zoneService;

        }




        [HttpGet("GetZones")]
        public async Task<IActionResult> GetZones()
        {
            var zones = await _zoneService.GetAllZones();

            return Ok(zones);
        }

        [HttpGet("GetZonesById")]
        public async Task<IActionResult> GetZonesbyID(int Id)
        {
            var zones = await _zoneService.GetZoneById(Id);

            if (zones == null)
            {
                return NotFound();
            }
            return Ok(zones);
        }

        [HttpGet("GetZonesByIdWithParkings")]
        public async Task<IActionResult> GetZonesbyIdWithParking(int Id)
        {
            var zones = await _zoneService.GetZoneWithParkings(Id);

            if (zones == null)
            {
                return NotFound();
            }
            return Ok(zones);
        }

        [HttpPost("PostZones")]
        public async Task<IActionResult> Post(ZonesCreateDto newzone) {
            
            _zoneService.PutZonewith(newzone);
            return Ok("Zone created sucessfully");
        
        }







    }
}
