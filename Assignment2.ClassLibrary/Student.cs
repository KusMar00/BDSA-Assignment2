using System;

namespace Assignment2.ClassLibrary
{
    public class Student
    {

        public enum StatusEnum
        {
            New,
            Active,
            Dropout,
            Graduated
        }

        public int Id { get; init; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public StatusEnum Status { get; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(string givenName, string surName, DateTime start, DateTime end, DateTime graduation)
        {
            GivenName = givenName;
            SurName = surName;
            StartDate = start;
            EndDate = end;
            GraduationDate = graduation;

            if (DateTime.Now < StartDate)
            {
                Status = StatusEnum.New;
            }
            else if (StartDate < DateTime.Now && DateTime.Now < EndDate)
            {
                Status = StatusEnum.Active;
            }
            else if (DateTime.Now > GraduationDate)
            {
                Status = StatusEnum.Graduated;
            } else if(EndDate < GraduationDate){
                Status = StatusEnum.Dropout;
            }


        }

        public string toString()
        {
            string s = GivenName + " " + SurName + "\n" + "Id: " + Id + "\n" + "Startdate: " + StartDate + "\n" + "EndDate: " + EndDate + "\n" + "GraduationDate: " + GraduationDate;
            return s;
        }

        public void print()
        {
            Console.WriteLine(toString());
        }
    }
}
