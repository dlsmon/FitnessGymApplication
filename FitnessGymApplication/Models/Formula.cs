using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Formula
    {

        public enum eCommitement
        {
            None = 0,
            Yes = 1    
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        [Display(Name ="Formula Name")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public eCommitement Commitement { get; set; }
    }
}
