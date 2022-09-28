using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Category.Controllers
{
    public class BlogsController : Controller // Kategoriye tıklandığında ilgili kategorinin blogları gelir.
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        [Area("Category")]
        public IActionResult Index(string isim)
        {
            var model = bm.GetAllWithCatWri1(i => i.Category.CategoryName == isim);
            return View(model);
        }
    }
}
