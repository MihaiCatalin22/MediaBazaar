using DAL;
using Logic.Classes;
using Logic.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
	public class VacationModel : PageModel
	{
		
		[BindProperty]
		public DateTime StartDate { get; set; }

		[BindProperty]
		public DateTime EndDate { get; set; }

		[BindProperty]
		public string Reason { get; set; }


		private VacationController vacationController = new(new DALVacationController());
		private EmployeeController employeeController = new(new DALEmployeeController());
		private Employee loggedInEmployee = null;

		public void OnGet()
		{
			string username = HttpContext.Session.GetString("username");

			loggedInEmployee = employeeController.Get(username);

			StartDate = DateTime.Today;
			EndDate = DateTime.Today;
		}

		public IActionResult OnPost()
		{
			string username = HttpContext.Session.GetString("username");

			loggedInEmployee = employeeController.Get(username);

			if (StartDate.Date < DateTime.Today || EndDate.Date < DateTime.Today)
			{
				return Page();
			}
			else
			{
				Vacation vacation = new Vacation(loggedInEmployee, DateOnly.FromDateTime(StartDate), DateOnly.FromDateTime(EndDate), Reason);

				if (vacationController.Create(vacation))
					return RedirectToPage("Index");
				else
					return Page();
			}
		}
	}
}
