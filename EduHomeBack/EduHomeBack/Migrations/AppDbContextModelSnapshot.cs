﻿// <auto-generated />
using System;
using EduHomeBack.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduHomeBack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduHomeBack.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("EduHomeBack.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlogListId")
                        .HasColumnType("int");

                    b.Property<int>("Comment")
                        .HasColumnType("int");

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BlogListId")
                        .IsUnique();

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EduHomeBack.Models.BlogList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Comment")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("BlogList");
                });

            modelBuilder.Entity("EduHomeBack.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EduHomeBack.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assesments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CourseFee")
                        .HasColumnType("float");

                    b.Property<int>("CourseListId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Starts")
                        .HasColumnType("datetime2");

                    b.Property<int>("Students")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseListId")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EduHomeBack.Models.CourseList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CourseList");
                });

            modelBuilder.Entity("EduHomeBack.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventListId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("VenueCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenuePlace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventListId")
                        .IsUnique();

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EduHomeBack.Models.EventList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("VenueCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventList");
                });

            modelBuilder.Entity("EduHomeBack.Models.EventSpeaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("SpeakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventSpeakers");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeAbout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeAbout");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeBlogArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommentsCount")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeBlogArea");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeCourseOffers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeCourseOffers");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeEventArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeEventArea");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeNoticeBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeNoticeBoard");
                });

            modelBuilder.Entity("EduHomeBack.Models.HomeVideoTour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomeVideoTour");
                });

            modelBuilder.Entity("EduHomeBack.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("EduHomeBack.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EduHomeBack.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("EduHomeBack.Models.SliderImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SliderImages");
                });

            modelBuilder.Entity("EduHomeBack.Models.SocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherListId");

                    b.ToTable("SocialNetworks");
                });

            modelBuilder.Entity("EduHomeBack.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("EduHomeBack.Models.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("EduHomeBack.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Communication")
                        .HasColumnType("int");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Design")
                        .HasColumnType("int");

                    b.Property<int>("Development")
                        .HasColumnType("int");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Innovation")
                        .HasColumnType("int");

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherListId")
                        .HasColumnType("int");

                    b.Property<int>("TeamLeader")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherListId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EduHomeBack.Models.TeacherList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TeacherList");
                });

            modelBuilder.Entity("EduHomeBack.Models.TeacherPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeacherListId");

                    b.ToTable("TeacherPositions");
                });

            modelBuilder.Entity("EduHomeBack.Models.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("EduHomeBack.Models.Blog", b =>
                {
                    b.HasOne("EduHomeBack.Models.BlogList", "BlogList")
                        .WithOne("Blog")
                        .HasForeignKey("EduHomeBack.Models.Blog", "BlogListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogList");
                });

            modelBuilder.Entity("EduHomeBack.Models.BlogList", b =>
                {
                    b.HasOne("EduHomeBack.Models.Category", "Category")
                        .WithMany("BlogLists")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EduHomeBack.Models.Course", b =>
                {
                    b.HasOne("EduHomeBack.Models.CourseList", "CourseList")
                        .WithOne("Couse")
                        .HasForeignKey("EduHomeBack.Models.Course", "CourseListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseList");
                });

            modelBuilder.Entity("EduHomeBack.Models.CourseList", b =>
                {
                    b.HasOne("EduHomeBack.Models.Category", "Category")
                        .WithMany("CourseLists")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EduHomeBack.Models.Event", b =>
                {
                    b.HasOne("EduHomeBack.Models.EventList", "EventList")
                        .WithOne("Event")
                        .HasForeignKey("EduHomeBack.Models.Event", "EventListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventList");
                });

            modelBuilder.Entity("EduHomeBack.Models.EventList", b =>
                {
                    b.HasOne("EduHomeBack.Models.Category", "Category")
                        .WithMany("EventLists")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EduHomeBack.Models.EventSpeaker", b =>
                {
                    b.HasOne("EduHomeBack.Models.Event", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduHomeBack.Models.Speaker", "Speaker")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("EduHomeBack.Models.SocialNetwork", b =>
                {
                    b.HasOne("EduHomeBack.Models.TeacherList", "TeacherList")
                        .WithMany("SocialNetworks")
                        .HasForeignKey("TeacherListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherList");
                });

            modelBuilder.Entity("EduHomeBack.Models.Teacher", b =>
                {
                    b.HasOne("EduHomeBack.Models.TeacherList", "TeacherList")
                        .WithOne("Teacher")
                        .HasForeignKey("EduHomeBack.Models.Teacher", "TeacherListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherList");
                });

            modelBuilder.Entity("EduHomeBack.Models.TeacherPosition", b =>
                {
                    b.HasOne("EduHomeBack.Models.Position", "Position")
                        .WithMany("TeacherPositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduHomeBack.Models.TeacherList", "TeacherList")
                        .WithMany("TeacherPositions")
                        .HasForeignKey("TeacherListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("TeacherList");
                });

            modelBuilder.Entity("EduHomeBack.Models.BlogList", b =>
                {
                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EduHomeBack.Models.Category", b =>
                {
                    b.Navigation("BlogLists");

                    b.Navigation("CourseLists");

                    b.Navigation("EventLists");
                });

            modelBuilder.Entity("EduHomeBack.Models.CourseList", b =>
                {
                    b.Navigation("Couse");
                });

            modelBuilder.Entity("EduHomeBack.Models.Event", b =>
                {
                    b.Navigation("EventSpeakers");
                });

            modelBuilder.Entity("EduHomeBack.Models.EventList", b =>
                {
                    b.Navigation("Event");
                });

            modelBuilder.Entity("EduHomeBack.Models.Position", b =>
                {
                    b.Navigation("TeacherPositions");
                });

            modelBuilder.Entity("EduHomeBack.Models.Speaker", b =>
                {
                    b.Navigation("EventSpeakers");
                });

            modelBuilder.Entity("EduHomeBack.Models.TeacherList", b =>
                {
                    b.Navigation("SocialNetworks");

                    b.Navigation("Teacher");

                    b.Navigation("TeacherPositions");
                });
#pragma warning restore 612, 618
        }
    }
}
