using FitnessGymApplication.Data;
using FitnessGymApplication.Models;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
namespace FitnessGymApplication.Controllers
{
    
    public class CoachImageController : Controller
    {
      
        private readonly DBContext context;
        private readonly IHostingEnvironment environment;


        public CoachImageController(DBContext context, IHostingEnvironment environment)
        {
            this.context = context;
            this.environment = environment;

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CoachImage model)
        {
            if (ModelState.IsValid)
            {
                var path = environment.WebRootPath;
                var filePath = "Content/Image/" + model.Photo.FileName;
                var fullPath = Path.Combine(path, filePath);
                UploadFile(model.Photo, fullPath);
                var data = new Coach()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Photo = filePath,
                    IdSpeciality =model.IdSpeciality,
                   
                };

                context.Add(data);
                context.SaveChanges();
                return RedirectToAction("index");

            }
            else
            {
                return View(model);
            }

        }
        public void UploadFile(IFormFile file, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);

        }

        public IActionResult Index()
        {
            var data = context.Coach.ToList();

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || context.Coach == null)
            {
                return NotFound();
            }

            var image = context.Coach;

            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }
    }
}
