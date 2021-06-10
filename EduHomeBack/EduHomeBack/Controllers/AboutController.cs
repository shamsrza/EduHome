using EduHomeBack.DataAccessLayer;
using EduHomeBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AboutController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            
            var homeAbout = _dbContext.HomeAbout.FirstOrDefault();
            var homeNoticeBoard = _dbContext.HomeNoticeBoard.ToList();
            var homeVideoTour = _dbContext.HomeVideoTour.FirstOrDefault();
            var testimonial = _dbContext.Testimonials.ToList();

            var aboutViewModel = new AboutViewModel()
            {               
                HomeAbout = homeAbout,
                HomeNoticeBoard = homeNoticeBoard,
                HomeVideoTour = homeVideoTour,
                Testimonial = testimonial,
                
            };

            return View(aboutViewModel);
        }
    }
}
