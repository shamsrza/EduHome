using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class SearchViewModel
    {
        public List<TeacherList> TeacherList { get; set; }
        public List<CourseList> CourseList { get; set; }
        public List<EventList> EventList { get; set; }
        public List<BlogList> BlogList { get; set; }
    }
}
