using SchoolManagementSystem.Models.People;
using SchoolManagementSystem.Models.Roles;

namespace SchoolManagementSystem.Models.Users
{
    public class User : Person
    {
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
        public required Role Role { get; set; }
    }
}
