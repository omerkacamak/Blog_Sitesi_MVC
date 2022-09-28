using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AppBlog.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class OtherController : Controller // kullanıcı tıkladığında istediği kişini profile gider.
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        FollowersManager fm = new FollowersManager(new EfFollowersDal());
        public IActionResult Index(int id)
        {
            if(User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
                var userid = Convert.ToInt32(user);
                ViewBag.userid = userid;
            }
            var writer = wm.GetWriterWithBlog1(id);
            return View(writer);
        }
        
        [HttpGet]
        public IActionResult RefreshViewComponent()
        {
            return ViewComponent("DenemeView");
        }

        public IActionResult FollowerRefresh(int id)
        {
            return ViewComponent("FollowerCo", new {id=id});
        }

        public IActionResult BlogRefresh(int id)
        {
            return ViewComponent("WritersBlog", new { id = id });
        }
        public IActionResult FollowingRefresh(int id)
        {
            return ViewComponent("FollowingCo", new { id = id });
        }
        public IActionResult EditProRef(int id)
        {
            return ViewComponent("EditMyProfile" , new {id=id});
        }


        //PartialView
         public IActionResult PartialWritersBlog(int id)
        {
            var model = wm.GetWriterWithBlog1(id);
            return PartialView("_PartialWritersBlog",model);
        }
        public IActionResult PartialGetFollower(int id)
        {
            var kisi = wm.GetWriterWithBlog1(id);
            return PartialView("_PartialGetFollower", kisi);
        }
        public IActionResult PartialGetFollowing(int id)
        {
            var kisi = wm.GetWriterWithBlog1(id);
            return PartialView("_PartialGetFollowing", kisi);
        }
    }
}
