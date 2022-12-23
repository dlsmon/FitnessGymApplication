using FitnessGymApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessGymApplication.Data.Seeding
{
    public class AppDBContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Exercise 

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 1,
                    Name = "Crunch",
                    Description = "Description",
                    Duration = 15,
                    Calories = 100
                });

            //Individual Program               

            //Training program               

            //Formula

            //Coach 

            //Speciality

            //Location

            //Machine

            //Product
        }
    }
}
