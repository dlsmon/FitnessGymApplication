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



            /*public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DBContext>();
             
                context.Database.EnsureCreated();                            

                //Exercice

                if (!context.Exercise.Any())
                {
                    context.Exercise.AddRange(new List<Exercise>()
                    {
                         new Exercise()
                        {
                            Name = "Body Attack",                           
                            Description = "Description"
                        }
                    }
                    );
                    context.SaveChanges();
                }                            

            }
        }*/





        }
    }
}
