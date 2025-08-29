using SchoolManagementSystem.Models.Grades;

namespace SchoolManagementSystem.Patterns.Interfaces
{

    public interface IGradeRepository
    {
        void Add(Grade grade);
        Grade? GetById(int id);
        IEnumerable<Grade> GetByStudent(int studentId);
        
        // do a method for GetClassAverage()

        // idem for GetClassMedian()
    }
}
