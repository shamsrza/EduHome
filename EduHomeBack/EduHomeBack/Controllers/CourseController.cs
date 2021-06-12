using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CourseController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.PageCount = Decimal.Ceiling(_dbContext.Course.Count() / 3 );
            ViewBag.Page = page;
            var courses = await _dbContext.CourseList.OrderByDescending(x => x.Id).Skip((page-1)*3).Take(3).ToListAsync();

            return View(courses);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var courseDetail = await _dbContext.Course.Include(x => x.CourseList).FirstOrDefaultAsync(x => x.CourseListId == id);
            if (courseDetail == null)
                return NotFound();

            return View(courseDetail);
        }

    }
}
