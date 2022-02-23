using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Project
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public string content2 { get; set; }

        public string title { get; set; }
        public string photoUrl { get; set; }
        public string photoUrl2 { get; set; }
        public int status { get; set; }         // 0 means Past,   1 means Ongoing, 2 Future

        public bool language { get; set; }



    }
}