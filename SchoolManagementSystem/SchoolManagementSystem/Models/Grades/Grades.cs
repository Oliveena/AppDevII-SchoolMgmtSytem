using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.Grades
{
    public class Grade
    {
        public int GradeId { get; set; }

        public int EnrollmentId { get; set; }
        required  public Enrollment Enrollment { get; set; }

        public int AssignedByUserId { get; set; }
        required public User AssignedByUser { get; set; }

        public int GradeValue { get; set; }  

        public bool IsPassing() => GradeValue >= 60;

        public DateTime DateRecorded { get; set; }
    }

}
