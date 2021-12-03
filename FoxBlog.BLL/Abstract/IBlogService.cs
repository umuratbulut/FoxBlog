using FoxBlog.Entities.Concrete;
using FoxBlog.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList();
        List<BlogDetailDto> GetBlogDetails();
        void Add(Blog author);
        void Update(Blog author);
        void Remove(Blog author);
        Blog Find(int id);
        List<Blog> LastPosts(int take);
        List<Blog> PopularPosts(int take);
        void UpCounter(int id);
    }
}
