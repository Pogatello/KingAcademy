using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KingICT.Academy.Contract;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Course;
using KingICT.Academy.Messaging.Student;
using Microsoft.AspNetCore.Mvc;

namespace KingICT.Academy.Web.Controllers
{
    public class StudentController : Controller
    {


        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;

        public StudentController(IStudentService studentService, ICourseService courseService)
        {
            _studentService = studentService;
            _courseService = courseService;
        }


        public async Task<IActionResult> CreateStudent()
        {
            


            GetCoursesResponse response = await _courseService.GetAll(new BasicRequest());

            ViewBag.AllCourses = response.Courses;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentDto student, List<string> selectedCourses)
        {
            var request = new CreateStudentRequest();

          /*  foreach(var id in selectedCourses)
            {
                student.StudentCourses.Add());
            }
            */
            


            request.Student = student;

            



           await _studentService.Create(request);

            return RedirectToAction(nameof(GetStudents));
        }


        public async Task<ViewResult> GetStudents()
        {
            var response = await _studentService.GetStudents();




            return View(response.Students);
           

        }







    }
}