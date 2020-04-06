using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFlightBindMagicPotion
    {
        Task<FlightModel> BindFlight(FlightModel model);
    }
}
