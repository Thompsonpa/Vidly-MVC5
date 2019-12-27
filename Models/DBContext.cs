using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }
        public DbSet<Customers> Customers { get; set; } // My domain models
        public DbSet<Movies> Movies { get; set; }// My domain models
    }
}