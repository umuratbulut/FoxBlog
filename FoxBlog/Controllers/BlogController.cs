using FoxBlog.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        private IBlogService _blogService;

        [HttpGet]
        [Route("{SeoUrl}-{id}")]
        public IActionResult Detail(int id)
        {
            var result = _blogService.GetBlogDetails().Where(x=>x.BlogID.Equals(id));
            if (result!=null)
            {
                _blogService.UpCounter(id);
                return View(result);
            }
            else
            {
                return View();
            }
           
        }
    }
}
