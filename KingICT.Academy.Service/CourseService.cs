using System;
using System.Threading.Tasks;
using AutoMapper;
using KingICT.Academy.Contract;
using KingICT.Academy.Infrastructure.Messaging;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Course;
using KingICT.Academy.Model.Repositories;
using KingICT.Academy.Service.Mapping;

namespace KingICT.Academy.Service
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;

        public CourseService(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public async Task<BasicResponse> Create(CreateCourseRequest request)
        {
            var response = new BasicResponse { Status = Status.NotAuthorized };

            try
            {
                var course = request.Course.MapToModel(_mapper);
                await _courseRepository.Create(course);
                response.Status = Status.Ok;
            }
            catch (Exception ex)
            {
                response.Status = Status.InvalidData;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GetCoursesResponse> GetAll(BasicRequest request)
        {
            var courses = await _courseRepository.GetAll();
            var coursesDto = courses.MapToDto(_mapper);
            return new GetCoursesResponse(coursesDto);
        }
    }
}
