using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AppBlog.Areas.Kesfet.Controllers
{
    [Area("Kesfet")]
    public class HomeController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        [Route("kesfet")]
        public IActionResult Index()
        {
           if(User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
                var userid = Convert.ToInt32(user);
                ViewBag.userid = userid;
            }
            var model = wm.GetAllWriterWithRel1();

            return View(model);
        }
    }
}
