using Data.Services.EntityManager;
using Data.Services.ValidationRules;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using WebMatrix.WebData;
using static WebMatrix.WebData.WebSecurity;

namespace AppBlog.Controllers
{
    
    public class LoginController : Controller 
    {
        WriterManager wm = new WriterManager(new EfWriterDal());

        [HttpGet]
        public IActionResult Index()
        {
           
           
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> Index(string name, string password)
        {
            var writer = wm.GetOne1(i => i.WriterName == name && i.WriterPassword==password);
            

            if (writer==null)
            {
                var hata = "Kullanıcı Adı Veya Şifre Hatalı! Tekrar Deneyin";
                TempData["hata"] = hata;
                
                //return RedirectToAction("Index", new {hata=hata});

            }
            else
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", name));
             
              
                claims.Add(new Claim(ClaimTypes.NameIdentifier, name));
                claims.Add(new Claim(ClaimTypes.Name, name));
                claims.Add(new Claim(ClaimTypes.PrimarySid,writer.WriterID.ToString()));
                claims.Add(new Claim("writerid",writer.WriterID.ToString()));
                claims.Add(new Claim("role",writer.RoleId.ToString()));
               if(writer.RoleId==1)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Yazar"));
                }
               else if(writer.RoleId==2)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Normal"));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                ModelState.AddModelError(string.Empty, "Yanlış Şifre");
                  return RedirectToAction("Index", "Home", new { area = "HomePage" });
               // return View();
                
            }

            return View();
            
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {
            WriterValidator kural = new WriterValidator();
            ValidationResult results =  kural.Validate(writer);
            if(results.IsValid)
            {
                writer.WriterStatus = true;
                writer.RoleId = 2;
                wm.TAdd(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach ( var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
            }
            return View();
           
        }
    }
}
