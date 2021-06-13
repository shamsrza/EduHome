using EduHomeBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewComponents
{
    public class TeacherViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public TeacherViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var teachers = await _dbContext.TeacherList.Include(x => x.TeacherPositions).ThenInclude(x => x.Position)
                                              .Include(x => x.SocialNetworks).Take(count).ToListAsync();

            return View(teachers);
        }
    }
}
