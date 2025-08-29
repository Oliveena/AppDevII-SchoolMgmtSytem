using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Patterns.Interfaces;
using SchoolManagementSystem.Patterns.Observer;

using SchoolManagementSystem.Repositories;

namespace SchoolManagementSystem.Services
{
    public class GradebookService
    {
        private readonly IGradeRepository _gradeRepository;
        private readonly GradeSubject _gradeSubject;

        public GradebookService(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
            _gradeSubject = new GradeSubject();

            // Attach observers
            _gradeSubject.Attach(new GradeEmailNotifier());
            _gradeSubject.Attach(new GradeAuditLogger());
        }

        public void AssignGrade(int enrollementId, int gradeValue)
        {
            var grade = new Grade
            {
                EnrollmentId = enrollementId,
                GradeValue = gradeValue,
                DateAssigned = DateTime.Now
            };

            _gradeRepository.Add(grade);

            // Notify observers
            _gradeSubject.Notify(grade);
        }
    }
}
