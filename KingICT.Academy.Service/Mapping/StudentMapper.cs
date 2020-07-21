using AutoMapper;
using KingICT.Academy.Messaging.Student;
using KingICT.Academy.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingICT.Academy.Service.Mapping
{
    public static class StudentMapper
    {


        public static StudentDto MapToDto(this Student source, IMapper mapper)
        {
            return mapper.Map<Student, StudentDto>(source);
        }

        public static IEnumerable<StudentDto> MapToDto(this IEnumerable<Student> source, IMapper mapper)
        {
            return mapper.Map<IEnumerable<Student>, IEnumerable<StudentDto>>(source);
        }

        public static Student MapToModel(this StudentDto source, IMapper mapper)
        {
            return mapper.Map<StudentDto, Student>(source);
        }


    }
}
