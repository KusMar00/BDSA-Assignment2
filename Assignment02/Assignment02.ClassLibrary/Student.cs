using System;
namespace Assignment02.ClassLibrary {



    public class Student {

        public enum StatusEnum {
            New,
            Active,
            Dropout,
            Graduated
        }

        public int Id { get; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public StatusEnum Status { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student() {
            Console.WriteLine("New student!");
        }
    }
}
