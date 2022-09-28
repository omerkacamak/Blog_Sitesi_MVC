using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Search.Controllers
{
    [Area("Search")]
    public class HomeController : Controller
    {
        [Route("/ara")]
        public IActionResult ara(string ara)
        {
            var model = BlogManager.Instance.GetAllWithCatWri1(i => i.BlogContent.Contains(ara) || i.BlogTitle.Contains(ara) || i.Writer.WriterName.Contains(ara));
            return View(model);
        }
    }
}
