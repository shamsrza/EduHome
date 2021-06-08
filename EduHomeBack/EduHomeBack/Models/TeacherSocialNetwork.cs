using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class TeacherSocialNetwork
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
        public int SocialNetworkId { get; set; }
    }
}
