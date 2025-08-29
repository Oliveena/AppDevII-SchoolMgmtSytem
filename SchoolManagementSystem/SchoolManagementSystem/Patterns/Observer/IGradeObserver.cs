using SchoolManagementSystem.Models.Grades;

namespace SchoolManagementSystem.Patterns.Observer
{
   
    public interface IGradeObserver
    {
        void Update(Grade grade);
    }
}