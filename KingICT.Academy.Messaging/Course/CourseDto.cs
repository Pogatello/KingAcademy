using KingICT.Academy.Model;
using System.Collections.Generic;

namespace KingICT.Academy.Messaging.Course
{
    public class CourseDto
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

        public CourseDto()
        {
        }

        public CourseDto(string name, ICollection<StudentCourse> studentCourses)
        {
            Name = name;
            StudentCourses = studentCourses;
        }
    }
}
