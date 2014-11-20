using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")   
          {

          }

        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        //using fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // In order to link one to one relation ship using fluent API this is the code to link user with the profile using model builder
            modelBuilder.Entity<UserProfile>()
                .HasKey(e => e.userID);
            modelBuilder.Entity<UserProfile>()
                .Property(e => e.userID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<UserProfile>()
                .HasRequired(e => e.User)
                .WithRequiredDependent(s => s.UserProfile);

            base.OnModelCreating(modelBuilder);
        }
    }
}