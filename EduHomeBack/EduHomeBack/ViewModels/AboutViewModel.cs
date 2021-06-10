using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class AboutViewModel
    {
        public HomeAbout HomeAbout { get; set; }
        public HomeVideoTour HomeVideoTour { get; set; }
        public List<HomeNoticeBoard> HomeNoticeBoard { get; set; }
        public List<Testimonial> Testimonial { get; set; }



        //public List<Teacher> Teachers { get; set; }
        //public List<Position> Positions { get; set; }
        //public List<TeacherPosition> TeacherPositions { get; set; }
        //public List<SocialNetwork> SocialNetworks { get; set; }

    }
}
