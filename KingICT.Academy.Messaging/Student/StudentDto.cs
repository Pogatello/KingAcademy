using KingICT.Academy.Model;
using System;
using System.Collections.Generic;

namespace KingICT.Academy.Messaging.Student
{
    public class StudentDto
    {


        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime BirthDate { get;  set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

        public StudentDto()
        {


        }

        public StudentDto(string  firstName, string lastName, DateTime birthDate, ICollection<StudentCourse> studentCourses)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            StudentCourses = studentCourses;
        }

    }
}
