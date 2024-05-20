namespace Agri_Connect_Platform.Models
{
    public class UserRoleMapping
    {
        public int Id { get; set; }

        public int UserID { get; set; }
        public int RoleID { get; set; }

        public Farmer Farmer { get; set; }
        public UserRole Role { get; set; }
    }
}
