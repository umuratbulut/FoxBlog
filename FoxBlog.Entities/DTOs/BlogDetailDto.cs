using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.Entities.DTOs
{
   public class BlogDetailDto:IDto
    {
        public int BlogID { get; set; }
        public string BlogCategory { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogSeoUrl { get; set; }
        public string BlogKeyword { get; set; }
        public string BlogDescription { get; set; }
        public string BlogImage { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public int BlogCounter { get; set; }
        public bool BlogStatus { get; set; }
        public DateTime BlogDate { get; set; }
    }
}
