using Microsoft.AspNetCore.Mvc;

namespace FitnessGymApplication.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()  //Register's index is the Sign UP
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult MyQuiz()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
