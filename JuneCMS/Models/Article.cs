using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace JuneCMS.Models
{
    public class Article
    {
        public string ArticleID { get; set; }
        public string Title { get; set; }

        public DateTime PostTime { get; set; }

        public string Content { get; set; }
    }
}
