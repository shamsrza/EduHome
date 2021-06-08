using EduHomeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewModels
{
    public class HomeViewModel
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public List<Service> Services { get; set; }
        public HomeAbout HomeAbout { get; set; }
        public List<HomeCourseOffers> HomeCourseOffers { get; set; }
        public HomeVideoTour HomeVideoTour { get; set; }
        public List<HomeNoticeBoard> HomeNoticeBoard { get; set; }
        public List<HomeEventArea> HomeEventArea { get; set; }
        public List<Testimonial> Testimonial { get; set; }
        public List<HomeBlogArea> HomeBlogArea { get; set; }
    }
}
