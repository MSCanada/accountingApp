using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI.Models.DBContextClasses
{
    public class DBContext :DbContext
    {
        public DBContext() : base("name=api") { }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserLogs> UserLogs { get; set; }

        public DbSet<Addresses> Addresses { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("UserRecords");
            modelBuilder.Entity<Users>().Property(p => p.UserId).IsRequired();
            modelBuilder.Entity<Users>().Property(p => p.Username).IsRequired();
            modelBuilder.Entity<Users>().Property(p => p.Password).IsRequired();
            modelBuilder.Entity<Users>().HasKey(p => p.UserId);
            modelBuilder.Entity<Users>().Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UserLogs>().Property(p => p.DeviceId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserLogs>().Property(p => p.DeviceId).IsRequired();
            modelBuilder.Entity<UserLogs>().HasKey(p => p.DeviceId);
            modelBuilder.Entity<Users>().HasMany<UserLogs>(p => p.userlogs).WithRequired(p => p.user).HasForeignKey(s=>s.UserId);

            modelBuilder.Entity<Addresses>().Property(p => p.AddressId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Addresses>().Property(p => p.AddressId).IsRequired();
            modelBuilder.Entity<Addresses>().HasKey(p => p.AddressId);
            modelBuilder.Entity<Users>().HasOptional(p => p.addresses);

            modelBuilder.Entity<Roles>().HasKey(p => p.RolesId) ;
            modelBuilder.Entity<Roles>().Property(p => p.RolesId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UserRoles>().Property(p => p.UserRolesId).IsRequired();
            modelBuilder.Entity<UserRoles>().HasKey(p=>p.UserRolesId);
            modelBuilder.Entity<UserRoles>().Property(p => p.UserRolesId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
        }

    }

  

}