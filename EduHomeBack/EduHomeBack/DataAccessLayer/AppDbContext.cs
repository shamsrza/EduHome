using EduHomeBack.Models;
using EduHomeBack.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<HomeAbout> HomeAbout { get; set; }
        public DbSet<HomeCourseOffers> HomeCourseOffers { get; set; }
        public DbSet<HomeVideoTour> HomeVideoTour { get; set; }
        public DbSet<HomeNoticeBoard> HomeNoticeBoard { get; set; }
        public DbSet<HomeEventArea> HomeEventArea { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<HomeBlogArea> HomeBlogArea { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TeacherPosition> TeacherPositions { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseList> CourseList { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventList> EventList { get; set; }
    }
}
