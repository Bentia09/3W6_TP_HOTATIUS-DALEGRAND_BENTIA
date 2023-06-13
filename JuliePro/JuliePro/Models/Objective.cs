using JuliePro.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace JuliePro.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(15)]
        public string Name { get; set; }
        [Range(2,10)]
        public double LostWeightKg { get; set; }
        [Range(2,45)]
        public double DistanceKm { get; set; }
        public DateTime AchievedDate { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
