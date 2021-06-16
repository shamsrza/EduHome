using EduHomeBack.Areas.AdminPanel.Data;
using EduHomeBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.DataAccessLayer
{
    public class DataInitializer 
    {
        
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;

        public DataInitializer(AppDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
           _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedDataAsync()
        {
           await _dbContext.Database.MigrateAsync();

            #region Role Seed
            var roles = new List<string> {
                RoleConstants.AdminRole,
                RoleConstants.CourseModerator,
                RoleConstants.User
            };
            foreach (var role in roles)
            {
                if (await _roleManager.RoleExistsAsync(role))
                    continue;

                await _roleManager.CreateAsync(new IdentityRole(role));
            }
            #endregion

            #region User Seed

            var user1 = new User()
            {
                Email = "admin@code.az",
                UserName = "Admin",
                Fullname = "Admin Admin",
            };

            if (await _userManager.FindByEmailAsync(user1.Email) == null)
            {
                await _userManager.CreateAsync(user1, "Admin@123");
                await _userManager.AddToRoleAsync(user1, RoleConstants.AdminRole);
            }

            var user2 = new User()
            {
                Email = "moderator@code.az",
                UserName = "Moderator",
                Fullname = "Moderator Moderator",
            };

            if (await _userManager.FindByEmailAsync(user2.Email) == null)
            {
                await _userManager.CreateAsync(user2, "Moderator@123");
                await _userManager.AddToRoleAsync(user2, RoleConstants.CourseModerator);
            }

            #endregion
        }

    }
}
