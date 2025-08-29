using System;
using Xunit;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Tests
{
    public class GradeTests
    {
        [Theory]
        [InlineData(90, true)]
        [InlineData(60, true)]
        [InlineData(59, false)]
        [InlineData(0, false)]
        public void IsPassing_ReturnsExpectedResult(int gradeValue, bool expected)
        {
            // Arrange
            var grade = new Grade
            {
                GradeValue = gradeValue,
                DateAssigned = DateTime.Now,
                Enrollment = new Enrollment(),
                AssignedByUser = new ApplicationUser()
            };

            // Act
            var result = grade.IsPassing();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
