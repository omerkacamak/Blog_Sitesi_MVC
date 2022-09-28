using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Event.Controllers
{
    [Area("Event")]
    
   
    
    public class YazarOlma : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
