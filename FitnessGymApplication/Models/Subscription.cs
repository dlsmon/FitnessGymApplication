using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "Inconnue")]
        [Display(Name = "Entry date")]
        public DateTime Entrydate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "Inconnue")]
        [Display(Name = "Date to leave")]
        public DateTime Sortdate { get; set; }
        [Display(Name = "Client")]
        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        [Display(Name = "Formula")]
        public int IdFormula { get; set; }
        [ForeignKey("IdFormula")]
        public virtual Formula? Formula { get; set; }
    }
}
