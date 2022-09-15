using System.ComponentModel.DataAnnotations;
namespace ThreeStarsandaSun.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string StoreName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string StoreAddress { get; set; }
        [Display(Name = "Contact Number")]
        [Required]
        public int StoreContactNumber { get; set; }
        [Display(Name = "City")]
        [Required]
        public int CityID { get; set; }
        public City City { get; set; }

    }
}
