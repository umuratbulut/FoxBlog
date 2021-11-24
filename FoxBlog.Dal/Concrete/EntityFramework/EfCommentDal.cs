using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.DAL.Concrete.EntityFramework
{
   public class EfCommentDal:EfEntityRepositoryBase<Comment,FoxBlogContext>,ICommentDal
    {
    }
}
