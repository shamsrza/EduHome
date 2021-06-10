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
            var teachers = _dbContext.Teachers.Include(x => x.TeacherPositions).ThenInclude(x => x.Position)
                                              .Include(x => x.SocialNetworks).ToList();

            return View(teachers);
        }
    }
}
