using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.People
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public required string TeachingStaffNumber { get; set; }

        // Link to Identity user
        public required string ApplicationUserId { get; set; }
        //public required ApplicationUser ApplicationUser { get; set; }

        // Navigation properties
        public ICollection<Course> CoursesTaught { get; set; } = new List<Course>();
    }
}
