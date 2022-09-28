using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Mesaj
{
    public class MesajIcerik:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
           

            return View();
        }
    }
}
