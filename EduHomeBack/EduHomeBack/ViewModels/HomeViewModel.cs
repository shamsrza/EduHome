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
    }
}
