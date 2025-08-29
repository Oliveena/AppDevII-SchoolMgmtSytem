using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.People
{
    public class Student
    {
        public int StudentId { get; set; }

        public required string StudentNumber { get; set; }

        // Link to Identity user
        public required string ApplicationUserId { get; set; }
        public required ApplicationUser ApplicationUser { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
