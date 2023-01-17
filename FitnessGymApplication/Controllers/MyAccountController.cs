using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessGymApplication.Data;
using FitnessGymApplication.Models;

namespace FitnessGymApplication.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly DBContext _context;

        public MyAccountController(DBContext context)
        {
            _context = context;
        }

        public IActionResult Index() 
        {
            return View();
        }      

        public IActionResult MyInformation() // Show details
        {
            int id = 1;
            if (id == null || _context.Client == null)
            {
                return NotFound();
            }

            var client = _context.Client.First(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
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
