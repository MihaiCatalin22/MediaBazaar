using DAL;
using Logic.Classes;
using Logic.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
	public class IndexModel : PageModel
	{
		public Employee _loggedInEmployee;
		private EmployeeController _employeeController;
		private ShiftController _shiftController;
		private AnnoucementController _announcementController;
		[BindProperty]
		public Shift[] _assignedShifts { get; set; }
		[BindProperty]
		public Announcement[] _announcements { get; set; }

		public List<int> shiftIdsToCancel = new();

		public IndexModel()
		{
			_employeeController = new(new DALEmployeeController());
			_shiftController = new(new DALShiftController());
			_announcementController = new(new DALAnnoucement());
		}
		public void OnGet()
		{
			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
			}
			_assignedShifts = _shiftController.GetFutureShiftsByEmp(_loggedInEmployee);
			_assignedShifts = _assignedShifts.OrderBy(shift => shift.Date).ToArray();

			_announcements = _announcementController.GetAllCurrent();
		}
	}
}
