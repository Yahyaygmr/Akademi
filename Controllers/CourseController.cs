using Akademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Akademi.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public ActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//Sahtecilik ve haclemenin önüne geçbilmek için
        public ActionResult Apply([FromForm]Candidate candidate)
        {
            if (Repository.Applications.Any(a => a.Email.Equals(candidate.Email)))
            {
                ModelState.AddModelError("", "Zaten Bir Başvurunuz Bulunmakta !");
            }
            if(ModelState.IsValid)
            {
                 Repository.Add(candidate);
                return View("Feedback", candidate);
            }
            return View();
           
        }
    }
}