using System.Collections.Generic;
using AutoMapper;
using KingICT.Academy.Messaging.Course;
using KingICT.Academy.Model;

namespace KingICT.Academy.Service.Mapping
{
    public static class CourseMapper
    {
        public static CourseDto MapToDto(this Course source, IMapper mapper)
        {
            return mapper.Map<Course, CourseDto>(source);
        }

        public static IEnumerable<CourseDto> MapToDto(this IEnumerable<Course> source, IMapper mapper)
        {
            return mapper.Map<IEnumerable<Course>, IEnumerable<CourseDto>>(source);
        }

        public static Course MapToModel(this CourseDto source, IMapper mapper)
        {
            return mapper.Map<CourseDto, Course>(source);
        }
    }
}
