using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlog.ViewComponents.Blog
{
    public class DenemeView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
