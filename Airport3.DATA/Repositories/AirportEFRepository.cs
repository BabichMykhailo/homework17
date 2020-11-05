using Airport.DATA;
using Airport.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DATA.Repositories
{
    public class AirportEFRepository
    {
        private readonly AirportDBContext _ctx;
        public AirportEFRepository()
        {
            _ctx = new AirportDBContext();
        }
        public void DeletePilotById(int id)
        {
            var entity = _ctx.Pilots.FirstOrDefault(x => x.Id == id);
            _ctx.Pilots.Remove(entity);
            _ctx.SaveChanges();
        }

        public void DeletePlaneById(int id)
        {
            var entity = _ctx.Planes.FirstOrDefault(x => x.Id == id);
            _ctx.Planes.Remove(entity);
            _ctx.SaveChanges();
        }

        public void DeleteFlightById(int id)
        {
            var entity = _ctx.Flights.FirstOrDefault(x => x.Id == id);
            _ctx.Flights.Remove(entity);
            _ctx.SaveChanges();
        }

        public Pilot CreatePilot(Pilot model)
        {
            _ctx.Pilots.Add(model);
            _ctx.SaveChanges();
            return model;
        }

        public Plane CreatePlane(Plane model)
        {
            _ctx.Planes.Add(model);
            _ctx.SaveChanges();
            return model;
        }

        public Flight CreateFlight(Flight model)
        {
            _ctx.Flights.Add(model);
            _ctx.SaveChanges();
            return model;
        }
    }
}
