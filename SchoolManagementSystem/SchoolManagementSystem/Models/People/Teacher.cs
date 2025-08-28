using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.People
{
    public class Teacher : User
    {
        public string TeachingStaffNumber { get; set; }

        // Navigation properties
        public ICollection<Course> CoursesTaught { get; set; }
    }

}
