﻿using EduHomeBack.DataAccessLayer;
using EduHomeBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

            var homeViewModel = new HomeViewModel()
            {
                Slider = slider,
                SliderImages = sliderImages,
                Services = services,
                HomeAbout = homeAbout
            };

            return View(homeViewModel);
        }
    }
}