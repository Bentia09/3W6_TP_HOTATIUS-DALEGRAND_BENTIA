<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using JuliePro.Models;
namespace JuliePro.Models
{
    public class Speciality
    {
        [MinLength(5)]
        [MaxLength(20)]
        string Name { get; set; }
=======
﻿namespace JuliePro.Models
{
    public class Speciality
    {
>>>>>>> TP1
    }
}
