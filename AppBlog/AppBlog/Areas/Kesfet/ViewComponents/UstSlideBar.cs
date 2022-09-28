using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.Areas.Kesfet.ViewComponents
{
    public class UstSlideBar:ViewComponent
    {
        SlideBarManager sm = new SlideBarManager(new EfSlideBarDal());
        public IViewComponentResult Invoke()
        {
            var model = sm.GetListAll(i => i.locationPage == "kesfet");
            return View(model);
        }
    }
}
