using FitnessGymApplication.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FitnessGymApplication.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public  string Address { get; set; }
        public int PostalCode { get; set; }
        //Maximum number of participants in  the gym 
        public int MaxParticipants { get; set; }

        public virtual ICollection<Machine> Machines { get; set; }
    }
}

