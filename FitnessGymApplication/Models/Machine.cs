using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitnessGymApplication.Models
{
    public class Machine
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(200), MinLength(3)]
        public string Description { get; set; }
        public virtual ICollection<MachineLocation>? MachineLocations { get; set; }

    }
}
