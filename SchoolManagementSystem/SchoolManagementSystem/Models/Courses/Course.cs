using SchoolManagementSystem.Models.People;

namespace SchoolManagementSystem.Models.Courses
{
    public class Course
    {
        required public int CourseId { get; set; }

        required public int TeacherId { get; set; }
        required public string CourseTitle { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Computed list of all class dates
        public ICollection<DateTime> ScheduledClassDates { get; set; } = new List<DateTime>();

        // Navigation properties
        public Teacher Teacher { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
