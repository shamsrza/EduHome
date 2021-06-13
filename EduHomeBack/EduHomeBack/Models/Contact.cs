using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstIcon { get; set; }
        public string FirstAddress { get; set; }
        public string SecondIcon { get; set; }
        public string SecondAddress { get; set; }
        public string ThirdIcon { get; set; }
        public string ThirdAddress { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
