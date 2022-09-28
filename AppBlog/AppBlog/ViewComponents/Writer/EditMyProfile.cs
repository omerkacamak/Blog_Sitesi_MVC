using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Writer
{
    public class EditMyProfile:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke(int id)
        {
            var model = wm.GetWriterWithBlog1(id);
            return View(model);
        }
    }
}
