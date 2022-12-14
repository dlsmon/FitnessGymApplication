namespace FitnessGymApplication.Models
{
    public class Exercise
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Duration measured in minutes
        public int Duration { get; set; }   
        //Calories measured in Kcal
        public int Calories { get; set; }   

       
    }
}
