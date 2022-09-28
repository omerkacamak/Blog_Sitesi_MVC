
using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppBlog.ViewComponents.Comment
{
    [ViewComponent(Name = "CommentListByBlog")]

    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public  IViewComponentResult Invoke(int id) 
        {
            var model = cm.GetCommentsBlog1(id);
            return View(model);
        }
    }
}
