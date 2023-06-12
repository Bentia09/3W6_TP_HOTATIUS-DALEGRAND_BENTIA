﻿// <auto-generated />
using System;
using JuliePro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuliePro.Migrations
{
    [DbContext(typeof(JulieProDbContext))]
    [Migration("20230612152843_Creation_Seed_Customer_Class_Customer_Class_Objective")]
    partial class Creation_Seed_Customer_Class_Customer_Class_Objective
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ObjectiveName")
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("StartWeight")
                        .HasColumnType("float");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveName");

                    b.HasIndex("TrainerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1998, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Bianka.Smith@juliepro.ca",
                            FirstName = "Bianka",
                            LastName = "Smith",
                            StartWeight = 180.0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Joe.Espejo@juliepro.ca",
                            FirstName = "Joe",
                            LastName = "Espejo",
                            StartWeight = 160.0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Betty.Thomas@juliepro.ca",
                            FirstName = "Betty",
                            LastName = "Thomas",
                            StartWeight = 190.0,
                            TrainerId = 1
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Objective", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("AchievedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DistanceKm")
                        .HasColumnType("float");

                    b.Property<double>("LostWeightKg")
                        .HasColumnType("float");

                    b.HasKey("Name");

                    b.ToTable("Objective");
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Perte de poids"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Course"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Halthérophilie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Réhabilitation"
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Photo")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId")
                        .IsUnique();

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Chrystal.lapierre@juliepro.ca",
                            FirstName = "Chrystal",
                            LastName = "Lapierre",
                            Photo = "Chrystal.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "Felix.trudeau@juliePro.ca",
                            FirstName = "Félix",
                            LastName = "Trudeau",
                            Photo = "Felix.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "Frank.StJohn@juliepro.ca",
                            FirstName = "François",
                            LastName = "Saint-John",
                            Photo = "Francois.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "JC.Bastien@juliepro.ca",
                            FirstName = "Jean-Claude",
                            LastName = "Bastien",
                            Photo = "JeanClaude.png",
                            SpecialityId = 4
                        },
                        new
                        {
                            Id = 5,
                            Email = "JinLee.godette@juliepro.ca",
                            FirstName = "Jin Lee",
                            LastName = "Godette",
                            Photo = "Jin Lee.png",
                            SpecialityId = 3
                        },
                        new
                        {
                            Id = 6,
                            Email = "Karine.Lachance@juliepro.ca",
                            FirstName = "Karine",
                            LastName = "Lachance",
                            Photo = "Karine.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 7,
                            Email = "Ramone.Esteban@juliepro.ca",
                            FirstName = "Ramone",
                            LastName = "Esteban",
                            Photo = "Ramone.png",
                            SpecialityId = 3
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.HasOne("JuliePro.Models.Objective", "Objective")
                        .WithMany()
                        .HasForeignKey("ObjectiveName");

                    b.HasOne("JuliePro.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.HasOne("JuliePro.Models.Speciality", "Speciality")
                        .WithOne("Trainer")
                        .HasForeignKey("JuliePro.Models.Trainer", "SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Navigation("Trainer");
                });
#pragma warning restore 612, 618
        }
    }
}
