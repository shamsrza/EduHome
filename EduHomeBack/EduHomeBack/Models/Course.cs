using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AboutCourse { get; set; }
        public string HowToApply { get; set; }
        public string Certification { get; set; }
        public DateTime Starts { get; set; } /*= DateTime.Now.ToString("dd MMMM, YYYY");*/
        public string Start { get; set; } = DateTime.UtcNow.ToString("dd MMMM, YYYY");
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int Students { get; set; }
        public string Assesments { get; set; }
        public double CourseFee { get; set; }

        [ForeignKey("CourseList")]
        public int CourseListId { get; set; }
        public CourseList CourseList { get; set; }
        

    }
}
