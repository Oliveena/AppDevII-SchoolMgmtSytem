using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.People
{
    public class Administrator : User
    {
        required public string AdministrationStaffNumber { get; set; }

        // Optional: Roles or permissions collection for refining controls 
        // public ICollection<Role> Roles { get; set; }
    }

}
