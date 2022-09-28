using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kaydol()
        {
            return View();
        }
    }
}
