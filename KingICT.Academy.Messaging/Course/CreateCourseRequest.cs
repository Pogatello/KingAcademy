using KingICT.Academy.Infrastructure.Messaging;

namespace KingICT.Academy.Messaging.Course
{
    public class CreateCourseRequest : RequestBase
    {
        public CourseDto Course { get; }

        public CreateCourseRequest(CourseDto course)
        {
            Course = course;
        }
    }
}
