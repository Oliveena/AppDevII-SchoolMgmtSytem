using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Data
{
    // For Identity
    public class SecureDbContext : IdentityDbContext<ApplicationUser>
    {
        public SecureDbContext(DbContextOptions<SecureDbContext> options)
            : base(options)
        {
        }
    }
}