using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuliePro.Models;

namespace JuliePro.Data
{
    public  static class ModelBuilderDataGenerator
    {
        public static void GerenateData(this ModelBuilder builder)
        {
            #region Speciality
            builder.Entity<Speciality>().HasData(
            new Speciality() { Id = 1, Name = "Perte de poids" },
            new Speciality() { Id = 2, Name = "Course" },
            new Speciality() { Id = 3, Name = "Halthérophilie" },
            new Speciality() { Id = 4, Name = "Réhabilitation" });



            #endregion

            #region Trainer
            builder.Entity<Trainer>().HasData(
            new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" },
            new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" },
           new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" },
           new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" },
           new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" },
           new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" },
           new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

            #endregion

            #region Customer
            builder.Entity<Customer>().HasData(
                new Customer() { Id=1, FirstName = "Bianka", LastName = "Smith", Email = "Bianka.Smith@juliepro.ca", BirthDate = new DateTime(1998, 1, 9), TrainerId = 1, StartWeight = 180,   },
                new Customer() {  Id=2,FirstName = "Joe", LastName = "Espejo", Email = "Joe.Espejo@juliepro.ca", BirthDate = new DateTime(1990, 8, 9), TrainerId = 1, StartWeight = 160 },
                new Customer() { Id=3, FirstName = "Betty", LastName = "Thomas", Email = "Betty.Thomas@juliepro.ca", BirthDate = new DateTime(2002, 10, 12), TrainerId = 1, StartWeight = 190 }
                );

            #endregion

            #region Objective
            builder.Entity<Objective>().HasData(
             new Objective() { Name = "Belly", LostWeightKg = 5, AchievedDate = new DateTime(2023, 1, 9), DistanceKm = 5 },
             new Objective() { Name = "Fat", LostWeightKg = 10, DistanceKm = 10 },
             new Objective() { Name = "Muscle", LostWeightKg = 2, AchievedDate = new DateTime(2023, 5, 23), DistanceKm = 6 },
             new Objective() { Name = "Back Fat", LostWeightKg = 9, DistanceKm = 8 }
             );
             
             
             
             
             #endregion








        }


    }
}
