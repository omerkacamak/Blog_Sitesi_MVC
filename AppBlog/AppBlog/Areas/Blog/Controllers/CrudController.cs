using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Blog.Controllers
{
    [Area("Blog")]
    [Authorize]
    public class CrudController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Update(int id)
        { 
            
            var model = bm.GetById(id);
            //model.BlogTitle = "Başka bi şey";
            //bm.TUpdate(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Datam.Models.Blog blog)
        {
           // blog.BlogCreateDate = System.DateTime.Now;
            bm.TUpdate(blog);
            return RedirectToAction("Index", "Home", new { area = "Writer" });
        }
    }
}
