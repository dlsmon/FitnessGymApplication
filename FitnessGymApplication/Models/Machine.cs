using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class Machine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        [ForeignKey("IDLocation")]
        public ICollection<Location> Locations { get; set; }
    }
}
