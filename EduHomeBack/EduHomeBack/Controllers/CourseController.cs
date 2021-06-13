using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using EduHomeBack.ViewModels;
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
        public async Task<IActionResult> Index(/*int page = 1*/ int? categoryId)
        {
            //ViewBag.PageCount = Decimal.Ceiling(_dbContext.Courses.Count() / 3 );
            //ViewBag.Page = page;
            if (categoryId == null)
            {
                var courses = await _dbContext.CourseList/*.OrderByDescending(x => x.Id).Skip((page - 1) * 3).Take(3)*/.ToListAsync();

                return View(courses);
            }
            else
            {
                var courses = await _dbContext.CourseList.Where(x => x.CategoryId == categoryId).ToListAsync();

                return View(courses);
            }
            
            
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var courseDetail = await _dbContext.Courses.Include(x => x.CourseList).FirstOrDefaultAsync(x => x.CourseListId == id);
            var categories = _dbContext.Categories.Where(x => x.IsDeleted == false).Include(x => x.CourseLists.Where(x => x.IsDeleted == false)).ToList();

            if (courseDetail == null)
                return NotFound();

            var courseViewModel = new CourseViewModel
            {
                Categories = categories,
                Course = courseDetail,
                BlogList = _dbContext.BlogList.Where(x => x.IsDeleted == false).OrderByDescending(x => x.PublishDate).Take(3).ToList()
            };
            return View(courseViewModel);
        }

        public IActionResult Search(string search)
        {
            if (search == null)
                return NotFound();

            var courses = _dbContext.CourseList.Where(x => x.Name.Contains(search)).Take(5).OrderByDescending(x => x.Couse.Starts).ToList();

            return PartialView("_CourseSearchPartial", courses);
        }


    }
}
