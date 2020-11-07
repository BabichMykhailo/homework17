﻿using Airport.Domain.Models;
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
    public class AirportPlanesController
    {
        private readonly AirportPlanesService _airportPlanesService;
        private readonly IMapper _mapper;
        public AirportPlanesController()
        {
            _airportPlanesService = new AirportPlanesService();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanePostModel, PlaneModel>();
                cfg.CreateMap<PlaneViewModel, PlaneModel>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);
        }

        public void DeleteById(int id)
        {
            _airportPlanesService.DeleteById(id);
        }

        public PlaneViewModel CreatePlane(PlanePostModel model)
        {
            var plane = _mapper.Map<PlaneModel>(model);
            var created = _airportPlanesService.Create(plane);
            var result = _mapper.Map<PlaneViewModel>(created);
            return result;
        }
    }
}
