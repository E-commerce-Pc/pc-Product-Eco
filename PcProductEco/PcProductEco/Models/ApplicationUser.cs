using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PcProductEco.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters")]
        public string FullName { get; set; }

        //public ICollection<order>? Orders { get; set; }
        //public ICollection<Review>? Reviews { get; set; }
        //public Cart? Cart { get; set; }
        //public WishList? WishList { get; set; }

    }
}
