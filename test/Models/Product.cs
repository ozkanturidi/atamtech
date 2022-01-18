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

        public string content { get; set; }

        public string flightTime { get; set; }
        public string flightRange { get; set; }
        
        public string cruiseSpeed { get; set; }
        public string payload { get; set; }
        public string setupTime  { get; set; }      






        public string motor4 { get; set; }


    }
}