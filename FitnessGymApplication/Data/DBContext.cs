using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitnessGymApplication.Models;

namespace FitnessGymApplication.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        public DbSet<FitnessGymApplication.Models.Exercise> Exercise { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.TrainingProgram> TrainingProgram { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.IndividualProgram> IndividualProgram { get; set; } = default!;

    }
}
