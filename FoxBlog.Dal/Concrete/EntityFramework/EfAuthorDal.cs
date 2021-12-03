using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.DAL.Concrete.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, FoxBlogContext>, IAuthorDal
    {
        public void AddWithHash(Author author)
        {
            using (FoxBlogContext context=new FoxBlogContext())
            {
                var crypto = new SimpleCrypto.PBKDF2();
                var encrypedPassword = crypto.Compute(author.Password);
                author.Password = encrypedPassword;
                author.PasswordSalt = crypto.Salt;
                var entity = context.Entry(author);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
