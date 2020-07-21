using System.Threading.Tasks;
using KingICT.Academy.Contract;
using KingICT.Academy.Messaging.Course;
using Microsoft.AspNetCore.Mvc;

namespace KingICT.Academy.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseDto course)
        {
            CreateCourseRequest request = new CreateCourseRequest(course);
            await _courseService.Create(request);
            return RedirectToAction(nameof(Create));
        }
    }
}
