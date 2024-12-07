using System;
using Microsoft.EntityFrameworkCore;
using Cozy_House.models;
using System.Diagnostics;
using Cozy_House.models.Cozy_House.models;

namespace Cozy_House.DatabaseAdd
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Shelter> shelter { get; set; }
        public DbSet<Animal> animal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\WellDone\source\repos\Cozy-House\proj\Cozy_House\DatabaseAdd\Database\mydb.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.User_Email).IsUnique();
                entity.Property(e => e.User_name).IsRequired();
                entity.Property(e => e.User_Email).IsRequired();
            });
        }

        public void EnsureDatabaseCreated()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Помилка створення бази даних: {ex.Message}");
            }
        }
    }
}