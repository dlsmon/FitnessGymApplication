using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplicationS.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime Datesub { get; set; }
   
       public ICollection<Formula> Formulas { get; set; }
    }
}
