using Data.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IFlightBindRepository
    {
        Task<FlightBind> BindFlight(FlightModel flight);
    }
}
