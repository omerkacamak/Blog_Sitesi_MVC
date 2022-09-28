using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlog.Areas.Takip.Controllers
{
    [Area("Takip")]
    public class HomeController : Controller
    {
        
        WriterManager wm = new WriterManager(new EfWriterDal());
        FollowersManager fm = new FollowersManager(new EfFollowersDal());
        
        public IActionResult Index()
        {
            Followers ff = new Followers();
            ff.Writerid = 2;
            ff.FollowerId = 3;
            fm.TAdd(ff);
            var model = wm.GetWriterWithBlog1(1);
           
            return View(model);
        }
        
        public IActionResult TakipEt(int id)
        {
            Followers followers = new Followers();
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            followers.Writerid = id;
            followers.FollowerId = userid;
            fm.TAdd(followers);

            //return RedirectToAction("Index", "Other", new { area = "Writer" , id=id  });
            return Ok();
        }


        public IActionResult TakiptenCikar(int id)
        {
            
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);

            var foll = fm.GetOne1(i => i.Writerid == id && i.FollowerId == userid);
            fm.TDelete(foll);

            return RedirectToAction("Index", "Other", new { area = "Writer", id = id });
        }
    }
}
