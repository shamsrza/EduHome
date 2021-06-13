using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class BlogViewModel
    {
        public List<BlogList> BlogList { get; set; }
        public Blog BlogDetail { get; set; }
    }
}
