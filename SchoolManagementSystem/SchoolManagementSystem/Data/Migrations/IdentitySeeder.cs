using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Data.Migrations
{
    public static class IdentitySeeder
    {
        public static async Task SeedAsync(IServiceProvider sp)
        {
            var roleMgr = sp.GetRequiredService<RoleManager<IdentityRole>>();
            var userMgr = sp.GetRequiredService<UserManager<ApplicationUser>>();

            // 1) Ensure roles exist
            foreach (var roleName in new[] { "Administrator", "Teacher", "Student" })
            {
                if (!await roleMgr.RoleExistsAsync(roleName))
                {
                    await roleMgr.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}