using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetList();
        void Add(Author author);
        void Update(Author author);
        void Remove(Author author);
        Author Find(int id);
        void AddWithHash(Author author);

    }
}
