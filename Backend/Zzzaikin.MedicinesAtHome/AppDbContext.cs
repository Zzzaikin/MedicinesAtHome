using Microsoft.EntityFrameworkCore;
using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome
{
    public class AppDbContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<User> Users { get; set; }

        public AppDbContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            SetDemoData(builder);
        }

        private void SetDemoData(ModelBuilder builder) 
        {
            
        }
    }
}