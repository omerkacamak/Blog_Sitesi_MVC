using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Mesaj
{
    public class MesajKisileri: ViewComponent
    {
        MesajManager mm = new MesajManager(new EfMesajDal());
        public IViewComponentResult Invoke(int id)
        {
            var model = mm.getByIDWithWriter1(id);
           
            return View(model);
        }
    }
}
