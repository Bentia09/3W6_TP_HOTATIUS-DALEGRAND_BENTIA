using JuliePro.Models;
using Microsoft.EntityFrameworkCore;
using JuliePro.Data;
namespace JuliePro.Data
{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext>options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Générer des données de départ
            modelBuilder.GerenateData();
        }

        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Customer>Customers { get; set; }

    }
}
