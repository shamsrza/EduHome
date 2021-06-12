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
        public async Task<IActionResult> Index()
        {
            
            var events = await _dbContext.EventList.OrderByDescending(x => x.TimeEnd.Date).Take(9).ToListAsync();

            return View(events);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            Event eventDetail = await _dbContext.Events.Include(x => x.EventList).Include(x => x.EventSpeakers).ThenInclude(x => x.Speaker).FirstOrDefaultAsync(x => x.EventListId == id);
            if (eventDetail == null)
                return NotFound();

            if (eventDetail == null)
                return NotFound();

            return View(eventDetail);
        }

    }
}
