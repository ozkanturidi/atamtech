using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string Mail { get; set; }
        public string comment { get; set; }

        public News News { get; set; }

    }
}