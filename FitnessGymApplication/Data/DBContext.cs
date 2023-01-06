using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitnessGymApplication.Models;  
using FitnessGymApplication.Data.Seeding;

namespace FitnessGymApplication.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
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

        public DbSet<FitnessGymApplication.Models.Client> Client { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Goal> Goal { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Location> Location { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Formula> Formula { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Coach> Coach { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Speciality> Speciality { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Machine> Machine { get; set; } = default!;


    }
}
