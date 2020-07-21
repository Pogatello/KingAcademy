using System.Collections.Generic;

namespace KingICT.Academy.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; private set; }


        public ICollection<StudentCourse> StudentCourses { get; set; }
        private Course()
        {
        }

        public Course(string name)
        {
            Name = name;
        }
    }
}
