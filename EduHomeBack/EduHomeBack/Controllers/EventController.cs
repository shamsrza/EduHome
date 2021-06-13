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
    public class EventController : Controller
    {
        private readonly AppDbContext _dbContext;

        public EventController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index(int? categoryId)
        {
            if (categoryId == null)
            {
                var events = await _dbContext.EventList.OrderByDescending(x => x.TimeEnd.Date).Take(9).ToListAsync();
                return View(events);
            }
            else
            {
                var events = await _dbContext.EventList.Where(x => x.CategoryId == categoryId).ToListAsync();
                return View(events);
            }     
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var eventDetail = await _dbContext.Events.Include(x => x.EventList).Include(x => x.EventSpeakers).ThenInclude(x => x.Speaker).FirstOrDefaultAsync(x => x.EventListId == id);
            var categories = _dbContext.Categories.Where(x => x.IsDeleted == false).Include(x => x.EventLists.Where(x => x.IsDeleted == false)).ToList();
            if (eventDetail == null)
                return NotFound();

            var eventViewModel = new EventViewModel
            {
                Categories = categories,
                Event = eventDetail,
                BlogList = _dbContext.BlogList.Where(x => x.IsDeleted == false).OrderByDescending(x => x.PublishDate).Take(3).ToList()
            };

            return View(eventViewModel);
        }

        public IActionResult Search(string search)
        {
            if (search == null)
                return NotFound();

            var events = _dbContext.EventList.Where(x => x.Name.Contains(search)).Take(5).OrderByDescending(x => x.Event.TimeStart).ToList();

            return PartialView("_EventSearchPartial", events);

        }

    }
}
