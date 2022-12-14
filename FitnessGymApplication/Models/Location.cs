using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    public class Location
    {
        public int ID { get; set; }
        public  string address { get; set; }
        public int PostaCode { get; set; }
    }
}
