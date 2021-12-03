using Core.Aspects.Autofac.Validation;
using FoxBlog.BLL.Abstract;
using FoxBlog.BLL.ValidationRules.FluentValidation;
using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using FoxBlog.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Concrete
{
    public class BlogManager:IBlogService
    {
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        private IBlogDal _blogDal;

        [ValidationAspect(typeof(BlogValidator))]
        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public Blog Find(int id)
        {
            return _blogDal.Find(x => x.ID.Equals(id) && x.isActive.Equals(true));
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetList().Where(x => x.isActive.Equals(true)).OrderByDescending(x => x.ID).ToList();
        }

        public List<BlogDetailDto> GetBlogDetails()
        {
           return _blogDal.GetBlogDetails().Where(x=>x.BlogStatus.Equals(true)).OrderByDescending(x=>x.BlogID).ToList();
        }

        public void Remove(Blog blog)
        {
            _blogDal.Remove(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> LastPosts(int take)
        {
           return _blogDal.LastPosts(take);
        }

        public List<Blog> PopularPosts(int take)
        {
            return _blogDal.PopularPosts(take);
        }

        public void UpCounter(int id)
        {
            _blogDal.UpCounter(id);
        }
    }
}
