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
        public Testimonial Testimonial { get; set; }
        public string Key { get; set; }
    }
}
