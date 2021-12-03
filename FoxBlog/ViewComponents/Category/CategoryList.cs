using FoxBlog.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        public CategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        private ICategoryService _categoryService;

        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetList());
        }
    }
}
