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
    public class AirportFlightsController
    {
        private readonly AirportFlightsService _airportFlightsService;
        private readonly IMapper _mapper;
        public AirportFlightsController()
        {
            _airportFlightsService = new AirportFlightsService();
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

        public void DeleteFlightById(int id)
        {
            _airportFlightsService.DeleteById(id);
        }

        public FlightViewModel Create(FlightPostModel model)
        {
            var flight = _mapper.Map<FlightModel>(model);
            var created = _airportFlightsService.Create(flight);
            var result = _mapper.Map<FlightViewModel>(created);
            return result;
        }
    }
}
