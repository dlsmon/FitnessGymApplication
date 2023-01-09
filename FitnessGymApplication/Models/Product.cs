using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        //[Required(ErrorMessage = "Please choose file to upload.")]
        public string? Photo { get; set; }
    }
}
