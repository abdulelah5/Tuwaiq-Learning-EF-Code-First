using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Entity
{
    public class Context : DbContext
    {
        public Context(): base("CodeFirstEntity")
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}