using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetList();
        void Add(Category author);
        void Update(Category author);
        void Remove(Category author);
        Category Find(int id);
    }
}
