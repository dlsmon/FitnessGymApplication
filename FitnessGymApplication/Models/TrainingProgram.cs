namespace FitnessGymApplication.Models
 
{
    public class TrainingProgram
    {
        public enum eIntensity
        {
            Soft,
            Easy,
            Medium,
            Hard, 
            Extreme
        }

        public int Id { get; set; }
        public eIntensity Intensity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int Calories { get; set; }

    }
}
