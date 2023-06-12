using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JuliePro.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace JuliePro.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [MinLength(4)]
        [MaxLength(25)]
        [Key]
        public string FirstName { get; set; }

        [MinLength(4)]
        [MaxLength(25)]
        public string LastName { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public DateTime BirthDate { get; set; }
        [Range(100, 400)]
        public double StartWeight { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ValidateNever]
        public virtual Objective? Objective { get; set; }
        [ValidateNever]
        public virtual Trainer? Trainer { get; set; }


    }
}
