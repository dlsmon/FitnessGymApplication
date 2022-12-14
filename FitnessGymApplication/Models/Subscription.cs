using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime Datesub { get; set; }
        [ForeignKey("IDFormula")]
       public ICollection<Formula> Formulas { get; set; }
    }
}
