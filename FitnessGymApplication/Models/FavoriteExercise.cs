using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class FavoriteExercise
    {
        [Key]
        public int Id { get; set; }      
        public int IdClient { get; set; }
        public int IdExercise { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        [ForeignKey("IdExercise")]
        public virtual Exercise? Exercise { get; set; }
    }
}
