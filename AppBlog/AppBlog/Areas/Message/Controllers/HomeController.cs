using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppBlog.Areas.Message.Controllers
{
    [Area("Message")]
    public class HomeController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            var model = wm.GetWriterWithMessages1(1);
            var model2 = wm.getAllMesajsByWriter1(1);// kullanıcının gönderdiği aldığı ttüm mesajlar
            
          
            return View(model2);
        }
    }
}
