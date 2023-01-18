using FitnessGymApplication.Data;
using FitnessGymApplication.Models;
using Google.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
namespace FitnessGymApplication.Controllers
{

    public class CoachController : Controller
    {

        private readonly DBContext context;
        private readonly IHostingEnvironment environment;


        public CoachController(DBContext context, IHostingEnvironment environment)
        {
            this.context = context;
            this.environment = environment;

        }
        private bool CoachExists(int id)
        {
            return (context.Coach?.Any(e => e.ID == id)).GetValueOrDefault();
        }

        string UploadFile(IFormFile file, string urlImage)
        {
            try
            {
                if (file != null)
                {
                    string uploads = Path.Combine(environment.WebRootPath, "Content\\Image");

                    string newPath = Path.Combine(uploads, file.FileName);
                    if (!string.IsNullOrEmpty(urlImage))
                    {
                        string oldPath = Path.Combine(uploads, urlImage);
                        if (oldPath != newPath)
                        {
                            System.IO.File.Delete(oldPath);
                            file.CopyTo(new FileStream(newPath, FileMode.Create));
                        }
                    }
                    else
                    {
                        file.CopyTo(new FileStream(newPath, FileMode.Create));
                    }

                    return file.FileName;
                }

                return urlImage;
            }
            catch (Exception)
            {

                throw;
            }

        }
     
        public IActionResult Create()
        {

            ViewData["IdSpeciality"] = new SelectList(context.Speciality, "Id", "Name");


            return View();
           
        }

        [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,IdSpeciality,Photo,File")] Coach coach)
          {


            
                if (ModelState.IsValid)
                {

                    string fileName = UploadFile(coach.File, coach.Photo);

                    coach.Photo = fileName != null ? "Content\\Image\\" + fileName:string.Empty;

                context.Add(coach);

                    await context.SaveChangesAsync();
                ViewData["IdSpeciality"] = new SelectList(context.Speciality, "Id", "Name");

                return RedirectToAction(nameof(Index));
                }
                return View(coach);
           
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || context.Coach == null)
            {
                return NotFound();
            }

            var coach = await context.Coach.FindAsync(id);
            if (coach == null)
            {
                return NotFound();
            }
            ViewData["IdSpeciality"] = new SelectList(context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);
            return View(coach);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,IdSpeciality,Photo,File")] Coach coach)
        {
            
                if (id != coach.ID)
                {
                    return NotFound();
                }



                if (ModelState.IsValid)
                {
                    try
                    {
                        string fileName = string.Empty;
                        if (coach.File != null)
                            fileName = UploadFile(coach.File, coach.Photo);
                         coach.Photo = !string.IsNullOrEmpty(fileName) ? fileName : coach.Photo;
                         coach.Photo = fileName != null ? "Content\\Image\\" + fileName : string.Empty;

                    context.Update(coach);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CoachExists(coach.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
            ViewData["IdSpeciality"] = new SelectList(context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);

            return View(coach);
            
          
        }


                public IActionResult Index()
                {
                    
                    var data = context.Coach.Include(t => t.Speciality).ToList();
          
                    return View(data);
                }

                // GET: Coach/Delete/5
                public async Task<IActionResult> Delete(int? id)
                {
                    if (id == null || context.Coach == null)
                    {
                        return NotFound();
                    }

                    var coach = await context.Coach
                        .Include(c => c.Speciality)
                        .FirstOrDefaultAsync(m => m.ID == id);
                    if (coach == null)
                    {
                        return NotFound();
                    }

                    return View(coach);
                }
                    [HttpPost, ActionName("Delete")]
                    [ValidateAntiForgeryToken]
                    public async Task<IActionResult> DeleteConfirmed(int id)
                    {
                        if (context.Coach == null)
                        {
                            return Problem("Entity set 'DBContext.Coach'  is null.");
                        }
                        var coach = await context.Coach.FindAsync(id);
                        if (coach != null)
                        {
                            context.Coach.Remove(coach);
                        }

                        await context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

        public async Task<IActionResult> Details(int? id)
                            {
                                if (id == null || context.Coach == null)
                                {
                                    return NotFound();
                                }

                                var coach = await context.Coach
                                    .Include(c => c.Speciality)
                                    .FirstOrDefaultAsync(m => m.ID == id);
                                if (coach == null)
                                {
                                    return NotFound();
                                }

                                return View(coach);
                            }



        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(CoachImage model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var path = environment.WebRootPath;
        //        var filePath = "Content/Image/" + model.Photo.FileName;
        //        var fullPath = Path.Combine(path, filePath);
        //        UploadFile(model.Photo, fullPath);
        //        var data = new Coach()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            Photo = filePath,
        //            IdSpeciality = model.IdSpeciality,

        //        };

        //        context.Add(data);
        //        context.SaveChanges();
        //        return RedirectToAction("index");

        //    }
        //    else
        //    {
        //        return View(model);
        //    }

        //}
        //public void UploadFile(IFormFile file, string path)
        //{
        //    FileStream stream = new FileStream(path, FileMode.Create);
        //    file.CopyTo(stream);

        //}

        //public IActionResult Index()
        //{
        //    var data = context.Coach.ToList();

        //    return View(data);
        //}

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || context.Coach == null)
        //    {
        //        return NotFound();
        //    }

        //    var coach = await context.Coach
        //        .Include(c => c.Speciality)
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (coach == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(coach);
        //}

        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || context.Coach == null)
        //    {
        //        return NotFound();
        //    }

        //    var image = context.Coach;

        //    if (image == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(image);
        //}


        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var imageModel = await context.Coach.FindAsync(id);

        //    //delete image from wwwroot/image
        //    var imagePath = Path.Combine(environment.WebRootPath, "Content/Image", imageModel.Photo);
        //    if (System.IO.File.Exists(imagePath))
        //        System.IO.File.Delete(imagePath);
        //    //delete the record
        //    context.Coach.Remove(imageModel);
        //    await context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
