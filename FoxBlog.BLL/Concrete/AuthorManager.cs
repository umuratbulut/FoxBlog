using Core.Aspects.Autofac.Validation;
using FoxBlog.BLL.Abstract;
using FoxBlog.BLL.ValidationRules.FluentValidation;
using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Concrete
{
    public class AuthorManager : IAuthorService
    {
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        private IAuthorDal _authorDal;

        [ValidationAspect(typeof(AuthorValidator))]
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public Author Find(int id)
        {
            return _authorDal.Find(x=>x.ID.Equals(id));
        }

        public List<Author> GetList()
        {
            return _authorDal.GetList().OrderByDescending(x=>x.ID).ToList();
        }

        public void Remove(Author author)
        {
            _authorDal.Remove(author);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public void AddWithHash(Author author)
        {
            _authorDal.AddWithHash(author);
        }
    }
}
