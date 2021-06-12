using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class EventList
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string VenueCity { get; set; }
        public Event Event { get; set; }
    }
}
