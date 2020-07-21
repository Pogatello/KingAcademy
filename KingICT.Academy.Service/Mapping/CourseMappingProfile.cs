using AutoMapper;
using KingICT.Academy.Messaging.Course;
using KingICT.Academy.Model;

namespace KingICT.Academy.Service.Mapping
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto, Course>();
        }
    }
}
