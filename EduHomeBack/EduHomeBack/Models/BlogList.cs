using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class BlogList
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Author{ get; set; }
        public DateTime PublishDate{ get; set; }
        public int Comment{ get; set; }

        [Required, MaxLength(100)]
        public string Title{ get; set; }
        [Required]
        public bool IsDeleted{ get; set; }
        public Blog Blog { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
