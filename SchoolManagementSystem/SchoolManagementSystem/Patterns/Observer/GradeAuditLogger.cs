using SchoolManagementSystem.Models.Grades;

namespace SchoolManagementSystem.Patterns.Observer
{
    public class GradeAuditLogger : IGradeObserver
    {
        // method for updating the grade 
        public void Update(Grade grade)
        {
            Console.WriteLine($"Audit: Grade {grade.GradeValue} logged at {DateTime.Now} for student with EnrollmentID: {grade.EnrollmentId}");
        }
    }   
}