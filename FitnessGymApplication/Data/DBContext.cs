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
        public DbSet<FitnessGymApplication.Models.Client> Client { get; set; } = default!;
        public DbSet<FitnessGymApplication.Models.Goal> Goal { get; set; } = default!;

    }
}
