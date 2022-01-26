using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace test.Models
{
    public class Context:DbContext

    {

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<AdressT> AdressTs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<New> News { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Collaboration> Collaborations { get; set; }

        public DbSet<Project> Projects{ get; set; }


    }
}