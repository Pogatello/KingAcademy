using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KingICT.Academy.Contract;
using KingICT.Academy.Messaging.Student;
using Microsoft.AspNetCore.Mvc;

namespace KingICT.Academy.Web.Controllers
{
    public class StudentController : Controller
    {


        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentDto student)
        {
            var request = new CreateStudentRequest();
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