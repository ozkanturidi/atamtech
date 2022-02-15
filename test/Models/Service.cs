using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Service
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string photoUrl { get; set; }
        public string content { get; set; }

        public string servicedetail { get; set; }
        public string servicedetail2 { get; set; }

        public string photoUrl2 { get; set; }
        public string photoUrl3 { get; set; }

    }
}