using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.Entities.Concrete
{
    public class Blog:IEntity
    {
        public Blog()
        {
            Comments = new List<Comment>();
        }

        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Counter { get; set; }
        public bool isActive { get; set; }
        public DateTime CreationDate { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
