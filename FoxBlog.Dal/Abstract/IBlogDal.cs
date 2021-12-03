using Core.DataAccess;
using FoxBlog.Entities.Concrete;
using FoxBlog.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.DAL.Abstract
{
   public interface IBlogDal:IRepository<Blog>
    {
        List<BlogDetailDto> GetBlogDetails();
        List<Blog> LastPosts(int take);
        List<Blog> PopularPosts(int take);
        void UpCounter(int id);
    }
}
