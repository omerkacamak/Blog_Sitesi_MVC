using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.HomePage.ViewComponents
{
    public class IlginiziCekebilir:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var model = BlogManager.Instance.GetList();
            return View(model);
        }
    }
}
