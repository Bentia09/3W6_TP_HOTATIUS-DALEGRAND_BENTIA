<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using JuliePro.Models.Data;

namespace JuliePro.Models.Data
{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        public DbSet<Speciality> Specialities { get; set; }



=======
﻿namespace JuliePro.Models.Data
{
    public class JulieProDbContext
    {
>>>>>>> TP1
    }
}
