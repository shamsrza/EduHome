using EduHomeBack.Models;
using EduHomeBack.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<User>
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
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherList> TeacherList { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TeacherPosition> TeacherPositions { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseList> CourseList { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventList> EventList { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogList> BlogList { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
    }
}
