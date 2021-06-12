using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class SocialNetwork
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }

        //public int TeacherId { get; set; }
        //public Teacher Teacher { get; set; }

        public int TeacherListId { get; set; }
        public TeacherList TeacherList { get; set; }
    }
}
