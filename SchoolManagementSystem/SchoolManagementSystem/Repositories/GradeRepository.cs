using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Patterns.Interfaces;

namespace SchoolManagementSystem.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly SchoolDbContext _context;

        public GradeRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void Add(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
        }

        public Grade? GetById(int id)
        {
            return _context.Grades.Find(id);
        }

        public IEnumerable<Grade> GetByStudent(int studentId)
        {
            return _context.Grades
                .Include(g => g.Enrollment)
                    .ThenInclude(e => e.Student)
                .Where(g => g.Enrollment.Student.StudentId == studentId)
                .ToList();
        }
    }

}
