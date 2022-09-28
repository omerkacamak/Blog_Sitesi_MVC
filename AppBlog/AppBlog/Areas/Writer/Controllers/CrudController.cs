using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class CrudController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
       
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
          

            return RedirectToAction("Index", "Home", new {area="Writer"});
        }
        [Authorize]
        [HttpPost]
        public IActionResult Index(Datam.Models.Writer writer)
        {
            wm.TUpdate(writer);

            return RedirectToAction("Index", "Home", new { area = "Writer" });
            //return View(writer); 
        }

    }
}
