using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.Entities.Concrete
{
   public class Comment:IEntity
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public bool isActive { get; set; }
        public Blog Blog { get; set; }
    }
}
