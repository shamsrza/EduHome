using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class TeacherList
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public bool IsDeleted { get; set; }

        public Teacher Teacher { get; set; }
        public ICollection<TeacherPosition> TeacherPositions { get; set; }
        public ICollection<SocialNetwork> SocialNetworks { get; set; }

    }
}
