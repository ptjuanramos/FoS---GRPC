using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class FlightBind
    {
        public Guid Id { get; set; }
        public int FlightType { get; set; }
        public string FlightNumber { get; set; }
    }
}
