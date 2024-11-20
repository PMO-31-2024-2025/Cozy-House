using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cozy_House.models;
using Microsoft.EntityFrameworkCore;

namespace Cozy_House.DatabaseAdd
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Shelter> shelters { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Animal> animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\WellDone\source\repos\Cozy-House\proj\Cozy_House\DatabaseAdd\Database\mydb.db;");
        }
    }
}
