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
        public int NewId { get; set; }
        public virtual New New { get; set; }

    }
}