using Microsoft.AspNetCore.Mvc;
using CarParking.Services;
using CarParking.Services;

namespace CarParking.Controllers
{
    public class ParkingController : Controller
    {
        private readonly ParkingService _parkingService;
        public ParkingController(ParkingService parkingService) {
        _parkingService = parkingService;
        }


        //Parking.getall nuk u thirr
        // u dasht me shtu private readonly ParkingService _parkingService;
        //[HttpGet("GetParkings")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    var parkings = await _parkingService.GetAllParkings();

        //    if (parkings == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(parkings);
        //}

        [HttpGet("GetParkings")]
        public async Task<IActionResult> GetParkings()
        {
            var parkings = await _parkingService.GetAllParkings();

            return Ok(parkings);
        }

        [HttpGet("GetAllParkingsRelatedToZone")]
        public async Task<IActionResult> GetAllParkingsRelatedToZone(int Id)
        {

            //var r = await _parkingService.GetAllParkingsRelatedToZone(Id);
            return Ok(await _parkingService.GetAllParkingsRelatedToZone(Id));
        }


    }
}
