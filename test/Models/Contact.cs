using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }
        public string nameSurname { get; set; }
        public string mail { get; set; }
        public string message { get; set; }
    }
}