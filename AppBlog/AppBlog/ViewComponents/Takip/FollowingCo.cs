using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Takip
{
    public class FollowingCo:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke(int id )
        {
            var kisi = wm.GetWriterWithBlog1(id);
            return View(kisi);
        }
    }
}
