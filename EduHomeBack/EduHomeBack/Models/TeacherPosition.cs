using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class TeacherPosition
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }

        //public int TeacherId { get; set; }
        //public Teacher Teacher { get; set; }

        public int TeacherListId { get; set; }
        public TeacherList TeacherList { get; set; }
    }
}
