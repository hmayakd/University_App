using Microsoft.AspNetCore.Mvc;
using University_App.Models;
using University_App.Services;

namespace University_App.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            IEnumerable<Student>? students = _studentService.GetAll();
            return View(students);
        }
    }
}
