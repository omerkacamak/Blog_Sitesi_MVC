using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class AllWriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            var model = wm.GetListAll(c=>c.RoleId == 1);
            return View(model);
        }
    }
}
