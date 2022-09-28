using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppBlog.ViewComponents.Comment
{
    public class AddComment:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int blogid)
        {
            Datam.Models.Comment c = new Datam.Models.Comment();
            ViewBag.BlogId=blogid;
            return View(c);
        }
            
    }
}
