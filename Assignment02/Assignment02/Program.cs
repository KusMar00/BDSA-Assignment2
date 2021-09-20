using System;

namespace Assignment02 {
    class Program {
        static void Main(string[] args) {

            var student = new Assignment02.ClassLibrary.Student("Mikkel", "Bech", new DateTime(2010, 10, 10), new DateTime(2012, 10, 10), new DateTime(2013, 10, 10));

            Console.WriteLine(student.toString());

            var studentTwo = new Assignment02.ClassLibrary.ImmutableStudent() {
                Id = 10,
                EndDate = new DateTime(2010, 10, 10),
                GivenName = "Mikkel",
                Surname = "Bech",
                GraduationDate = new DateTime(2020, 10, 10),
                StartDate = new DateTime(2008, 10, 10)
            };

            Console.WriteLine(studentTwo.ToString());


            Console.WriteLine("Hello World!");
        }
    }
}
