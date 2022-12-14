using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class FavoriteCoach
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdCoach { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        [ForeignKey("IdCoach")]
        public virtual Coach? Coach { get; set; }
        
    }
}
