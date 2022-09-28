using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.HomePage.ViewComponents
{
    public class AnaSlideBar:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var model = SlideBarManager.Instance.GetListAll(i => i.locationPage == "homepage");
            return View(model);
        }
    }
}
