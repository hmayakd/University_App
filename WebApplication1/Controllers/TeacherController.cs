using Microsoft.AspNetCore.Mvc;
using University_App.Models;
using University_App.Services;

namespace University_App.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher>? teachers = _teacherService.GetAll();
            return View(teachers);
        }
    }
}
