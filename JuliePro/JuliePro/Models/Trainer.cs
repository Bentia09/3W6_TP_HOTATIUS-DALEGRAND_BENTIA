﻿using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Trainer
    {
        [MinLength(4)]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MinLength(4)]
        [MaxLength(25)]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(40)]
        [DataType(DataType.ImageUrl)]
        public string? Photo { get; set; }
        public int Id { get; set; }
        public int SpecialityId { get; set; }   
        public virtual Speciality? Speciality { get; set; }



    }
}
