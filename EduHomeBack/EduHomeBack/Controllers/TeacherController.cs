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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _dbContext;

        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teachers = _dbContext.Teachers.ToList();
            var positions = _dbContext.Positions.ToList();
            var teacherPositions = _dbContext.TeacherPositions.ToList();
            var socialNetworks = _dbContext.SocialNetworks.ToList();

            var teacherViewModel = new TeacherViewModel()
            {
                TeacherPositions = teacherPositions,
                Teachers = teachers,
                Positions = positions,
                SocialNetworks = socialNetworks

            };

            return View(teacherViewModel);
        }
    }
}
