using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string flightTime { get; set; }
        public string maxFlightrouteLength { get; set; }
        public string  windSpeedTolerance { get; set; }
        public string flightSpeed { get; set; }
        public string weight { get; set; }
        public string wingSpan { get; set; }
        public string minSafeFlightAltitude { get; set; }
        public string maxFlightAltitude { get; set; }

        public string motor { get; set; }
        public string takeOffLanding { get; set; }

        public string motor2 { get; set; }



    }
}