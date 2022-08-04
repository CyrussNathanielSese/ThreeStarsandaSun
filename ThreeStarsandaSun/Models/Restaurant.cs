using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string RestoName { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string RestoAddress { get; set; }

        [Display(Name ="Contact Number")]
        public int RestoContactNumber { get; set; }

        



    }
}