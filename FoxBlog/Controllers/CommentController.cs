using FoxBlog.BLL.Abstract;
using FoxBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxBlog.WebUI.Controllers
{
    public class CommentController : Controller
    {
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        private ICommentService _commentService;

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Add(Comment comment)
        {
            try
            {
                _commentService.Add(comment);
                return Json(true);
            }
            catch (Exception exception)
            {
                return Json(exception.Message);
            }
        }
       
    }
}
