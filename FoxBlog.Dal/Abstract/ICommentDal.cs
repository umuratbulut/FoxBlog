using Core.DataAccess;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.DAL.Abstract
{
  public interface ICommentDal:IRepository<Comment>
    {
    }
}
