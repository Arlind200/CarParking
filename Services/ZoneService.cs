using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using CarParking.Data.UnitofWork;
using CarParking.Models.DTOs;
using CarParking.Models.Entities;
using System.Linq.Expressions;

namespace CarParking.Services
{
    public class ZoneService 
    {
        //private readonly IMapper _mapper;
        private readonly UnitofWork _unitofwork;

        public ZoneService(UnitofWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public async Task<List<Zone>> GetAllZones()
        {
            var zones = _unitofwork.Repository<Zone>().GetAll();
            return zones.ToList();
        }

        public async Task<Zone> GetZoneById(int Id)
        {
            Expression<Func<Zone, bool>> expression = x => x.Id == Id;
            var zone = await _unitofwork.Repository<Zone>().GetById(expression).FirstOrDefaultAsync();
            return zone;
        }

        public async Task<Zone> GetZoneWithParkings(int Id)
        {
            Expression <Func<Zone, bool>> expression = x => x.Id == Id;

            var zone = await _unitofwork.Repository<Zone>().GetByCondition(expression).Include(z => z.Parkings).FirstOrDefaultAsync();
            return zone;
        }

        public async Task PutZonewith(ZonesCreateDto zonetocreate)
        {
            // ZonesCreateDto zonetoCreate = new ZonesCreateDto("Zona 4", 2.43, TimeSpan.FromHours(4.3));

            var zone = new Zone
            {

                ZoneName = zonetocreate.Name,
                PricePerHour=zonetocreate.pricePerHours
                
            };

            _unitofwork.Repository<Zone>().Create(zone);
            _unitofwork.Complete();

        }
    }
}
