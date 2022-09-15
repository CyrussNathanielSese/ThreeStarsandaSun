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

        [Display(Name = "Number")]
        public int RestaurantNum { get; set; }

        [Display(Name = "City")]
        [Required]
        public int CityID { get; set; }
        [Required]
        public City City { get; set; }



    }
}
