using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string RestaurantName { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string RestaurantAddress { get; set; }

        [Display(Name =" Number")]
        public int RestaurantNum { get; set; }

        //[Required]
        //public City CityName { get; set; }
        //public City City { get; set; }



    }
}
