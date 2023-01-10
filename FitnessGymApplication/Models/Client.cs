using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Client
    {

        public enum eSex
        {
            Women,
            Men,
            Other
        }

        public enum eNewsletter
        {
            Yes,
            No
        }

        public enum eFreetrial
        {
            Yes,
            No
        }

        [Key]
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public eSex Sex { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", NullDisplayText ="Inconnue")]
        [Display(Name = "Birth Date")] 
        public DateTime Birthdate { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int Phonenumber { get; set; }

        public string? Adresse { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "This Email is not valid.")]
        public string Email { get; set; }

        [DataType(DataType.Password)] //Password field will be non readable
        [MaxLength(15, ErrorMessage = "Password must be between 8 and 15 characters"), MinLength(8)]
        public string Password { get; set; }
        public string? Diseases { get; set; }
        public string? Hobbies { get; set; }

        //Newsletter is boolean : if the client want a newsletter (1); if not (0)
        public eNewsletter Newsletter { get; set; }

        //FreeTrial is boolean : if the client want a FreeTrial (1); if not (0)
        public eFreetrial Freetrial { get; set; }

        public virtual ICollection<Goal>? Goal { get; set; }
        public virtual ICollection<FavoriteCoach>? FavoriteCoach { get; set; }
        public virtual ICollection<FavoriteTrainingProgram>? TrainingProgram { get; set; }
        public virtual ICollection<FavoriteExercise>? FavoriteExercice { get; set; }
        public virtual ICollection<FavoriteLocation>? FavoriteLocation { get; set; }



    }
}
