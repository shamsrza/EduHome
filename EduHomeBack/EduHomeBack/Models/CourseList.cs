using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class CourseList
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public Course Couse { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        //[NotMapped]
        //public IFormFile Photo { get; set; }
    }

}
