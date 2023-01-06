using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace FitnessGymApplication.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", NullDisplayText = "Inconnue")]
        [Display(Name = "Entry date")]
        public DateTime Entrydate { get; set; }

        //Maximum number of clients p
        [Display(Name = "Number of Participants : ")]
         
        public string MaxParticipants { get; set; }

        public int IdTrainingProgram { get; set; }
        public int IdCoach { get; set; }
        public int IdLocation { get; set; }
        public int IdFormula { get; set; }

        //Foreign Key
        [ForeignKey("IdTrainingProgram")]
        public virtual TrainingProgram? TrainingProgram { get; set; }

        [ForeignKey("IdCoach")]
        public virtual Coach? Coach { get; set; }

        [ForeignKey("IdLocation")]
        public virtual Location? Location { get; set; }

        [ForeignKey("IdFormula")]
        public virtual Formula? Formula { get; set; }


        public virtual ICollection<Reservation>? Reservations { get; set; }

    }
}
