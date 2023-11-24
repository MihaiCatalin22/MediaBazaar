using Logic.Classes;
using Logic.Controllers;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace WebApplication2.Pages
{
    public class ScheduleModel : PageModel
    {
		[BindProperty]
		public Shift[] Shifts { get; set; }
		public ShiftController shiftController = new ShiftController(new DALShiftController());
		public EmployeeController employeeController = new EmployeeController(new DALEmployeeController());
		
		[BindProperty]
		public DateTime Today { get; set; }

		

		public void OnGet()
        {
			//string username = HttpContext.Session.GetString("username");

			//Employee thisEmployee = employeeController.Get(username);
			////int employeeId = Convert.ToInt32(HttpContext.Session.GetString("employeeId"));

			//if (username == null || username == " ")
			//{
			//	Response.Redirect("Login");
			//}

			//Today = DateTime.Now;

			//Shift[] allShifts = ShiftController.GetWeeklyShifts(Today);
			//List<Shift> empShifts = new List<Shift>();
			//foreach (Shift shift in allShifts)
			//{
			//	empShifts.Add(shift);

			//}

			//Shifts = empShifts.ToArray();

		}
    }
}
