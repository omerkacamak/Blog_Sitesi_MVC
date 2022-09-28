using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AppBlog.Areas.Writer.Controllers
{   
    public class HomeController : Controller // Kullanıcının kendi profili
    {
       WriterManager wm = new WriterManager(new EfWriterDal());
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        [Area("Writer")]
        [Authorize]
        public IActionResult Index(int id)
        {
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            var model = blogManager.GetAllWithCatWri1(i => i.WriterID == userid);
            ViewBag.Writer = wm.GetById(1);
            ViewBag.User = wm.GetWriterWithBlog1(userid);
            var writer = wm.GetWriterWithBlog1(userid);
           

            return View(writer);
        }
        
    }
}
