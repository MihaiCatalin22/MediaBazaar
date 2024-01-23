using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Classes;
using Logic.Controllers;
using ClassLibrary.Controllers;
using ClassLibrary.Classes;
using DAL;
using DAL_Library;
using Logic.Interfaces;

namespace Desktop_application
{
	public partial class Vacations : Form
	{
		private VacationController vacationController = new(new DALVacationController());
		private ShiftController shiftController = new(new DALShiftController());
		private CancelledShiftController cancelledShiftController = new(new DALCancelledShift());
		private Vacation vacation = null;
		private Employee _loggedInEmployee;
		public Vacations(Employee loggedInEmployee)
		{
			InitializeComponent();
			_loggedInEmployee = loggedInEmployee;

			foreach (Vacation vacation in vacationController.ReadAll())
			{
				listBoxVacations.Items.Add(vacation.ToString());
			}
		}


		private void btnExitCreateAnnouncement_Click(object sender, EventArgs e)
		{
			AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			vacation.Pending = false;
			vacation.Approved = true;

			vacationController.Update(vacation);

			Shift[] shifts = shiftController.GetShiftsFromVacation(vacation);

			foreach (Shift shift in shifts)
			{
				CancelledShift cancelledShift = new CancelledShift();
				cancelledShift.AssignedEmployee = shift.Employee;
				cancelledShift.Shift = shift;
				cancelledShift.Reason = $"Vacation from {vacation.StartDate} until {vacation.EndDate}";
				cancelledShift.IsViewed = true;
				cancelledShiftController.Add(cancelledShift, new DALShiftController());
			}

			btnApprove.Visible = false;
			btnReject.Visible = false;
			labelStatus.Text = "Status: Approved";
			labelStatus.Visible = true;

			CreateAnnouncement(vacation);
		}
		public void CreateAnnouncement(Vacation vacation)
		{
			AnnoucementController announcementsController = new(new DALAnnoucement());

			string title = $"Empty shifts between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()}";

			string details = $"Between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()} there will be empty shifts in the {vacation.Employee.Department.Name} department. If you want to take an extra shift, please contact an admin via telephone.";

			DateOnly startDate = DateOnly.FromDateTime(vacation.StartDate.ToDateTime(TimeOnly.MinValue).AddDays(-7));
			DateOnly endDate = vacation.EndDate;

			Announcement announcement = new(title, details, startDate, endDate)
			{
				Id = vacation.Id
			};

			announcementsController.AddAnnouncement(announcement);
		}

		private void listBoxVacations_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelEmployee.Visible = false;
			labelStartDate.Visible = false;
			labelEndDate.Visible = false;
			labelReason.Visible = false;

			btnApprove.Visible = false;
			btnReject.Visible = false;

			labelStatus.Visible = false;



			int id = listBoxVacations.SelectedIndex;
			if (id != -1)
			{
				string[] split = listBoxVacations.SelectedItem.ToString().Split(new char[] { ':' });

				int vacationId = Convert.ToInt32(split[0]);

				vacation = vacationController.ReadById(vacationId);

				labelEmployee.Text = $"Employee: {vacation.Employee.Name}";
				labelStartDate.Text = $"Start date: {vacation.StartDate.ToShortDateString()}";
				labelEndDate.Text = $"End date: {vacation.EndDate.ToShortDateString()}";
				labelReason.Text = $"Reason: {vacation.Reason}";

				labelEmployee.Visible = true;
				labelStartDate.Visible = true;
				labelEndDate.Visible = true;
				labelReason.Visible = true;

				if (vacation.Pending == true)
				{
					btnApprove.Visible = true;
					btnReject.Visible = true;
				}
				else
				{
					if (vacation.Approved)
					{
						btnApprove.Visible = false;
						btnReject.Visible = false;

						labelStatus.Text = "Status: Approved";
						labelStatus.Visible = true;
					}
					else
					{
						btnApprove.Visible = false;
						btnReject.Visible = false;

						labelStatus.Text = "Status: Rejected";
						labelStatus.Visible = true;
					}
				}
			}
			else
			{
				MessageBox.Show("Please select an item from the list!");
			}
		}

		private void btnReject_Click(object sender, EventArgs e)
		{
			vacation.Pending = false;
			vacation.Approved = false;

			vacationController.Update(vacation);

			btnApprove.Visible = false;
			btnReject.Visible = false;
			labelStatus.Text = "Status: Rejected";
			labelStatus.Visible = true;
		}
	}
}
