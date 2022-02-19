using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class AboutUs
    {
        [Key]
        public int id { get; set; }
        public string fotoUrl { get; set; }
        public string aboutUs { get; set; }
        public bool language { get; set; }

    }
}