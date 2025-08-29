using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.Grades
{
    public class Grade
    {
        public int GradeId { get; set; }

        public int EnrollmentId { get; set; }
         public Enrollment Enrollment { get; set; }

        public int AssignedByUserId { get; set; }
        public ApplicationUser AssignedByUser { get; set; }

        public int GradeValue { get; set; }  

        public bool IsPassing() => GradeValue >= 60;

        public DateTime DateAssigned{ get; set; }
    }

}
