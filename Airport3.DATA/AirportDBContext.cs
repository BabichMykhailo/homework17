using Airport.DATA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DATA
{
    public class AirportDBContext : DbContext
    {
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }

        public AirportDBContext() : base("Data Source=DESKTOP-0HLV6ID\\MSSQLSERVER03;Initial Catalog=AirportDB;Integrated Security=true")
        {
            
        }
    }
}
