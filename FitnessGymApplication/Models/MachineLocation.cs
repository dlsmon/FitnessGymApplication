using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class MachineLocation
    {

        [Key]
        public int ID { get; set; }

        //Foreign KEYS
        [ForeignKey("IdMachine")]
        public virtual Machine? Machine { get; set; }

        [ForeignKey("IdLocation")]
        public virtual Location? Location { get; set; }


    }
}
