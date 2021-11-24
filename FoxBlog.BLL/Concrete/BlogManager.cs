using FoxBlog.BLL.Abstract;
using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
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

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public Blog Find(int id)
        {
            return _blogDal.Find(x => x.ID.Equals(id));
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetList().OrderByDescending(x => x.ID).ToList();
        }

        public void Remove(Blog blog)
        {
            _blogDal.Remove(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

    }
}
