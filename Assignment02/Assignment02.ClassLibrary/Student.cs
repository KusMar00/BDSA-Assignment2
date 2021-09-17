using System;
namespace Assignment02.ClassLibrary {



    public class Student {

        public enum StatusEnum {
            New,
            Active,
            Dropout,
            Graduated
        }

        public int Id { get; init; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public StatusEnum Status {
            get {
                if (DateTime.Now < StartDate) {
                    // Hvis den nuværende dato er før Start Datoen
                    return StatusEnum.New;

                } else if (DateTime.Now > StartDate && DateTime.Now < EndDate) {
                    // Hvis den nuværende tidspunkt er efter start dato men før End date. 
                    return StatusEnum.Active;
                } else if (DateTime.Now > GraduationDate) {
                    // Hvis det nuværende tidspunkt er efter Graduation date.
                    return StatusEnum.Graduated;
                } else {
                    // Hvis end date er før graduation date.
                    return StatusEnum.Dropout;
                }
            }
        }

        public Student(string gn, string sn, DateTime sd, DateTime ed, DateTime gd) {
            GivenName = gn;
            Surname = sn;
            StartDate = sd;
            EndDate = ed;
            GraduationDate = gd;
            Console.WriteLine("New student!");
        }

        public string toString() {
            return $"{GivenName} {Surname} ({Status}) | {StartDate} - {EndDate} [{GraduationDate}]";
        }
    }
}
