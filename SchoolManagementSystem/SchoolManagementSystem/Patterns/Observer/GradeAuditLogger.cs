using SchoolManagementSystem.Models.Grades;

namespace SchoolManagementSystem.Patterns.Observer
{
    public class GradeAuditLogger : IGradeObserver
    {
        public void Update(Grade grade)
        {
            Console.WriteLine($"Audit: Grade {grade.GradeValue} logged at {DateTime.Now} for student {grade.EnrollmentId}");
        }
    }   
}
