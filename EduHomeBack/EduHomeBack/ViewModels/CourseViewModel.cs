using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public List<BlogList> BlogList { get; set; }
        public Course Course { get; set; }
        public List<Category> Categories { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}
