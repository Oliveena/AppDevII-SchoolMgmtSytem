using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.People;
using SchoolManagementSystem.Repositories;

// structure to be improved, interfaces to implement appropriately

namespace SchoolManagementSystem.Services
{
    public class EnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public EnrollmentService(
            IEnrollmentRepository enrollmentRepository,
            IStudentRepository studentRepository,
            ICourseRepository courseRepository)
        {
            _enrollmentRepository = enrollmentRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public void EnrollStudent(int studentId, int courseId)
        {
            var student = _studentRepository.GetById(studentId);
            var course = _courseRepository.GetById(courseId);

            if (student != null && course != null)
            {
                var enrollment = new Enrollment
                {
                    Student = student,
                    Course = course,
                    EnrollmentDate = DateTime.Now
                };

                _enrollmentRepository.Add(enrollment);
            }
        }

        public void DropStudent(int enrollmentId)
        {
            var enrollment = _enrollmentRepository.GetById(enrollmentId);
            if (enrollment != null)
            {
                _enrollmentRepository.Remove(enrollment);
            }
        }
    }

    // TODO: move these placeholders to Repositories repo 
    public interface IEnrollmentRepository
    {
        object GetById(int enrollmentId);

        void Add(Enrollment enrollment);
        void Remove(object enrollment);
    }
    public interface IStudentRepository
    {
        Student GetById(int studentId);
    }
    public interface ICourseRepository
    {
        Course GetById(int courseId);
    }
}
