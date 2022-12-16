using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Formula
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        [Display(Name ="Formula Name")]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
