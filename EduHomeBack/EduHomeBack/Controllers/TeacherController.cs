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
            var teachers = _dbContext.TeacherList.Include(x => x.TeacherPositions).ThenInclude(x => x.Position)
                                              .Include(x => x.SocialNetworks).ToList();
            return View(teachers);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var teacherDetail = await _dbContext.Teachers.Include(x => x.TeacherList).ThenInclude(x => x.SocialNetworks)
                .Include(x => x.TeacherList).ThenInclude(x => x.TeacherPositions).ThenInclude(x => x.Position).FirstOrDefaultAsync(x => x.TeacherListId == id);

            if (teacherDetail == null)
                return NotFound();

            return View(teacherDetail);
        }

        public IActionResult Search(string search)
        {
            if (search == null)
                return NotFound();

            var teachers = _dbContext.TeacherList.Include(x => x.TeacherPositions).ThenInclude(x => x.Position)
                                              .Include(x => x.SocialNetworks).Where(x => x.Fullname.Contains(search)).OrderByDescending(x => x.Id).ToList();

            return PartialView("_TeacherSearchPartial", teachers);

        }

    }
}
