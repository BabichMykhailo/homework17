using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DATA.Model
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightCity { get; set; }
        public DateTime FlightTime { get; set; }

        public int PilotId { get; set; }
        public virtual Pilot Pilot { get; set; }

        public int PlaneId { get; set; }
        public virtual Plane Plane { get; set; }
    }
}
