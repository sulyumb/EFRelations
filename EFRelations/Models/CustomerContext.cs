using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public class CustomerContext : DbContext
    {
        // I used the same context I used prevouslty with user context to link it with the same connection string altough we could create seperate databases in one project
        public CustomerContext() : base("UserContext")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

         
    }
}