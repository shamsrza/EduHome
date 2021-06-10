using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name{ get; set; }

        [Required]
        public string AboutMe{ get; set; }

        [Required]
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Skype { get; set; }
        public int Language { get; set; }
        public int TeamLeader { get; set; }
        public int Development  { get; set; }
        public int Design { get; set; }
        public int Innovation { get; set; }
        public int Communication { get; set; }

        public ICollection<SocialNetwork> SocialNetworks { get; set; }
        public ICollection<TeacherPosition> TeacherPositions { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }

    }
}
