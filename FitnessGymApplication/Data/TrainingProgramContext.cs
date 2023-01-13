using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitnessGymApplication.Models;  
using FitnessGymApplication.Data.Seeding;

namespace FitnessGymApplication.Data
{
    public class TrainingProgramContext : DbContext
    {
        public TrainingProgramContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }

        //Seeding Database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppDBContextSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FitnessGymApplication.Models.Exercise> Exercise { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.TrainingProgram> TrainingProgram { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.IndividualProgram> IndividualProgram { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Session> Session { get; set; } = default!;

    }
}
