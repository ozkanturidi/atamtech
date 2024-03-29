﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class New
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public string content2 { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public bool language { get; set; }
        public string fotoUrl { get; set; }

        public string fotoUrl2 { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}