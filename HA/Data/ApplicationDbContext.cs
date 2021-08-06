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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

                entity.Property(x => x.Name).IsRequired(false).HasMaxLength(255);
                entity.Property(x => x.Price).IsRequired(true).HasDefaultValue(0);
            });
        }
    }
}
