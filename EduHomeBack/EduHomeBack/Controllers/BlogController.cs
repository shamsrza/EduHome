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
    public class BlogController : Controller
    {
        private readonly AppDbContext _dbContext;

        public BlogController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_dbContext.BlogList.Count() / 9);
            ViewBag.Page = page;
            var courses = await _dbContext.BlogList.OrderByDescending(x => x.PublishDate).Skip((page - 1) * 9).Take(9).ToListAsync();
            if (ViewBag.PageCount < page)
                return NotFound();


            return View(courses);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var blogDetail = await _dbContext.Blogs.Where(x => x.IsDelete == false).Include(x => x.BlogList).OrderByDescending(x => x.PublishDate).FirstOrDefaultAsync(x => x.BlogListId == id);
            if (blogDetail == null)
                return NotFound();

            var blogViewModel = new BlogViewModel
            {
                BlogDetail = blogDetail,
                BlogList = _dbContext.BlogList.Where(x => x.IsDeleted == false).OrderByDescending(x => x.PublishDate).Take(3).ToList()
            };
            return View(blogViewModel);

        }

        public IActionResult Search(string search)
        {
            if (search == null)
                return NotFound();

            var blogs = _dbContext.BlogList.Where(x => x.Title.Contains(search)).Take(5).OrderByDescending(x => x.PublishDate).ToList();

            return PartialView("_BlogSearchPartial", blogs);

        }
    }
}
