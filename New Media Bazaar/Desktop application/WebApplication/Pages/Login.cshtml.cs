using DAL;
using Logic.Classes;
using Logic.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class LoginModel : PageModel
    {
		[BindProperty]
		public Employee employee { get; set; }

		private EmployeeController _employeeController;
		public LoginModel()
		{
			_employeeController = new(new DALEmployeeController());
		}

		public IActionResult OnPost()
		{
			if (_employeeController.Login(employee.Username, employee.Password) != null)
			{
				HttpContext.Session.SetString("username", employee.Username);

				return RedirectToPage("Index");
			}
			else
			{
				string message = "Invalid login, please try again";
				ViewData["Message"] = message;
			}
			return null;
		}
	}
}
