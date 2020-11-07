using Airport.Controller;
using Airport.Model.PostModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var controllerf = new AirportFlightsController();

            var flight = new FlightPostModel()
            {
                FlightCity = "Kiev - New-York",
                FlightTime = DateTime.Now,
                Pilot = new PilotPostModel()
                {
                    FirstName = "Igor",
                    LastName = "Ivanov",
                }, Plane = new PlanePostModel()
                {
                    ModelOfPlane = "Boeing 737",
                    PassengerCapacity = 180
                }
            };

            var flightcreate = controllerf.Create(flight);

        }
    }
}
