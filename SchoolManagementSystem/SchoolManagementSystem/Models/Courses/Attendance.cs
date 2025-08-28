using SchoolManagementSystem.Models.People;

namespace SchoolManagementSystem.Models.Courses
{
    public class Attendance
    {
        public int AttendanceId { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int courseId { get; set; }
        public Course Course { get; set; }

        public DateTime Date { get; set; }

        public AttendanceStatus Status{ get; set; }

        public string Comment {  get; set; }
    }

    public enum AttendanceStatus
    {
        Present,
        Absent,
        LeftEarly,
        Excused
    }
}
