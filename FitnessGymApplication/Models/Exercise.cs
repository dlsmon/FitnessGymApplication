using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        //Exercise Name
        [Required]
        [Display(Name = "Exercise Name")]
        [MaxLength(30), MinLength(3)]
        public string Name { get; set; }

        //Exercise Description
        [MaxLength(300)]
        public string? Description { get; set; }

        //Exercise Duration measured in minutes
        [Display(Name = "Duration (Minutes)")]
        public int? Duration { get; set; }

        //Calories measured in Kcal
        [Display(Name = "Calories (Kcal)")]
        public int? Calories { get; set; }

        public virtual ICollection<IndividualProgram>? IndividualPrograms { get; set; }
    }
}
