using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace FitnessGymApplication.Models
{
    public class Session
    {
        public int Id { get; set; }
        

        public string Date { get; set; }
        //Maximum number of clients p
        [Display(Name = "Number of Participants : ")]
        [Range(1, 100, ErrorMessage = "La valeur doit être comprise entre 1 et 30")] 
        public string MaxParticipants { get; set; }

        public string IdTrainingProgram { get; set; }
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

    }
}
