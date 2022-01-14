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
        public int name { get; set; }

    }
}