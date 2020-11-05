using Airport.DATA.Model;
using Airport.DATA.Repositories;
using Airport.Domain.Model;
using Airport.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Domain.Services
{
    public class AirportService
    {
        private readonly AirportEFRepository _airportRepository;
        private readonly IMapper _mapper;
        public AirportService()
        {

            _airportRepository = new AirportEFRepository();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FlightModel, Flight>();
                cfg.CreateMap<PilotModel, Pilot>();
                cfg.CreateMap<PlaneModel, Plane>();
                cfg.CreateMap<FlightModel, Flight>().ReverseMap();
                cfg.CreateMap<PilotModel, Pilot>().ReverseMap();
                cfg.CreateMap<PlaneModel, Plane>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);
        }

        public void DeletePilotById(int id)
        {
            _airportRepository.DeletePilotById(id);
        }

        public void DeletePlaneById(int id)
        {
            _airportRepository.DeletePlaneById(id);
        }

        public void DeleteFlightById(int id)
        {
            _airportRepository.DeleteFlightById(id);
        }

        public PilotModel CreatePilot(PilotModel model)
        {
            var pilot = _mapper.Map<Pilot>(model);
            var createdPilot = _airportRepository.CreatePilot(pilot);
            var result = _mapper.Map<PilotModel>(createdPilot);
            return result;
        }

        public PlaneModel CreatePlane(PlaneModel model)
        {
            var plane = _mapper.Map<Plane>(model);
            var createdPlane = _airportRepository.CreatePlane(plane);
            var result = _mapper.Map<PlaneModel>(createdPlane);
            return result;
        }

        public FlightModel CreateFlight(FlightModel model)
        {
            var flight = _mapper.Map<Flight>(model);
            var createdFlight = _airportRepository.CreateFlight(flight);
            var result = _mapper.Map<FlightModel>(createdFlight);
            return result;
        }
    }
}
