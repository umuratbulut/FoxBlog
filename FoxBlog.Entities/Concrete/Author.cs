using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.Entities.Concrete
{
    public class Author:IEntity
    {
        public Author()
        {
            Blogs = new List<Blog>();
        }

        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string isActive { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
