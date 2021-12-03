using FoxBlog.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        public CommentListByBlog(ICommentService commentService)
        {
            _commentService = commentService;
        }
        private ICommentService _commentService;

        public IViewComponentResult Invoke(int id)
        {
            return View(_commentService.GetList().Where(x=>x.BlogID.Equals(id)));
        }
    }
}
