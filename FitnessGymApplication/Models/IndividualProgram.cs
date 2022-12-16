using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class IndividualProgram
    {
        [Key]
        public int Id { get; set; }
        //Training program as a collective will have
        public int IdTrainingProgram { get; set; }
        public int IdExercise { get; set; }

        //Foreign KEYS
        [ForeignKey("IdTrainingProgram")]
        public virtual TrainingProgram? TrainingProgram { get; set; }

        [ForeignKey("IdExercise")]
        public virtual Exercise? Exercise { get; set; }
    }
}
