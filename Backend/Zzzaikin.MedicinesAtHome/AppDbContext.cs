using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;
using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome
{
    public class AppDbContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<MedicinesInUsers> MedicinesInUsers { get; set; }

        public AppDbContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            InitSupervisorUser(builder);
        }

        private void InitSupervisorUser(ModelBuilder builder) 
        {
            var supervisorId = Guid.NewGuid();

            builder.Entity<User>()
                .HasData(
                    new User 
                    {
                        Id = supervisorId,
                        Name = "Supervisor",
                        CreatedOn = DateTime.Now,
                        CreatedBy = supervisorId,
                        Password = BC.HashPassword("Supervisor"),
                    });
        }
    }
}