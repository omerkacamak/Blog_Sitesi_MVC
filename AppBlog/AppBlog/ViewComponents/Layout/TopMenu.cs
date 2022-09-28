using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.TopMenu
{
    public class TopMenu:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var model = cm.GetList();
            return View(model);
        }
    }
}
