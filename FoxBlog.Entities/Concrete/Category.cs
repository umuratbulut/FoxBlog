using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Blogs = new List<Blog>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isActive { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
