using EduHomeBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public BlogViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? take, int skip)
        {
            if (take == null)
            {
                var blog = await _dbContext.BlogList.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id).ToListAsync();
                return View(blog);
            }
            else
            {
                var blog = await _dbContext.BlogList.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id).Skip((skip - 1) * 6).Take((int)take).ToListAsync();
                return View(blog);
            }
        }
    }
}
