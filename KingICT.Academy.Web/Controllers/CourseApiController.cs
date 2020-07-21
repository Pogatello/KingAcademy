using System.Collections.Generic;
using System.Threading.Tasks;
using KingICT.Academy.Contract;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Course;
using Microsoft.AspNetCore.Mvc;

namespace KingICT.Academy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseApiController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseApiController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IEnumerable<CourseDto>> GetAll()
        {
            GetCoursesResponse response = await _courseService.GetAll(new BasicRequest());
            return response.Courses;
        }
    }
}
