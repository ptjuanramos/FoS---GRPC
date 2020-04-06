using Business.Interfaces;
using Common.Enums;
using DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class FlightBindMagicPotion : IFlightBindMagicPotion
    {
        private readonly IFlightBindRepository _flightBindRepository;
        public FlightBindMagicPotion(IFlightBindRepository flightBindRepository)
        {
            _flightBindRepository = flightBindRepository;
        }

        public async Task<FlightModel> BindFlight(FlightModel model)
        {
            //todo: some logic and magic here
            var dbModel = await _flightBindRepository.BindFlight(model);
            return new FlightModel
            {
                Id = dbModel.Id,
                FlightNumber = dbModel.FlightNumber,
                FlightType = (FlightType)dbModel.FlightType
            };
        }
    }
}
