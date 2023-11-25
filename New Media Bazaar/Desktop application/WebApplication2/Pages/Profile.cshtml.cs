using DAL;
using Logic.Classes;
using Logic.Controllers;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class ProfileModel : PageModel
	{
       
    [BindProperty]
		public UpdateEmployeeViewModel UpdateInfo { get; set; }

		public Employee _loggedInEmployee;
		private EmployeeController _employeeController;

		public ProfileModel()
		{
			_employeeController = new(new DALEmployeeController());
		}

		public void OnGet()
		{
			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
			}
		}

		public IActionResult OnPost()
		{
			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

				if (_loggedInEmployee != null)
				{
					_loggedInEmployee.Email = UpdateInfo.Email;
					_loggedInEmployee.Phone = UpdateInfo.Phone;
					_loggedInEmployee.Password = UpdateInfo.Password;

					bool updateResult = _employeeController.UpdateEmployee(_loggedInEmployee);

					if (updateResult)
					{
						return RedirectToPage("/Profile");
					}
				}
			}
			return Page();
		}
	}
}

