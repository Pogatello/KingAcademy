using AutoMapper;
using KingICT.Academy.Messaging.Student;
using KingICT.Academy.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingICT.Academy.Service.Mapping
{
    public class StudentMappingProfile : Profile
    {


        public StudentMappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

            // CreateMap<Student, StudentDto>().ReverseMap; 

        }

    }
}
