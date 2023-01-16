using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class CoachImage
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(10), MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10), MinLength(3)]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Please choose file to upload.")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        public IFormFile Photo { get; set; }
        [Display(Name = "Speciality")]
        public int? IdSpeciality { get; set; }

        [ForeignKey("IdSpeciality")]
        public virtual Speciality? Speciality { get; set; }


    }
}
