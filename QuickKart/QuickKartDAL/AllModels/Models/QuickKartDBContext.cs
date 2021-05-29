using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace QuickKartDAL.AllModels.Models
{
    public class QuickKartDBContext : DbContext
    {
        public QuickKartDBContext()
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connstr = config.GetConnectionString("QuickKartDBConnectionStrings");
            if(! optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(connstr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Used to make Role Id column as primary key using fluent API
            modelBuilder.Entity<Roles>
                (
                entity =>
                {
                    entity.HasKey(e => e.RoleId);
                    entity.Property(e => e.RoleId).ValueGeneratedOnAdd();

                    entity.Property(e => e.RoleName).IsRequired();
                }
                );

            modelBuilder.Entity<Users>
                (
                entity =>
                {
                    entity.Property(e => e.EmailId).HasMaxLength(100);

                    entity.Property(e => e.Gender).HasMaxLength(1).IsRequired();

                    entity.Property(e => e.DateOfBirth).HasColumnType("Date").HasDefaultValue(DateTime.Now);
                }
                );
        }
    }
}
