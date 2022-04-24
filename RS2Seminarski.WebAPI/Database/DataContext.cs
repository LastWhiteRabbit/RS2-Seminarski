using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.WebAPI.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;
        public DbSet<Role> Roles { get; set; } = null;
        public DbSet<UserRole> UserRoles { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(e => e.UserRoleId);
            modelBuilder.Entity<User>().HasKey(e => e.UserId);
            modelBuilder.Entity<Role>().HasKey(e => e.RoleId);
        }
    }
}
