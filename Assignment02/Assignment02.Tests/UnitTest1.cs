using System;
using Xunit;

namespace Assignment02.Tests {
    public class UnitTest1 {
        [Fact]
        public void testNewStudent() {

            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10)) { Id = 10 };


            Console.WriteLine(student);

        }
    }
}
