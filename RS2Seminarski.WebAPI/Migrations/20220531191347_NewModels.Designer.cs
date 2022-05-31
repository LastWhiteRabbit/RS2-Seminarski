﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RS2Seminarski.WebAPI.Database;

#nullable disable

namespace RS2Seminarski.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220531191347_NewModels")]
    partial class NewModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ExerciseImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId");

                    b.HasIndex("LevelId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseExerciseType", b =>
                {
                    b.Property<int>("ExerciseExerciseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseExerciseTypeId"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseTypeId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseExerciseTypeId");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("ExerciseTypeId");

                    b.ToTable("ExerciseExerciseTypes");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseMuscle", b =>
                {
                    b.Property<int>("ExerciseMuscleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseMuscleId"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseMuscleId");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleId");

                    b.ToTable("ExerciseMuscles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseType", b =>
                {
                    b.Property<int>("ExerciseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseTypeId"), 1L, 1);

                    b.Property<string>("ExerciseTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseTypeId");

                    b.ToTable("ExerciseTypes");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Level", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LevelId"), 1L, 1);

                    b.Property<string>("LevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LevelId");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Muscle", b =>
                {
                    b.Property<int>("MuscleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MuscleId"), 1L, 1);

                    b.Property<string>("MuscleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MuscleId");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Routine", b =>
                {
                    b.Property<int>("RoutineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoutineId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("RoutineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoutineId");

                    b.ToTable("Routines");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.RoutineExercise", b =>
                {
                    b.Property<int>("RoutineExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoutineExerciseId"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("RoutineId")
                        .HasColumnType("int");

                    b.HasKey("RoutineExerciseId");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("RoutineId");

                    b.ToTable("RoutineExercises");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.RoutineUser", b =>
                {
                    b.Property<int>("RoutineUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoutineUserId"), 1L, 1);

                    b.Property<int>("RoutineId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoutineUserId");

                    b.HasIndex("RoutineId");

                    b.HasIndex("UserId");

                    b.ToTable("RoutineUsers");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"), 1L, 1);

                    b.Property<DateTime>("DateEdited")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Exercise", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseExerciseType", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Exercise", "Exercise")
                        .WithMany("ExerciseExerciseTypes")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RS2Seminarski.WebAPI.Database.ExerciseType", "ExerciseType")
                        .WithMany("ExerciseExerciseTypes")
                        .HasForeignKey("ExerciseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("ExerciseType");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseMuscle", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Exercise", "Exercise")
                        .WithMany("ExerciseMuscles")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RS2Seminarski.WebAPI.Database.Muscle", "Muscle")
                        .WithMany("ExerciseMuscles")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.RoutineExercise", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Exercise", "Exercise")
                        .WithMany("RoutineExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RS2Seminarski.WebAPI.Database.Routine", "Routine")
                        .WithMany("RoutineExercises")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Routine");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.RoutineUser", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Routine", "Routine")
                        .WithMany("RoutineUsers")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RS2Seminarski.WebAPI.Database.User", "User")
                        .WithMany("RoutineUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routine");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.UserRole", b =>
                {
                    b.HasOne("RS2Seminarski.WebAPI.Database.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RS2Seminarski.WebAPI.Database.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Exercise", b =>
                {
                    b.Navigation("ExerciseExerciseTypes");

                    b.Navigation("ExerciseMuscles");

                    b.Navigation("RoutineExercises");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.ExerciseType", b =>
                {
                    b.Navigation("ExerciseExerciseTypes");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Muscle", b =>
                {
                    b.Navigation("ExerciseMuscles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.Routine", b =>
                {
                    b.Navigation("RoutineExercises");

                    b.Navigation("RoutineUsers");
                });

            modelBuilder.Entity("RS2Seminarski.WebAPI.Database.User", b =>
                {
                    b.Navigation("RoutineUsers");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
