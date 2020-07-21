using System;

namespace KingICT.Academy.Messaging.Student
{
    public class StudentDto
    {


        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime BirthDate { get;  set; }


        public StudentDto()
        {


        }

        public StudentDto(string  firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

    }
}
