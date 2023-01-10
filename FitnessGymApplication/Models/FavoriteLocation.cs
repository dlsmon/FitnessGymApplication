using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class FavoriteLocation
    {
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdLocation { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }
        
        [ForeignKey("IdLocation")]
        public virtual Location? Location { get; set; }
        
    }
}
