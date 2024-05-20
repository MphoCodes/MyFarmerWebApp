using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Agri_Connect_Platform.Models;
using Microsoft.AspNetCore.Identity; // Make sure to import the namespace where your entity models are located

namespace Agri_Connect_Platform.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserRole> UserRole { get; set; } // Fixed the DbSet name
        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }
        public DbSet<Employee> Employees { get; set; } // Simplified DbSet declaration
    }
}
