using System;
using Microsoft.EntityFrameworkCore;
using Cozy_House.models;
using System.Diagnostics;
using Cozy_House.DatabaseAdd;

namespace Cozy_House.DatabaseAdd
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Animal> animals { get; set; }

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
                entity.HasKey(e => e.User_id);
                entity.Property(e => e.User_id)
                      .ValueGeneratedOnAdd();

                entity.HasIndex(e => e.User_Email).IsUnique();
                entity.Property(e => e.User_name).IsRequired();
                entity.Property(e => e.User_Email).IsRequired();
            });
        }

        public void DiagnoseUsers()
        {
            using (var context = new DatabaseContext())
            {
                var users = context.user.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine($"User ID: {user.User_id}, Name: {user.User_name}, Email: {user.User_Email}");
                }
            }
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