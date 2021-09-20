using System;
using Xunit;

namespace Assignment02.Tests {
    public class StudentTests {

        [Fact]
        public void testStudentGivenName() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal("Mikkel", student.GivenName);
        }

        [Fact]
        public void testStudentSurName() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal("Bech", student.Surname);
        }

        [Fact]
        public void testStudentStartDate() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(new DateTime(2010, 10, 10), student.StartDate);
        }

        [Fact]
        public void testStudentEndDate() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(new DateTime(2012, 10, 10), student.EndDate);
        }

        [Fact]
        public void testStudentGraduationDate() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(new DateTime(2013, 10, 10), student.GraduationDate);
        }

        [Fact]
        public void testStudentStatusNew() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2022, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(Assignment02.ClassLibrary.Student.StatusEnum.New, student.Status);
        }

        [Fact]
        public void testStudentStatusActive() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2022, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(Assignment02.ClassLibrary.Student.StatusEnum.Active, student.Status);
        }

        [Fact]
        public void testStudentStatusGraduated() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2020, 10, 10), new DateTime(2013, 10, 10));
            Assert.Equal(Assignment02.ClassLibrary.Student.StatusEnum.Graduated, student.Status);
        }

        [Fact]
        public void testStudentStatusDropOut() {
            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2020, 10, 10), new DateTime(2025, 10, 10));
            Assert.Equal(Assignment02.ClassLibrary.Student.StatusEnum.Dropout, student.Status);
        }
    }
}
