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
            
            
          
           
        }


    }
}
