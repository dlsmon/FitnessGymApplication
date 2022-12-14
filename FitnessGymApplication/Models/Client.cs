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

        public int Id { get; set; }
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
        public int Phonenumber { get; set; }

        public string? Adresse { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "This Email is not valid.")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Diseases { get; set; }
        public string? Hobbies { get; set; }

        //Newsletter is boolean : if the client want a newsletter (1); if not (0)
        public int Newsletter { get; set; }

        //FreeTrial is boolean : if the client want a FreeTrial (1); if not (0)
        public int Freetrial { get; set; }

       
        

    }
}
