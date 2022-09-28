using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppBlog.Areas.HomePage.Controllers
{
    [Area("HomePage")]
    
    public class HomeController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        WriterManager wm = new WriterManager(new EfWriterDal());

        public IActionResult Index()
        {
           if(User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
                var userid = Convert.ToInt32(user);
                ViewBag.userid = userid;
                var model2 = wm.GetWriterWithBlog1(userid);
            }
           
           
            var model = bm.GetAllWithCatWri1();
           
            return View(model);
        }

        public async Task<PartialViewResult> WeatherNewsPartial()
        {
            var deneme = new Root();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=Ankara,TR&units=metric&appid=820acb409636873eaf84d7899535bfc8"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deneme = JsonConvert.DeserializeObject<Root>(apiResponse);
                }

            }
            ViewBag.derece = deneme.main.feels_like;
            ViewBag.sehir = deneme.name;
            ViewBag.abc = 40;

            return PartialView();
        }


        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class Root
        {
            public Main main { get; set; }

            public string name { get; set; }

        }
    }
}
