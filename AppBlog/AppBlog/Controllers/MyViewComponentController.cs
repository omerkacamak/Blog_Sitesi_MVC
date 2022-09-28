using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Controllers
{ 
    public class MyViewComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
       
        public IActionResult Get(int id)
        {
            return ViewComponent("CommentListByBlog", new { id });
        }



    }
}
