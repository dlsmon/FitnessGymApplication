using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class FavoriteExercice
    {
        public int Id { get; set; }      
        public int IdClient { get; set; }
        public int IdExercice { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        [ForeignKey("IdExercise")]
        public virtual Exercise? Exercise { get; set; }
    }
}
