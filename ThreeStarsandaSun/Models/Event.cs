using System;
using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Display(Name = "Event Name")]
        [Required]
        public string EventName { get; set; }
        [Display(Name = "Location")]
        [Required]
        public string EventAddress { get; set; }
        [Display(Name = "Date and Time")]
        [Required]
        public DateTime EventDateTime { get; set; }
        public string CityName { get; set; }
        public  City City { get; set; }

    }
}
