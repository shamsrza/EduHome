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
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public SubscribeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Subscribe(Subscriber subscriber)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var isExist = await _dbContext.Subscribers.AnyAsync(x => x.Email.ToLower() == subscriber.Email.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Email", "This email is already subscribed");
                return View();
            }
            else
            {
                await _dbContext.Subscribers.AddAsync(subscriber);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
