using System.ComponentModel.DataAnnotations.Schema;

namespace GYM_FITNESS.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime Datesub { get; set; }
   
       public ICollection<Formula> Formulas { get; set; }
    }
}
