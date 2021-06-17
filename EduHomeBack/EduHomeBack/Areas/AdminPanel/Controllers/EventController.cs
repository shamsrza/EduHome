using EduHomeBack.Areas.AdminPanel.Utils;
using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using EduHomeBack.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EventController : Controller
    {
        private readonly AppDbContext _dbContext;

        public EventController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var events = _dbContext.Events.Include(x => x.EventList).ToList();

            return View(events);
        }

        public IActionResult Create()
        {
            var categories = _dbContext.Categories.ToList();
            var speakers = _dbContext.Speakers.ToList();
            ViewBag.categories = categories;
            ViewBag.Speakers = speakers;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventList eventList, List<int?> speakersId, List<int?> categoriesId)
        {
            ViewBag.Speakers = _dbContext.Speakers.ToList();
            ViewBag.Categories = _dbContext.Categories.Where(x => x.IsDeleted == false).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (speakersId.Count == 0)
            {
                ModelState.AddModelError("", "Please select speaker");
                return View();
            }

            if (categoriesId.Count == 0)
            {
                ModelState.AddModelError("", "Please select Category");
                return View();
            }

            if (eventList.Event.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please select Photo");
                return View();
            }

            if (!eventList.Event.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Not the image you uploaded");
                return View();
            }

            if (!eventList.Event.Photo.IsSizeAllowed(1024))
            {
                ModelState.AddModelError("Photo", "Size of image is more than 1MB");
                return View();
            }

            //var fileName = await FileUtil.GenerateFileAsync(Constants.EventImageFolderPath, eventList.Event.Photo);
            //eventList.Event.Image = fileName;

            var eventSpeakers = new List<EventSpeaker>();

            await _dbContext.EventList.AddAsync(eventList);
            eventList.Event.EventListId = eventList.Id;
            foreach (int evsp in speakersId)
            {
                var eventSpiker = new EventSpeaker();
                eventSpiker.EventId = eventList.Id;
                eventSpiker.SpeakerId = evsp;
                eventSpeakers.Add(eventSpiker);
            }

            
            return RedirectToAction("Index");
        }
    }
}
