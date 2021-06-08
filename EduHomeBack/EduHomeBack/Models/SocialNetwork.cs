using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class SocialNetwork
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Vimeo { get; set; }
        public string Pinterest { get; set; }
        public ICollection <TeacherSocialNetwork> TeacherSocialNetworks { get; set; }
    }
}
