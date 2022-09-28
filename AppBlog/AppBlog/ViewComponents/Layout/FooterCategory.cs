using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Layout
{
    public class FooterCategory:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var model = cm.GetList();
            return View(model);
        }
    }
}
