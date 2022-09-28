using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace AppBlog.ViewComponents.XMenu
{
    public class ApiBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "820acb409636873eaf84d7899535bfc8";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=820acb409636873eaf84d7899535bfc8";
            XDocument document = XDocument.Load(connection);
            ViewBag.derece = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.api2 = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            return View();
        }
    }
}
