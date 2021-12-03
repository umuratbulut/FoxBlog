using FoxBlog.BLL.Abstract;
using FoxBlog.Entities.Concrete;
using FoxBlog.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.Controllers
{
    public class AccountController : Controller
    {
        List<CityViewModel> cities;
        public AccountController(IAuthorService authorService)
        {
            _authorService = authorService;

            cities =new List<CityViewModel>{
                new CityViewModel { ID = 1, Name = "Ankara" },
                new CityViewModel { ID = 2, Name = "İstanbul" },
                new CityViewModel { ID = 3, Name = "İzmir" },
            };
           
        }

        private IAuthorService _authorService;

        [HttpGet]
        [Route("giris")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("kayit")]
        public IActionResult Register()
        {
            List<SelectListItem> cityList = (from i in cities
                                             select new SelectListItem
                                             {
                                                 Value = i.ID.ToString(),
                                                 Text = i.Name,
                                             }
                                            ).ToList();
            ViewBag.City = cityList;
            return View();
        }

        [HttpPost]
        [Route("kayit")]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Author author, string verPass)
        {
            try
            {
                if(!author.Password.Equals(verPass))
                {
                    List<SelectListItem> cityList = (from i in cities
                                                     select new SelectListItem
                                                     {
                                                         Value = i.ID.ToString(),
                                                         Text = i.Name,
                                                     }
                                         ).ToList();
                    ViewBag.City = cityList;
                    ModelState.AddModelError("verPass","Şifreler eşleşmiyor!" );
                    return View();
                }
                else
                {
                    _authorService.AddWithHash(author);
                    return Redirect("/");
                }
                
            }
            catch(Exception e)
            {
                List<SelectListItem> cityList = (from i in cities
                                                 select new SelectListItem
                                                 {
                                                     Value = i.ID.ToString(),
                                                     Text = i.Name,
                                                 }
                                            ).ToList();
                ViewBag.City = cityList;
                ModelState.AddModelError("Name",e.Message);
                    return View();
            }
          
        }
    }
}
