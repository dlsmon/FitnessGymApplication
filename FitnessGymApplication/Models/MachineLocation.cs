using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessGymApplication.Models
{
    public class MachineLocation
    {
            [Key]
            public int ID { get; set; }
            public int IdMachine { get; set; }
            public int IdLocation { get; set; }

            //Foreign KEYS
            [ForeignKey("IdMachine")]
            public virtual Machine? Machine { get; set; }

            [ForeignKey("IdLocation")]
            public virtual Location? Location { get; set; }



        
    }
}
