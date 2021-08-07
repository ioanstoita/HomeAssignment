using System;
using System.Collections.Generic;
using System.Text;
using HA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rebate> Rebates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

                entity.Property(x => x.Name).IsRequired(false).HasMaxLength(255);
                entity.Property(x => x.Price).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x.RetailerName).IsRequired(true).HasMaxLength(320);
                entity.Property(x => x.StandardPrice).IsRequired(true).HasDefaultValue(false);
            });

            modelBuilder.Entity<Rebate>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

                entity.Property(x => x.RetailerName).IsRequired(true).HasMaxLength(320);
                entity.Property(x => x.CustomerName).IsRequired(true).HasMaxLength(320);

                entity.Property(x => x.RebateValue).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x.RebatePercent).IsRequired(true).HasDefaultValue(0);
            });
        }

        

    }
}
