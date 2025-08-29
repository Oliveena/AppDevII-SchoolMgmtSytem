namespace SchoolManagementSystem.Patterns.Observer
{
    using Models.Grades;
    using System;

        public class GradeEmailNotifier : IGradeObserver
        {
            public void Update(Grade grade)
            {
                Console.WriteLine($"Email: Grade {grade.GradeValue} assigned to student {grade.EnrollmentId}");
            }
        }
    }
