using System;
namespace Assignment02.ClassLibrary {
    public record ImmutableStudent {

        public enum StatusEnum {
            New,
            Active,
            Dropout,
            Graduated
        }

        public int Id { get; init; }
        public string GivenName { get; init; }
        public string Surname { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }
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

    }
}
