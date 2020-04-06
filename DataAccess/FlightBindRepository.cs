using Data.Models;
using DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FlightBindRepository : IFlightBindRepository
    {
        public Task<FlightBind> BindFlight(FlightModel flightBind)
        {
            //todo: for now return dummy obj
            return Task.Run(() => new FlightBind
            {

                FlightNumber = flightBind.FlightNumber,
            });
        }
    }
}
