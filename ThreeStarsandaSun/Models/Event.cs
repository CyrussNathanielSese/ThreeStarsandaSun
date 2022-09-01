using System;
using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string EventAddress { get; set; }
        [Required]
        [Display(Name = "Date and Time")]
        public DateTime DateTime  { get; set; }
        [Required]
        public string CityID { get; set; }
        public City City { get; set; }

    }
}
