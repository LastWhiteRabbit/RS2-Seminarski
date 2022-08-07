using Microsoft.EntityFrameworkCore;
using RS2Seminarski.WebAPI.Helpers;

namespace RS2Seminarski.WebAPI.Database
{
    public partial class DataContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 1, Name = "Administrator", });
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 2, Name = "Trainer", });

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Name = "Test",
                Surname = "Test",
                Email = "test@fit.ba",
                UserName = "test",
                PasswordHash = "7p3l25Cnbg+2QxoQRElFJjIqHgA=",
                PaswordSalt = "H4pOSYtdeJgGsU/6HRTxqw==",
            });

            //u:admin p:admin
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                Name = "Administrator",
                Surname = "Administrator",
                Email = "admin@fit.ba",
                UserName = "admin",
                PasswordHash = "JfJzsL3ngGWki+Dn67C+8WLy73I=",
                PaswordSalt = "7TUJfmgkkDvcY3PB/M4fhg==",
            });

            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 1, UserId = 1, RoleId = 1, DateEdited = DateTime.Today });
            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 2, UserId = 2, RoleId = 1, DateEdited = DateTime.Today });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 1, ExerciseTypeName = "Cardio" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 2, ExerciseTypeName = "Olympic Weightlifting" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 3, ExerciseTypeName = "Plyometrics" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 4, ExerciseTypeName = "Powerlifting" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 5, ExerciseTypeName = "Strength" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 6, ExerciseTypeName = "Stretching" });
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType() { ExerciseTypeId = 7, ExerciseTypeName = "Strongman" });

            modelBuilder.Entity<Level>().HasData(new Level() { LevelId = 1, LevelName = "Beginner" });
            modelBuilder.Entity<Level>().HasData(new Level() { LevelId = 2, LevelName = "Intermediate" });
            modelBuilder.Entity<Level>().HasData(new Level() { LevelId = 3, LevelName = "Expert" });

            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 1, MuscleName = "Chest" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 2, MuscleName = "Forearms" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 3, MuscleName = "Lats" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 4, MuscleName = "Middle Back" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 5, MuscleName = "Lower Back" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 6, MuscleName = "Neck" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 7, MuscleName = "Quadriceps" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 8, MuscleName = "Hamstrings" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 9, MuscleName = "Calves" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 10, MuscleName = "Triceps" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 11, MuscleName = "Traps" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 12, MuscleName = "Shoulders" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 13, MuscleName = "Abdominals" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 14, MuscleName = "Glutes" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 15, MuscleName = "Biceps" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 16, MuscleName = "Adductors" });
            modelBuilder.Entity<Muscle>().HasData(new Muscle() { MuscleId = 17, MuscleName = "Abductors" });


            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 1, ExerciseName = "Bench press", LevelId = 1, Instruction = "Lie back on a flat bench with feet firm on the floor. Using a wide, pronated (palms forward) grip that is around 3 inches away from shoulder width (for each hand), lift the bar from the rack and hold it straight over you with your arms locked. The bar will be perpendicular to the torso and the floor. This will be your starting position. As you breathe in, come down slowly until you feel the bar on your middle chest. After a second pause, bring the bar back to the starting position as you breathe out and push the bar using your chest muscles. Lock your arms and squeeze your chest in the contracted position, hold for a second and then start coming down slowly again. Tip: It should take at least twice as long to go down than to come up. Repeat the movement for the prescribed amount of repetitions.", About = "The wide-grip bench press is a compound exercise targeting the chest and, to a lesser extent, the triceps. The main difference between this exercise and the standard bench press is that the hands are placed farther apart on the bar. Many lifters find they can handle more weight going wide than with narrower grips, although it's also worth noting that plenty of banged-up lifters have said benching with a wide grip may also have contributed to their shoulder injuries and pain. The wide-grip bench is often used as a chest-building movement in chest or upper-body workouts, or as an accessory movement for the traditional bench press.", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/benchPress.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 2, ExerciseName = "Pullups", LevelId = 3, Instruction = "Grab the pull-up bar with the palms facing forward using the prescribed grip.As you have both arms extended in front of you holding the bar at the chosen grip width, bring your torso back around 30 degrees or so while creating a curvature on your lower back and sticking your chest out. This is your starting position.", About = "The pull-up is a multi-joint bodyweight exercise that builds strength and muscle in the upper back, biceps, and core. It is often used as a measurement tool in military or tactical fitness tests, and is an excellent gauge of “relative strength” which is strength in relation to bodyweight. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/pullUps.jpg") });

            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 1, ExerciseId = 1, ExerciseTypeId = 4 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 2, ExerciseId = 2, ExerciseTypeId = 5 });

            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 1, ExerciseId = 1, MuscleId = 1 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 2, ExerciseId = 2, MuscleId = 3 });

            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 1, RoutineName = "PPL", Description = " Push-Pull-Legs", Rating = 0  });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 1, RoutineId = 1, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 2, RoutineId = 1, ExerciseId = 2 });

            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 1, RoutineId = 1, UserId = 1});

        }
    }
}
