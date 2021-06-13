using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using EduHomeBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EduHomeBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var slider = _dbContext.Sliders.FirstOrDefault();
            var sliderImages = _dbContext.SliderImages.ToList();
            var services = _dbContext.Services.ToList();
            var homeAbout = _dbContext.HomeAbout.FirstOrDefault();
            var homeCourseOffers = _dbContext.HomeCourseOffers.ToList();
            var homeNoticeBoard = _dbContext.HomeNoticeBoard.ToList();
            var homeVideoTour = _dbContext.HomeVideoTour.FirstOrDefault();
            var homeEventArea = _dbContext.HomeEventArea.ToList();
            var testimonial = _dbContext.Testimonials.ToList();
            var homeBlogArea = _dbContext.HomeBlogArea.ToList();

            var homeViewModel = new HomeViewModel()
            {
                Slider = slider,
                SliderImages = sliderImages,
                Services = services,
                HomeAbout = homeAbout,
                HomeCourseOffers=homeCourseOffers,
                HomeNoticeBoard = homeNoticeBoard,
                HomeVideoTour = homeVideoTour,
                HomeEventArea = homeEventArea,
                Testimonial = testimonial,
                HomeBlogArea = homeBlogArea
            };

            return View(homeViewModel);
        }

        public IActionResult Search(string search)
        {
            if (string.IsNullOrEmpty(search))
                return NotFound();

            var searchViewModel = new SearchViewModel
            {
                TeacherList = _dbContext.TeacherList.Where(x => x.IsDeleted == false && x.Fullname.ToLower().Contains(search.ToLower())).Take(4).ToList(),
                EventList = _dbContext.EventList.Where(x => /*x.IsDeleted == false &&*/ x.Name.ToLower().Contains(search.ToLower())).Take(4).ToList(),
                CourseList = _dbContext.CourseList.Where(x => /*x.IsDeleted == false &&*/ x.Name.ToLower().Contains(search.ToLower())).Take(4).ToList(),
                BlogList = _dbContext.BlogList.Where(x => x.IsDeleted == false && x.Title.ToLower().Contains(search.ToLower())).Take(4).ToList(),
            };
            return PartialView("_GlobalSearchPartial", searchViewModel);
        }

    }
}
