using System.ComponentModel.DataAnnotations;

namespace Agri_Connect_Platform.Models
{
    public class Farmer
    {
        public int FarmerID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
