using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AppBlog.Areas.Blog.Controllers
{
    [Area("Blog")]
    public class HomeController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CommentManager cm = new CommentManager(new EfCommentDal());
        WriterLikesManager likes = new WriterLikesManager(new EfWriterLikesDal());
        
        public IActionResult Index(int id)
        {
            var model = bm.GetAllWithCatWri1(i=>i.BlogID==id);
            Datam.Models.Blog tek = model[0];
            return View(tek);
        }
        [HttpGet]
        
        public IActionResult Begeni(int wid,int bid)
        {
            var blog = bm.GetById(bid);
            blog.Begeni = blog.Begeni + 1;
            bm.TUpdate(blog);
            //return RedirectToAction("Index", new {id=id});
           return Ok();
        }
        [HttpPost]
        public IActionResult YorumEkle(Comment c,int blogid)
        {
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            c.CommentDate = System.DateTime.Now;
            c.CommentStatus = true;
            c.WriterID = userid;
            cm.TAdd(c);

            return RedirectToAction("Index", new {id=blogid});
        }
        [HttpPost]
        public IActionResult DenemeEkle(Comment c)
        {
            c.CommentDate = System.DateTime.Now;
            c.CommentStatus = true;
            c.WriterID = 1;
            c.BlogID = 1;
            cm.TAdd(c);

            var jsonComment = JsonConvert.SerializeObject(c);
            return Json(jsonComment);
        }
        public IActionResult GetMyViewComponent(int uid)
        {
            return ViewComponent("CommentListByBlog", new { id = uid });
        }

        public IActionResult PartialCommentList()
        {
            return PartialView("_PartialCommentList");
        }
    }
}
