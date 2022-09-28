using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Blog
{
    public class GetPopBlog:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogDal());
            var model = bm.GetPopularBlogs1();
            return View(model);
        }
    }
}
