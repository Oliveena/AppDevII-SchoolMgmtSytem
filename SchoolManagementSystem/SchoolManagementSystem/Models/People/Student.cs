using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.Users;
using System.Diagnostics;

namespace SchoolManagementSystem.Models.People
{
    public class Student : User
    {
        required public string StudentNumber { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
