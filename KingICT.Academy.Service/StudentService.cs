using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KingICT.Academy.Contract;
using KingICT.Academy.Infrastructure.Messaging;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Course;
using KingICT.Academy.Messaging.Student;
using KingICT.Academy.Model;
using KingICT.Academy.Model.Repositories;
using KingICT.Academy.Service.Mapping;

namespace KingICT.Academy.Service
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

            public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }




        public async Task<BasicResponse> Create(CreateStudentRequest request)
        {
            var response = new BasicResponse { Status = Status.NotAuthorized };
            try
            {
                var student = request.Student.MapToModel(_mapper);
             await _studentRepository.Create(student);

                response.Status = Status.Ok;

            }
            catch (Exception ex)
            {
                response.Status = Status.InvalidData;
                response.Message = ex.Message;

            }
            return response;
        }

       

        public async Task<GetStudentsResponse> GetStudents()
        {
            var response = new GetStudentsResponse { Status = Status.NotAuthorized };

            try
            {
                var students = await _studentRepository.GetStudents();
                var studentsDto = students.MapToDto(_mapper);

                response.Status = Status.Ok;
                response.Students = studentsDto;
            }
            catch(Exception ex)
            {
                response.Status = Status.InvalidData;
                response.Message = ex.Message;

            }

            return response;
        }
    }
}
