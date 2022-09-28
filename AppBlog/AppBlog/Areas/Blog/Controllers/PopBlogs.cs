using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Blog.Controllers
{
    [Area("Blog")]
    public class PopBlogs : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index() 
        {
            var model = bm.GetPopularBlogs1();
            return View(model);
        }

        public IActionResult PartialPop()
        {
            var model = bm.GetPopularBlogs1();
            return PartialView("_PartialPop",model);
        }
    }
}
