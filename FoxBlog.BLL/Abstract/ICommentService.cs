using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Abstract
{
   public interface ICommentService
    {
        List<Comment> GetList();
        void Add(Comment author);
        void Update(Comment author);
        void Remove(Comment author);
        Comment Find(int id);
    }
}
