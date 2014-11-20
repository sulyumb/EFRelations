using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public class StoreContext : DbContext
    {
        //public StoreContext() : base("UserContext")
        //{
        //}
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Store> Stores { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
           
        //    //fluient API
        //    modelBuilder.Entity<Store>().HasMany<Product>(s => s.Products).WithMany(c => c.Stores).Map(c =>
        //    {
        //        c.MapLeftKey("ProductID");
        //        c.MapRightKey("StoreID");
        //        c.ToTable("StoreAndProduct");
        //    });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}