using EduHomeBack.Areas.AdminPanel.Utils;
using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using EduHomeBack.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public CourseController(AppDbContext dbContext, IWebHostEnvironment env)
        {
            _dbContext = dbContext;
            _environment = env;
        }
        public IActionResult Index()
        {
   
            var courses = _dbContext.Courses.Include(x => x.CourseList).ToList();

            return View(courses);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var course = _dbContext.Courses.Include(x => x.CourseList).ThenInclude(x => x.Category).FirstOrDefault(x => x.Id == id);

            if (course == null)
                return NotFound();

            return View(course);
        }


        public async Task<IActionResult> Update(int? id)
        {
            var categories = await _dbContext.Categories.Where(x => x.IsDeleted == false).ToListAsync();
            ViewBag.Categories = categories;

            if (id == null)
                return NotFound();

            var course =  _dbContext.Courses.Where(x => x.IsDeleted == false).Include(x => x.CourseList).ThenInclude(x => x.Category).FirstOrDefault(x => x.Id == id);
            if (course == null)
                return NotFound();

            var courseViewModel = new CourseViewModel
            {
                Course = course,
                Categories = categories              
            };

            return View(courseViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteImage(int? id)
        {
            if (id == null)
                return NotFound();

            var course = _dbContext.Courses.Where(x => x.IsDeleted == false).Include(x => x.CourseList)
                             .ThenInclude(x => x.Category).FirstOrDefault(x => x.Id == id);
            var courseImage = course.Image;
            if (courseImage == null)
                return NotFound();

            var path = Path.Combine(Constants.ImageFolderPath, courseImage);
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);

            _dbContext.Remove(courseImage);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Update", new { Id = id});
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CourseViewModel courseViewModel)
        {
            ViewBag.Categories = _dbContext.Categories.Where(x => x.IsDeleted == false).ToList();
            var categories = ViewBag.Categories;

            if (id == null)
                return NotFound();

            if (id != courseViewModel.Id)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var course = _dbContext.Courses.Where(x => x.IsDeleted == false).Include(x => x.CourseList).ThenInclude(x => x.Category).FirstOrDefault(x => x.Id == id);
            if (course == null)
                return NotFound();

            var isExist = await _dbContext.Courses.Where(x => x.IsDeleted == false)
                          .AnyAsync(x => x.Name.ToLower() == courseViewModel.Course.Name.ToLower() 
                           && x.Id != courseViewModel.Course.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This course is already exist");
                return View(courseViewModel);
            }

            if (courseViewModel.Course.Photo != null && courseViewModel.Course.Photo.Length > 0)
            {
                if (!courseViewModel.Course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "This file is not image");
                    return View(courseViewModel);
                }

                if (!courseViewModel.Course.Photo.IsSizeAllowed(1024))
                {
                    ModelState.AddModelError("Photo", "Size of image is more than 1 MB");
                    return View(courseViewModel);
                }

                var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, courseViewModel.Course.Photo);

                courseViewModel.Course.Image = fileName;
                courseViewModel.Course.IsDeleted = false;

                await _dbContext.Courses.AddAsync(courseViewModel.Course);              
            }

             course = courseViewModel.Course;
             categories = courseViewModel.Categories;

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
         
            ViewBag.Categories = _dbContext.Categories.Where(x => x.IsDeleted == false).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course, int categoryId)
        {
            var categories = await _dbContext.Categories.Where(x => x.IsDeleted == false).ToListAsync();
            ViewBag.Categories = categories;
               

            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.Courses.Where(x => x.IsDeleted == false).AnyAsync(x => x.Name.ToLower() == course.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "This course is already exist");
                return View();
            }

            if(categories.All(x => x.Id != categoryId))
            {
                return NotFound();
            }

            if (course.Photo == null || course.Photo.Length == 0)
            {
                ModelState.AddModelError("Photo", "Please select photo");
                return View();
            }

            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "This file is not image");
                return View();
            }

            if (!course.Photo.IsSizeAllowed(1024))
            {
                ModelState.AddModelError("Photo", "Size of image is more than 1 MB");
                return View();
            }

            var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, course.Photo);

            course.Image = fileName;
            course.IsDeleted = false;
            
            await _dbContext.Courses.AddAsync(course);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var course = await _dbContext.CourseList.Include(x => x.Couse).Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                return NotFound();

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null)
                return NotFound();

            var course = await _dbContext.CourseList.Include(x => x.Couse).Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                return NotFound();

            var path = Path.Combine(Constants.ImageFolderPath, course.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _dbContext.CourseList.Remove(course);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
