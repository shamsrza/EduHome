using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class TeacherViewModel
    {
        public Teacher Teacher { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherList> TeacherList { get; set; }
        public List<Position> Positions { get; set; }
        public List<TeacherPosition> TeacherPositions { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
    }
}
