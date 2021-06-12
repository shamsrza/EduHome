using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Image{ get; set; }
        public string Name{ get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string VenuePlace { get; set; }
        public string VenueCity { get; set; }
        public string Description{ get; set; }

        [ForeignKey("EventList")]
        public int EventListId { get; set; }
        public EventList EventList { get; set; }
    }
}
