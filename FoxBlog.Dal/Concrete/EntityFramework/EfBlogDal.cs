using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using FoxBlog.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.DAL.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, FoxBlogContext>, IBlogDal
    {
        public List<BlogDetailDto> GetBlogDetails()
        {
            using (FoxBlogContext context = new FoxBlogContext())
            {
                var result = (from b in context.Blogs
                              join a in context.Authors
                              on b.AuthorID equals a.ID
                              join c in context.Categories
                              on b.CategoryID equals c.ID
                              select new BlogDetailDto
                              {
                                  BlogID = b.ID,
                                  BlogCategory = c.Name,
                                  BlogAuthor = a.Name + " " + a.Surname,
                                  BlogSeoUrl=b.SeoUrl,
                                  BlogKeyword=b.Keyword,
                                  BlogDescription=b.Description,
                                  BlogImage = b.Image,
                                  BlogTitle = b.Title,
                                  BlogContent = b.Content,
                                  BlogCounter = b.Counter,
                                  BlogStatus = b.isActive,
                                  BlogDate = b.CreationDate
                              });
                            
                return result.ToList();
            }
        }

        public List<Blog> LastPosts(int take)
        {
            using (FoxBlogContext context=new FoxBlogContext() )
            {
                return context.Blogs.OrderByDescending(x => x.ID).Take(take).ToList();
            }
        }

        public List<Blog> PopularPosts(int take)
        {
            using (FoxBlogContext context = new FoxBlogContext())
            {
                return context.Blogs.OrderByDescending(x => x.Counter).Take(take).ToList();
            }

        }

        public void UpCounter(int id)
        {
            using (FoxBlogContext context = new FoxBlogContext())
            {
                var blog= context.Blogs.Find(id);
                blog.Counter+=1;
                context.SaveChanges();
            }
        }
    }
}
