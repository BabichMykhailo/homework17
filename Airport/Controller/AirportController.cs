using Airport.DATA.Model;
using Airport.Domain.Model;
using Airport.Domain.Models;
using Airport.Domain.Services;
using Airport.Model.PostModels;
using Airport.Model.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Controller
{
    public class AirportController
    {
        private readonly AirportService _airportService;
        private readonly IMapper _mapper;
        public AirportController()
        {
            _airportService = new AirportService();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FlightPostModel, FlightModel>();
                cfg.CreateMap<FlightViewModel, FlightModel>().ReverseMap();
                cfg.CreateMap<PilotPostModel, PilotModel>();
                cfg.CreateMap<PilotViewModel, PilotModel>().ReverseMap();
                cfg.CreateMap<PlanePostModel, PlaneModel>();
                cfg.CreateMap<PlaneViewModel, PlaneModel>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);
        }

        public void DeletePilotById(int id)
        {
            _airportService.DeletePilotById(id);
        }

        public void DeletePlaneById(int id)
        {
            _airportService.DeletePlaneById(id);
        }

        public void DeleteFlightById(int id)
        {
            _airportService.DeleteFlightById(id);
        }

        public FlightViewModel CreateFlight(FlightPostModel model)
        {
            var flight = _mapper.Map<FlightModel>(model);
            var createdFlight = _airportService.CreateFlight(flight);
            var result = _mapper.Map<FlightViewModel>(createdFlight);
            return result;
        }

        public PlaneViewModel CreatePlane(PlanePostModel model)
        {
            var plane = _mapper.Map<PlaneModel>(model);
            var createdPlane = _airportService.CreatePlane(plane);
            var result = _mapper.Map<PlaneViewModel>(createdPlane);
            return result;
        }

        public PilotViewModel CreatePilot(PilotPostModel model)
        {
            var pilot = _mapper.Map<PilotModel>(model);
            var createdPilot = _airportService.CreatePilot(pilot);
            var result = _mapper.Map<PilotViewModel>(createdPilot);
            return result;
        }
    }
}
