using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.LeftSideBar
{
    public class LeftSideBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
