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
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 3, ExerciseName = "Pushups", LevelId = 1, Instruction = "Lie on the floor face down and place your hands about 36 inches apart while holding your torso up at arms length. Next, lower yourself downward until your chest almost touches the floor as you inhale.", About = "The push-up is a popular bodyweight exercise that is commonly used in military and tactical physical fitness tests. It’s a classic movement to build upper-body muscle and strength, emphasizing the chest, triceps, and shoulders, but also working the upper back and core. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/pushups.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 4, ExerciseName = "Elbow plank", LevelId = 2, Instruction = "Get into a prone position on the floor, supporting your weight on your toes and your forearms.Your arms are bent and directly below the shoulder. Keep your body straight at all times, and hold this position as long as possible.To increase difficulty, an arm or leg can be raised.", About = "The elbow plank is a popular isometric abdominal exercise. It is common in all types of exercise programs, as well as in group fitness and yoga classes. It targets the muscles of the core, the deep core or transversus abdominis in particular. It is also often prescribed for time to help back pain or to teach proper bracing. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/elbowPlank.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 5, ExerciseName = "Military press", LevelId = 1, Instruction = "Start by placing a barbell that is about chest high on a squat rack. Once you have selected the weights, grab the barbell using a pronated (palms facing forward) grip. Make sure to grip the bar wider than shoulder width apart from each other. Slightly bend the knees and place the barbell on your collar bone.Lift the barbell up keeping it lying on your chest.Take a step back and position your feet shoulder width apart from each other.", About = "The military press is a compound movement used to build size and strength in the shoulders. It was once contested as a fourth powerlift, but is rarely competed anymore. However, being able to press a significant weight overhead remains a popular marker of upper-body strength. The military press can be trained as a strength lift or in traditional muscle-building rep ranges as part of full-body, shoulder-focused, or upper-body training. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/militaryPress.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 6, ExerciseName = "Triceps dip", LevelId = 2, Instruction = "To get into the starting position, hold your body at arm's length with your arms nearly locked above the bars. Now, inhale and slowly lower yourself downward.Your torso should remain upright and your elbows should stay close to your body.This helps to better focus on tricep involvement.Lower yourself until there is a 90 degree angle formed between the upper arm and forearm.", About = "The triceps dip is a bodyweight exercise performed on parallel bars or on a pull-up and dip station. It targets the triceps first, but also stretches and strengthens the chest and shoulders. Dips with a triceps focus are usually performed with an upright torso, the knees bent and crossed, and the arms close to the body. Dips can be performed for low reps for strength or higher reps for muscle growth.", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/tricepDips.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 7, ExerciseName = "Standing Calf Raises", LevelId = 1, Instruction = "Adjust the padded lever of the calf raise machine to fit your height. Place your shoulders under the pads provided and position your toes facing forward(or using any of the two other positions described at the beginning of the chapter). The balls of your feet should be secured on top of the calf block with the heels extending off it. Push the lever up by extending your hips and knees until your torso is standing erect. The knees should be kept with a slight bend; never locked. Toes should be facing forward, outwards or inwards as described at the beginning of the chapter. This will be your starting position.", About = "The standing calf raise is a popular movement to target the calf muscles of the lower leg, and in particular the gastrocnemius muscles. When unweighted, it is usually performed for high reps or for time. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/calfRises.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 8, ExerciseName = "Barbell Deadlift", LevelId = 2, Instruction = "Approach the bar so that it is centered over your feet. Your feet should be about hip-width apart. Bend at the hip to grip the bar at shoulder-width allowing your shoulder blades to protract. Typically, you would use an alternating grip. With your feet and your grip set, take a big breath and then lower your hips and flex the knees until your shins contact the bar.Look forward with your head.Keep your chest up and your back arched, and begin driving through the heels to move the weight upward.", About = "The barbell deadlift is a compound exercise used to develop overall strength and size in the posterior chain. It is a competition lift in the sport of powerlifting, but is also considered a classic benchmark of overall strength. When performed with the hands outside the knees, it is often called a conventional deadlift. When the feet are wide and the hands are inside the knees, it is a sumo deadlift. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/deadlift.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 9, ExerciseName = "Barbell Full Squat", LevelId = 1, Instruction = "This exercise is best performed inside a squat rack for safety purposes. To begin, first set the bar on a rack just above shoulder level. Once the correct height is chosen and the bar is loaded, step under the bar and place the back of your shoulders (slightly below the neck) across it. Hold on to the bar using both arms at each side and lift it off the rack by first pushing with your legs and at the same time straightening your torso.", About = "The barbell back squat is a popular compound movement that emphasizes building the lower-body muscle groups and overall strength. It's the classic way to start a leg day, and is a worthy centerpiece to a lower-body training program. The squat is a competitive lift in the sport of powerlifting, but is also a classic measurement of lower-body strength. With the barbell racked on the traps or upper back, the emphasis is placed on the posterior chain but the entire body gets worked. The back squat can be trained in everything from heavy singles to sets of 20 reps or higher. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/squat.jpg") });
            modelBuilder.Entity<Exercise>().HasData(new Exercise() { ExerciseId = 10, ExerciseName = "Jumping rope", LevelId = 2, Instruction = " Hold an end of the rope in each hand.Position the rope behind you on the ground.Raise your arms up and turn the rope over your head bringing it down in front of you.When it reaches the ground, jump over it.Find a good turning pace that can be maintained.Different speeds and techniques can be used to introduce variation. Rope jumping is exciting,challenges your coordination, requires a lot of energy.A 150 lb person will burn about 350 calories jumping rope for 30 minutes, compared to over 450 calories running. ", About = "Jumping rope is a classic conditioning exercise that is popular with everyone from children to boxers to CrossFit athletes. It targets many different muscles, including the calves, glutes, shoulders, and upper back, and is great for everything from fat loss to improving overall athletic performance. ", ExerciseImage = FileHelper.ReadFile("./SeedFiles/Images/Exercises/jumpingRope.jpg") });

            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 1, ExerciseId = 1, ExerciseTypeId = 4 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 2, ExerciseId = 2, ExerciseTypeId = 5 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 3, ExerciseId = 3, ExerciseTypeId = 5 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 4, ExerciseId = 4, ExerciseTypeId = 5 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 5, ExerciseId = 5, ExerciseTypeId = 2 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 6, ExerciseId = 6, ExerciseTypeId = 5 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 7, ExerciseId = 7, ExerciseTypeId = 6 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 8, ExerciseId = 8, ExerciseTypeId = 4 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 9, ExerciseId = 9, ExerciseTypeId = 4 });
            modelBuilder.Entity<ExerciseExerciseType>().HasData(new ExerciseExerciseType() { ExerciseExerciseTypeId = 10, ExerciseId =10, ExerciseTypeId = 1 });

            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 1, ExerciseId = 1, MuscleId = 1 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 2, ExerciseId = 1, MuscleId = 10 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 3, ExerciseId = 2, MuscleId = 3 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 4, ExerciseId = 2, MuscleId = 2 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 5, ExerciseId = 2, MuscleId = 4 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 6, ExerciseId = 2, MuscleId = 5 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 7, ExerciseId = 3, MuscleId = 1 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 8, ExerciseId = 3, MuscleId = 10 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 9, ExerciseId = 4, MuscleId = 13 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 10, ExerciseId = 5, MuscleId = 12 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 11, ExerciseId = 5, MuscleId = 13 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 12, ExerciseId = 6, MuscleId = 10 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 13, ExerciseId = 6, MuscleId = 1 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 14, ExerciseId = 7, MuscleId = 9 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 15, ExerciseId = 8, MuscleId = 8 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 16, ExerciseId = 8, MuscleId = 11 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 17, ExerciseId = 8, MuscleId = 13 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 18, ExerciseId = 8, MuscleId = 14 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 19, ExerciseId = 8, MuscleId = 16 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 20, ExerciseId = 8, MuscleId = 17 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 21, ExerciseId = 8, MuscleId = 5 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 22, ExerciseId = 8, MuscleId = 7 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 23, ExerciseId = 9, MuscleId = 7 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 24, ExerciseId = 9, MuscleId = 8 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 25, ExerciseId = 9, MuscleId = 13 });
            modelBuilder.Entity<ExerciseMuscle>().HasData(new ExerciseMuscle() { ExerciseMuscleId = 26, ExerciseId = 10, MuscleId = 9 });

            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 1, RoutineName = "PPL", Description = "Push-Pull-Legs", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 2, RoutineName = "PHAT", Description = "Power Hypertrophy Adaptive Training", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 3, RoutineName = "5/3/1 for Beginners", Description = "5/3/1 is one of the most popular strength training programs ever", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 4, RoutineName = "Boring But Big: 5/3/1 BBB", Description = "Boring But Big (BBB) is a variation of Jim Wendler’s 5/3/1 template that focuses on high volume accessory work to induce hypertrophy after the main “5/3/1” work is finished.", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 5, RoutineName = "Calgary Barbell 16 Week ", Description = "Written by Calgary Barbell, the 16 week and 8 week programs are designed to improve the squat, bench press, and deadlift of the athlete in preparation for a powerlifting meet. ", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 6, RoutineName = "Jonnie Candito 6 Week Powerlifting Program", Description = "Jonnie Candito’s 6 week program is a powerlifting peaking program. It consists of several short training blocks dedicated to muscular conditioning, hypertrophy, strength, linear weight increases, acclimation to heavy weights, intensity, and testing. ", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 7, RoutineName = "Sheiko Program ", Description = "Sheiko programs are powerlifting programs attributed to Boris Sheiko, renowned Russian powerlifting coach. His programs are known for their high volume and great results for those who can complete them.", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 8, RoutineName = "nSuns 5/3/1 ", Description = "nSuns 5/3/1 is a linear progression powerlifting program that was inspired by Jim Wendler’s 5/3/1 strength program. It progresses on a weekly basis, making it well suited for late stage novice and early intermediate lifters. ", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 9, RoutineName = "3 Day Chinese Olympic Weightlifting Program", Description = "This Chinese Olympic weightlifting program is a 3 day, 4 week peaking block designed for competition preparation. It was originally designed for school-aged lifters that were only able to train 3 days per week.", Rating = 0  });
            modelBuilder.Entity<Routine>().HasData(new Routine() { RoutineId = 10, RoutineName = "Glenn Pendlay Beginner Olympic Weightlifting Program ", Description = "This is an Olympic weightlifting program outline for beginners. It was originally published by Glenn Pendlay in 2010 on his blog, which is now defunct. The article and program template have been reproduced here for archival purposes.", Rating = 0  });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 1, RoutineId = 1, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 2, RoutineId = 1, ExerciseId = 2 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 3, RoutineId = 1, ExerciseId = 3 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 4, RoutineId = 1, ExerciseId = 4 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 5, RoutineId = 2, ExerciseId = 5 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 6, RoutineId = 2, ExerciseId = 6 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 7, RoutineId = 2, ExerciseId = 7 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 8, RoutineId = 2, ExerciseId = 8 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 9, RoutineId = 3, ExerciseId = 10 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 10, RoutineId = 3, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 11, RoutineId = 3, ExerciseId = 3 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 12, RoutineId = 3, ExerciseId = 5 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 13, RoutineId = 4, ExerciseId = 7 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 14, RoutineId = 4, ExerciseId = 9 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 15, RoutineId = 4, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 16, RoutineId = 4, ExerciseId = 3 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 17, RoutineId = 5, ExerciseId = 4 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 18, RoutineId = 5, ExerciseId = 6 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 19, RoutineId = 5, ExerciseId = 8 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 20, RoutineId = 5, ExerciseId = 10 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 21, RoutineId = 6, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 22, RoutineId = 6, ExerciseId = 4 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 23, RoutineId = 6, ExerciseId = 7 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 24, RoutineId = 6, ExerciseId = 9 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 25, RoutineId = 7, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 26, RoutineId = 7, ExerciseId = 3 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 27, RoutineId = 7, ExerciseId = 6 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 28, RoutineId = 7, ExerciseId = 9 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 29, RoutineId = 8, ExerciseId = 10 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 30, RoutineId = 8, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 31, RoutineId = 8, ExerciseId = 2 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 32, RoutineId = 8, ExerciseId = 3 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 33, RoutineId = 9, ExerciseId = 4 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 34, RoutineId = 9, ExerciseId = 2 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 35, RoutineId = 9, ExerciseId = 6 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 36, RoutineId = 9, ExerciseId = 7 });

            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 37, RoutineId = 10, ExerciseId = 1 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 38, RoutineId = 10, ExerciseId = 6 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 39, RoutineId = 10, ExerciseId = 7 });
            modelBuilder.Entity<RoutineExercise>().HasData(new RoutineExercise() { RoutineExerciseId = 40, RoutineId = 10, ExerciseId = 8 });


            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 1, RoutineId = 1, UserId = 1});
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 2, RoutineId = 2, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 3, RoutineId = 3, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 4, RoutineId = 4, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 5, RoutineId = 5, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 6, RoutineId = 6, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 7, RoutineId = 7, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 8, RoutineId = 8, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 9, RoutineId = 9, UserId = 2 });
            modelBuilder.Entity<RoutineUser>().HasData(new RoutineUser() { RoutineUserId = 10, RoutineId = 10, UserId = 2 });

        }
    }
}
