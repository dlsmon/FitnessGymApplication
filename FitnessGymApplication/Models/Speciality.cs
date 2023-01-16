using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessGymApplication.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
