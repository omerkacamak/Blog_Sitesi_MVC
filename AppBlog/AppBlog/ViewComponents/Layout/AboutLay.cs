using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Layout
{
    public class AboutLay : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
