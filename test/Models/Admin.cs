﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}