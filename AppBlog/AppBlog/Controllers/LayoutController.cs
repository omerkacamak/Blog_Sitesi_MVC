using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public PartialViewResult TopMenu()
        {
            return PartialView("~/Views/Layout/_TopMenu.cshtml");
        }
    }
}
