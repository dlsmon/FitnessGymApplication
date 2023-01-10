using Microsoft.AspNetCore.Mvc;

namespace FitnessGymApplication.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }      

        public IActionResult MyInformation()
        {
            return View();
        }

        public IActionResult MyGoal()
        {
            return View();
        }

        public IActionResult MyReservation()
        {
            return View();
        }

     
    }
}
