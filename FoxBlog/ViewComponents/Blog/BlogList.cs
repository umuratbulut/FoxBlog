using FoxBlog.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.ViewComponents.Blog
{
    public class BlogList : ViewComponent
    {
        public BlogList(IBlogService blogService)
        {
            _blogService = blogService;
        }
        private IBlogService _blogService;

        public IViewComponentResult Invoke()
        {
            return View(_blogService.GetBlogDetails());
        }
    }
}
