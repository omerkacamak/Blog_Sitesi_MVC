using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlog.ViewComponents.Blog
{
    public class WritersBlog:ViewComponent
    {
        BlogManager nm = new BlogManager(new EfBlogDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke(int id)
        {
            var model = wm.GetWriterWithBlog1(id);
           
            return View(model);
        }
    }
}
