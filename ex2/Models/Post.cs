using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorWebPage { get; set; }
        public DateTime PublshDate { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}