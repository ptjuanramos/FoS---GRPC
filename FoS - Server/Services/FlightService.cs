using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Business.Interfaces;
using Grpc.Core;
using Models;
using pe = Common.Enums;

namespace ServerFoS.Services
{
    public class FlightService : Flight.FlightBase
    {
        private readonly IFlightBindMagicPotion _flightBindMagicPotion;
        public FlightService(IFlightBindMagicPotion flightBindMagicPotion)
        {
            _flightBindMagicPotion = flightBindMagicPotion;
        }

        public override async Task<BindFlightResponse> BindFlight(BindFlightRequest request, ServerCallContext context)
        {
            var resultModel = await _flightBindMagicPotion.BindFlight(new FlightModel
            {
                FlightNumber = request.FlightNumber,
                FlightType = (pe.FlightType)request.Type
            });

            return new BindFlightResponse
            {
                Id = Guid.Parser.ParseFrom(resultModel.Id.ToByteArray()),
                FlightNumber = resultModel.FlightNumber,
                Type = (FlightType) resultModel.FlightType
            };
        }
    }
}
