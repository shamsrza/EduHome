using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<CourseList> CourseLists { get; set; }
        public ICollection<EventList> EventLists { get; set; }
        public ICollection<BlogList> BlogLists { get; set; }
    }
}
