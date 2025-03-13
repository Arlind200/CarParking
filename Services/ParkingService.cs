using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarParking.Data.UnitofWork;
using CarParking.Models.Entities;
using System.Linq.Expressions;

namespace CarParking.Services
{
    public class ParkingService
    {
     //   private readonly IMapper _mapper;
        private readonly UnitofWork _unitofwork;

        public ParkingService(UnitofWork unitofWork)
        {
            _unitofwork = unitofWork;
        }

        public async Task<List<Parking>> GetAllParkings()
        {
            var categories = _unitofwork.Repository<Parking>().GetAll();

            return categories.ToList();
        }

        public async Task<List<Parking>> GetAllParkingsRelatedToZone(int Id)
        {

            Expression < Func<Parking, bool> > expression = x => Id == x.ZoneID;

            var categories = _unitofwork.Repository<Parking>().GetByCondition(expression);

            return categories.ToList();
        }

    }
}
