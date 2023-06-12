using JuliePro.Models;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Objective
    {
        [MinLength(5)]
        [MaxLength(15)]
        [Key]
        public string Name { get; set; }
        [Range(2,10)]
        public double LostWeightKg { get; set; }
        [Range(2,45)]
        public double DistanceKm { get; set; }
        public DateTime AchievedDate { get; set; }
    }
}
