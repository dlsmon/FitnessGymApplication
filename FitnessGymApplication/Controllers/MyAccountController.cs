using Microsoft.AspNetCore.Mvc;

namespace FitnessGymApplication.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }      

        public IActionResult MyInformation() // Show details
        {
            return View();
        }      

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult MySubscription()
        {
            return View();
        }

        public IActionResult MyReservations()   //MyReservation = my planning
        {
            return View();
        }

        public IActionResult MyFavorites()
        {
            return View();
        }

        public IActionResult MyGoal()
        {
            return View();
        }
              


    }
}
