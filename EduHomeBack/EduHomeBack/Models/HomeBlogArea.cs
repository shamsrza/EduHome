using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class HomeBlogArea
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public int CommentsCount { get; set; }
        public string Title { get; set; }
    }
}
