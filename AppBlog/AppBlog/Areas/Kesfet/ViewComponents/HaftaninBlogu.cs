using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AppBlog.Areas.Kesfet.ViewComponents
{
    public class HaftaninBlogu:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = BlogManager.Instance.GetPopularBlogs1();
            return View(model);
        }
    }
}
