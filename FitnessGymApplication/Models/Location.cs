using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(160)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }
         
        [Display(Name = "Participants")]
        public int MaxParticipants { get; set; }
        public virtual ICollection<MachineLocation>? MachineLocation { get; set; }
    }
}

