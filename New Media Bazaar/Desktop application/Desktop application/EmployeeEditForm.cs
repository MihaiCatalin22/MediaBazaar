using DAL;
using Logic.Classes;
using Logic.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_application
{
    public partial class EmployeeEditForm : Form
    {

        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        private EmployeeController EmployeeController { get; set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        private Employee _loggedInEmployee;
        private Employee _selectedEmployee;
        public EmployeeEditForm(Employee loggedInEmployee, Employee selectedEmployee)
        {
            if (loggedInEmployee == null || selectedEmployee == null)
            {
                throw new ArgumentNullException(loggedInEmployee == null ? nameof(loggedInEmployee) : nameof(selectedEmployee));
            }
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            _selectedEmployee = selectedEmployee;

            tbName.Text = _selectedEmployee.Name;
            tbUsername.Text = _selectedEmployee.Username;
            tbPassword.Text = _selectedEmployee.Password;
            tbEmail.Text = _selectedEmployee.Email;
            cbDepartment.Text = _selectedEmployee.Department.ToString();
            tbPhone.Text = _selectedEmployee.Phone;
            tbBSN.Text = _selectedEmployee.BSN;
            dtpDOB.Text = _selectedEmployee.DateOfBirth.ToString();
            numUDSalary.Value = _selectedEmployee.Salary;


            foreach (Department department in DepartmentController.GetAll())
            {
                cbDepartment.Items.Add(department);
            }
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedIndex = _selectedEmployee.Department.Id - 1;

            if (_selectedEmployee.Shifts.HasShift(ShiftType.Morning))
            {
                ckbMorning.Checked = true;
            }

            if (_selectedEmployee.Shifts.HasShift(ShiftType.Afternoon))
            {
                ckbAfternoon.Checked = true;
            }

            if (_selectedEmployee.Shifts.HasShift(ShiftType.Evening))
            {
                ckbEvening.Checked = true;
            }
        }


        // Exit employeeEditForm button
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string name = tbName.Text;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string email = tbEmail.Text;
                string phone = tbPhone.Text;
                string bsn = tbBSN.Text;
                decimal salary = numUDSalary.Value;
                DateTime dateOfBirth = dtpDOB.Value;
                int departmentId = ((Department)cbDepartment.SelectedItem).Id;
                int shifts = CalculateShifts();


                _selectedEmployee.Name = name;
                _selectedEmployee.Username = username;
                _selectedEmployee.Password = password;
                _selectedEmployee.Email = email;
                _selectedEmployee.Phone = phone;
                _selectedEmployee.BSN = bsn;
                _selectedEmployee.Salary = salary;
                _selectedEmployee.DateOfBirth = dateOfBirth;
                string departmentName = cbDepartment.SelectedItem.ToString();
                _selectedEmployee.Department = new Department(departmentName);
                _selectedEmployee.Shifts = shifts;

                if (cbDepartment.SelectedIndex != -1)
                {
                    Department selectedDepartment = (Department)cbDepartment.SelectedItem;
                    _selectedEmployee.Department = new Department(selectedDepartment.Id, selectedDepartment.Name);
                }
                else
                {
                    MessageBox.Show("Please select a department.");
                }
                if (EmployeeController.UpdateEmployee(_selectedEmployee))
                {
                    MessageBox.Show("Employee details updated successfully.");
                    this.DialogResult = DialogResult.OK;
                    AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update employee details.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private int CalculateShifts()
        {
            ShiftType shifts = ShiftType.None;

            if (ckbMorning.Checked)
                shifts |= ShiftType.Morning;

            if (ckbAfternoon.Checked)
                shifts |= ShiftType.Afternoon;

            if (ckbEvening.Checked)
                shifts |= ShiftType.Evening;

            if (CountSetBits((int)shifts) > 2)
            {
                MessageBox.Show("You cannot select more than 2 preferred shifts!");
                return -1;
            }

            // Check if no shift is selected
            if (shifts == ShiftType.None)
            {
                MessageBox.Show("Please select at least one preferred shift!");
                return -1;
            }

            return (int)shifts;
        }

        private int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
