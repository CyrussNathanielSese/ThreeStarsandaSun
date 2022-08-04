using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        [Display(Name = "Store Name")]
        [Required]
        public string StoreName { get; set; }
        [Display(Name = "Store Address")]
        [Required]
        public string StoreAddress { get; set; }
        [Display(Name = "Contact Number")]
        public int StoreContactNumber { get; set; }

    }
}
