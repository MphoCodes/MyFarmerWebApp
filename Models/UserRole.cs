using System.ComponentModel.DataAnnotations;

namespace Agri_Connect_Platform.Models
{
    public class UserRole
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
