using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Models.People;
using SchoolManagementSystem.Models.Roles;

namespace SchoolManagementSystem.Models.Users
{
    public class ApplicationUser : IdentityUser
    {

        // fields previously located in "People" table
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNo { get; set; }

        // potenital to split of Adress into individual components, once MVP is done
        public string? Address { get; set; }

        // Email, Password, etc. are already included by Core Identity fields

        // FK to Role table
        //public required Role Role { get; set;
        public String? RoleId { get; set; }

        //// Optional reverse navigation
        //public Student? StudentProfile { get; set; }
        //public Teacher? TeacherProfile { get; set; }
        //public Administrator? AdministratorProfile { get; set; }
    }
}
