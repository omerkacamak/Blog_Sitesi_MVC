using Microsoft.AspNetCore.Mvc;
using Datam.Models;
using DataAccessLayer.EntityFramework;
using Data.Services.EntityManager;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Data.Services.ValidationRules;
using FluentValidation.Results;

namespace AppBlog.Areas.Blog.Controllers
{
    [Area("Blog")]
    [Authorize(Roles="Yazar")]
    public class Add : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        
        public IActionResult Index()
        {
            List<SelectListItem> kategoriNo = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                  Text= x.CategoryName,
                                                  Value=x.CategoryID.ToString()
                                               }).ToList();

            ViewBag.cv = kategoriNo;

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Datam.Models.Blog b)
        {
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            BlogValidator kural = new BlogValidator();
            ValidationResult results = kural.Validate(b);
            if (results.IsValid)
            {
                b.BlogCreateDate = System.DateTime.Now;
                b.BlogStatus = true;
                b.WriterID = userid;
                bm.TAdd(b);
                return RedirectToAction("Index", "Home", new { area = "Writer" });
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }



            // if(b.BlogImage != null)
            //{
            //    var extensions = Path.GetExtension(b.BlogImage.FileName);
            //    var imageName = Guid.NewGuid() + extensions;
            //    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blogimage/");
            //    var stream =  new FileStream(location, FileMode.Create);

            //}



            //
           return View();
        }

        
    }
}
