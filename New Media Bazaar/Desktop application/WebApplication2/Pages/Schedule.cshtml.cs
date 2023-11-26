using Logic.Classes;
using Logic.Controllers;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;
using Logic.Interfaces;

namespace WebApplication2.Pages
{
    public class ScheduleModel : PageModel
    {
		public Employee _loggedInEmployee;
		public Shift[] _assignedShifts;
		private readonly EmployeeController employeeController = new EmployeeController(new DALEmployeeController());
		private readonly ShiftController shiftController = new ShiftController(new DALShiftController());
		public List<string> WeekDays { get; set; } = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
		public DateTime CurrentDate { get; set; } = DateTime.Today;
		public DateTime NewDate { get; set; }

		private static int counter = 0;



		public IActionResult OnGet()
        {
            counter = 0;
            NewDate = CurrentDate;

            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
            }
            _assignedShifts = shiftController.GetAllAssigned(_loggedInEmployee);

            return Page();
		}
		public void OnPostPreviousWeek()
		{
			counter--;
			NewDate = CurrentDate.AddDays(counter * 7);
			CurrentDate = NewDate;

			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
			}
			_assignedShifts = shiftController.GetAllAssigned(_loggedInEmployee);

		}

		public void OnPostCurrentWeek()
		{
			counter = 0;
			NewDate = CurrentDate;

			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
			}
			_assignedShifts = shiftController.GetAllAssigned(_loggedInEmployee);
		}

		public void OnPostNextWeek()
		{
			counter++;
			NewDate = CurrentDate.AddDays(counter * 7);
			CurrentDate = NewDate;

			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
			}
			_assignedShifts = shiftController.GetAllAssigned(_loggedInEmployee);

		}
	}
}
