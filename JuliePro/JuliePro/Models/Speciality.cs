﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Speciality
    {
        [MinLength(5)]
        [MaxLength(20)]
       public string Name { get; set; }
        public int? Id { get; set; }
       
    }
}
