using System;
using System.Collections;
using System.Collections.Generic;

namespace KingICT.Academy.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }


        public ICollection<StudentCourse> StudentCourses { get; set; }

        private Student()
        {

        }

        public Student(string firstName, string lastName, DateTime birthDate, ICollection<StudentCourse> studentCourses)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;

            StudentCourses = studentCourses;
        }

    }
}
