using System;
using Xunit;

namespace Assignment02.Tests {
    public class ImmutableStudentTests {


        [Fact]
        public void testImmutableStudentObjectsEqual() {

            var studentOne = new Assignment02.ClassLibrary.ImmutableStudent() {
                Id = 10,
                EndDate = new DateTime(2010, 10, 10),
                GivenName = "Mikkel",
                Surname = "Bech",
                GraduationDate = new DateTime(2020, 10, 10),
                StartDate = new DateTime(2008, 10, 10)
            };

            var studentTwo = new Assignment02.ClassLibrary.ImmutableStudent() {
                Id = 10,
                EndDate = new DateTime(2010, 10, 10),
                GivenName = "Mikkel",
                Surname = "Bech",
                GraduationDate = new DateTime(2020, 10, 10),
                StartDate = new DateTime(2008, 10, 10)
            };


            Assert.True(studentOne == studentTwo);
        }

        [Fact]
        public void testImmutableStudentToStringEqual() {

            var studentOne = new Assignment02.ClassLibrary.ImmutableStudent() {
                Id = 10,
                EndDate = new DateTime(2010, 10, 10),
                GivenName = "Mikkel",
                Surname = "Bech",
                GraduationDate = new DateTime(2020, 10, 10),
                StartDate = new DateTime(2008, 10, 10)
            };

            var studentTwo = new Assignment02.ClassLibrary.ImmutableStudent() {
                Id = 10,
                EndDate = new DateTime(2010, 10, 10),
                GivenName = "Mikkel",
                Surname = "Bech",
                GraduationDate = new DateTime(2020, 10, 10),
                StartDate = new DateTime(2008, 10, 10)
            };

            Assert.Equal(studentOne.ToString(), studentTwo.ToString());
        }
    }
}
