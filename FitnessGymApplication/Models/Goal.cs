using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class Goal
    {        

        public int Id { get; set; }
        public int? Weight { get; set; }
        public int? Frequency { get; set; }
        public int? CaloriesBurnt { get; set; }
        public int IdClient { get; set; }


        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }
             
    }
}
