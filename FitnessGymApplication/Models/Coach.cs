
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace FitnessGymApplication.Models
{
    public class Coach
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
        public string? Photo { get; set; }
        [Display(Name = "Speciality")]
        public int IdSpeciality { get; set; }
        [ForeignKey("IdSpeciality")]
        public virtual Speciality? Speciality { get; set; }


    }
}
