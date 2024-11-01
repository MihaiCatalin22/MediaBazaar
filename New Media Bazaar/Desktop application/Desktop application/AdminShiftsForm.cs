﻿using Logic.Controllers;
using DAL;
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

namespace Desktop_application
{
	public partial class AdminShiftsForm : Form
	{
		public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
		Employee _loggedInEmployee;
		public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
		Department _selectedDepartment;
		DateTime _selectedDate;
		List<Panel> _morningPanels;
		List<Panel> _afternoonPanels;
		List<Panel> _eveningPanels;
		public AdminShiftsForm(Employee loggedInEmployee)
		{
			InitializeComponent();
			_loggedInEmployee = loggedInEmployee;
			foreach (var shift in ShiftController.GetAll())
			{
				monthCalendar1.AddBoldedDate(shift.Date);
			}
			foreach (Department department in DepartmentController.GetAll())
			{
				cbDepartment.Items.Add(department.Name);
			}
			cbDepartment.SelectedIndex = -1;
			_morningPanels = new();
			_afternoonPanels = new();
			_eveningPanels = new();

		}

		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			_selectedDate = monthCalendar1.SelectionStart.Date;
		}


		private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			string departmentName = cbDepartment.SelectedItem.ToString();
			_selectedDepartment = DepartmentController.Get(departmentName);
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			flowLayoutPanelMorning.Controls.Clear();
			flowLayoutPanelAfternoon.Controls.Clear();
			flowLayoutPanelEvening.Controls.Clear();

			_morningPanels.Clear();
			_afternoonPanels.Clear();
			_eveningPanels.Clear();


			if (_selectedDate == default(DateTime))
			{
				MessageBox.Show("The date was not selected!");
				return;
			}
			if (cbDepartment.SelectedIndex == -1)
			{
				MessageBox.Show("The department was not selected!");
				return;
			}

			Shift[] shifts = ShiftController.GetAllByDateAndDepartment(_selectedDate, _selectedDepartment);



			foreach (Shift shift in shifts)
			{
				Panel panel = new Panel();
				panel.Name = shift.ToString();
				Label lblEmployee = new Label();
				lblEmployee.Text = $"{shift.Employee.Id}: {shift.Employee.Name}";
				lblEmployee.Size = new Size(270, 150);
				panel.Size = new Size(280, 150);
				panel.MaximumSize = new Size(280, 280);
				panel.Controls.Add(lblEmployee);
				panel.BackColor = Color.LightGray;
				panel.Visible = true;

				if (shift.Type == 1)
				{
					_morningPanels.Add(panel);
				}
				if (shift.Type == 2)
				{
					_afternoonPanels.Add(panel);
				}
				if (shift.Type == 4)
				{
					_eveningPanels.Add(panel);
				}
			}
			foreach (Panel panel in _morningPanels)
			{
				flowLayoutPanelMorning.Controls.Add(panel);
			}
			foreach (Panel panel in _afternoonPanels)
			{
				flowLayoutPanelAfternoon.Controls.Add(panel);
			}
			foreach (Panel panel in _eveningPanels)
			{
				flowLayoutPanelEvening.Controls.Add(panel);
			}
		}


		private void btnAddMorning_Click(object sender, EventArgs e)
		{
			if (_selectedDate == default)
			{
				MessageBox.Show("The date was not selected!");
				return;
			}
			if (cbDepartment.SelectedIndex == -1)
			{
				MessageBox.Show("The department was not selected!");
				return;
			}
			ChooseEmployeeByDepartment form = new ChooseEmployeeByDepartment(_loggedInEmployee, _selectedDepartment, _selectedDate, ShiftType.Morning);
			form.ShowDialog();
		}

		private void btnAddAfternoon_Click(object sender, EventArgs e)
		{
			if (_selectedDate == default)
			{
				MessageBox.Show("The date was not selected!");
				return;
			}
			if (cbDepartment.SelectedIndex == -1)
			{
				MessageBox.Show("The department was not selected!");
				return;
			}
			ChooseEmployeeByDepartment form = new ChooseEmployeeByDepartment(_loggedInEmployee, _selectedDepartment, _selectedDate, ShiftType.Afternoon);
			form.ShowDialog();
		}

		private void btnAddEvening_Click(object sender, EventArgs e)
		{
			if (_selectedDate == default)
			{
				MessageBox.Show("The date was not selected!");
				return;
			}
			if (cbDepartment.SelectedIndex == -1)
			{
				MessageBox.Show("The department was not selected!");
				return;
			}
			ChooseEmployeeByDepartment form = new ChooseEmployeeByDepartment(_loggedInEmployee, _selectedDepartment, _selectedDate, ShiftType.Evening);
			form.ShowDialog();
		}

		private void bttnAnnouncement_Click(object sender, EventArgs e)
		{
			AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void bttnEmployees_Click(object sender, EventArgs e)
		{
			AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnDepartments_Click(object sender, EventArgs e)
		{
			AdminDepartmentsForm form = new AdminDepartmentsForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void bttnShifts_Click(object sender, EventArgs e)
		{
			AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnStocks_Click(object sender, EventArgs e)
		{
			AdminStockDetails form = new AdminStockDetails(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Login form = new Login();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void bttnVacation_Click(object sender, EventArgs e)
		{
			Vacations form = new Vacations(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}
	}
}
