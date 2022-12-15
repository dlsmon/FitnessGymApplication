using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace FitnessGymApplication.Models
{
    public class Machine
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
