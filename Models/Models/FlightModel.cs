using Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FlightModel
    {
        public Guid Id { get; set; }
        public FlightType FlightType { get; set; }
        public string FlightNumber { get; set; }
    }
}
