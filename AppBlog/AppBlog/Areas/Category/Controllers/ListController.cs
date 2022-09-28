using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Category.Controllers
{
    public class ListController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        BlogManager bm = new BlogManager(new EfBlogDal());
        
        
        [Area("Category")]
        public IActionResult Index()
        {
            
            var model = cm.GetList();
            return View(model);
        }
       
    }
}
