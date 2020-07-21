using System.Collections.Generic;
using KingICT.Academy.Infrastructure.Messaging;

namespace KingICT.Academy.Messaging.Course
{
    public class GetCoursesResponse : RequestBase
    {
        public IEnumerable<CourseDto> Courses { get; }

        public GetCoursesResponse(IEnumerable<CourseDto> courses)
        {
            Courses = courses;
        }
    }
}
