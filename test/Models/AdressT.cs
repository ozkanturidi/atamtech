using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class AdressT
    {
        [Key]
        public int id { get; set; }
        public string adress { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public string location { get; set; }

    }
}