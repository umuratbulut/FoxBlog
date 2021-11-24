using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList();
        void Add(Blog author);
        void Update(Blog author);
        void Remove(Blog author);
        Blog Find(int id);
    }
}
