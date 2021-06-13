using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class EventViewModel
    {
        public List<BlogList> BlogList { get; set; }
        public Event Event { get; set; }
        public List<Category> Categories { get; set; }
    }
}
