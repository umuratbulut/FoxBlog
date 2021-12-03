using FoxBlog.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.ViewComponents.Blog
{
    public class LastPosts:ViewComponent
    {
        public LastPosts(IBlogService blogService)
        {
            _blogService = blogService;
        }
        private IBlogService _blogService;

        public IViewComponentResult Invoke()
        {
            return View(_blogService.LastPosts(3));
        }
    }
}
