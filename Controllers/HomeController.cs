using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Data.Models;
using StudentsManagement.Services.StudentServices;

namespace StudentsManagement.Controllers
{


	public class HomeController : Controller
	{
		private readonly IStudentService _studentService;

		public HomeController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		public async Task<IActionResult> Index()
		{
			//get all students
			IEnumerable<Student> students = await _studentService.GetAllStudents();
			return View(students);
		}


		[HttpPost]
		public async Task<IActionResult> Delete(int id) { 
			
			await _studentService.DeleteStudentById(id);
			
			return RedirectToAction("Index");
		}
	}
}
