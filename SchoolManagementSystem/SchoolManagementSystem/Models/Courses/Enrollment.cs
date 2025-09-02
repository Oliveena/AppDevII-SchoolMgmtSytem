using SchoolManagementSystem.Models.People;

namespace SchoolManagementSystem.Models.Courses
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        required public Course Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}