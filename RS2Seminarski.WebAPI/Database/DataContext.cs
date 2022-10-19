using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.WebAPI.Database
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; } = null;
        public DbSet<ExerciseExerciseType> ExerciseExerciseTypes { get; set; } = null;
        public DbSet<ExerciseMuscle> ExerciseMuscles { get; set; } = null;
        public DbSet<ExerciseType> ExerciseTypes { get; set; } = null;
        public DbSet<Level> Levels { get; set; } = null;
        public DbSet<Muscle> Muscles { get; set; } = null;
        public DbSet<Role> Roles { get; set; } = null;
        public DbSet<Routine> Routines { get; set; } = null;
        public DbSet<RoutineExercise> RoutineExercises { get; set; } = null;
        public DbSet<RoutineUser> RoutineUsers { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;
        public DbSet<UserRole> UserRoles { get; set; } = null;
        public DbSet<Country> Countries { get; set; } = null;
        public DbSet<City> Cities { get; set; } = null;
        public DbSet<Plan> Plans { get; set; } = null;

        public DbSet<WeatherForecast> WeatherForecasts { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(e => e.UserRoleId);
            modelBuilder.Entity<User>().HasKey(e => e.UserId);
            modelBuilder.Entity<Role>().HasKey(e => e.RoleId);

            modelBuilder.Entity<ExerciseExerciseType>().HasKey(e => e.ExerciseExerciseTypeId);
            modelBuilder.Entity<Exercise>().HasKey(e => e.ExerciseId);
            modelBuilder.Entity<ExerciseType>().HasKey(e => e.ExerciseTypeId);
            modelBuilder.Entity<Level>().HasKey(e => e.LevelId);

            modelBuilder.Entity<ExerciseMuscle>().HasKey(e => e.ExerciseMuscleId);
            modelBuilder.Entity<Muscle>().HasKey(e => e.MuscleId);

            modelBuilder.Entity<Routine>().HasKey(e => e.RoutineId);
            modelBuilder.Entity<RoutineExercise>().HasKey(e => e.RoutineExerciseId);
            modelBuilder.Entity<RoutineUser>().HasKey(e => e.RoutineUserId);

            modelBuilder.Entity<Country>().HasKey(e => e.CountryId);
            modelBuilder.Entity<City>().HasKey(e => e.CityId);

            modelBuilder.Entity<Plan>().HasKey(e => e.PlanId);



            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
