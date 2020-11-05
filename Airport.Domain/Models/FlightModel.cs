using Airport.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Domain.Model
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string FlightCity { get; set; }
        public DateTime FlightTime { get; set; }

        public int PilotId { get; set; }
        public PilotModel Pilot { get; set; }

        public int PlaneId { get; set; }
        public PlaneModel Plane { get; set; }
    }
}
