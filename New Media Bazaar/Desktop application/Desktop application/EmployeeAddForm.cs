using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary.Classes;
using DAL;
using Logic.Classes;
using Logic.Controllers;
using Microsoft.IdentityModel.Tokens;

namespace Desktop_application
{
    public partial class EmployeeAddForm : Form
    {
        private Employee employee;
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        Employee _loggedInEmployee;
        public EmployeeAddForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            foreach (Department department in DepartmentController.GetAll())
            {
                cbDepartment.Items.Add(department.Name);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string _name = tbName.Text;
            string _password = tbPassword.Text;
            string _username = tbUsername.Text;
            decimal _salary = numUDSalary.Value;
            string _email = tbEmail.Text;
            string _phone = tbPhone.Text;
            string departmentName = null;
            if (cbDepartment.SelectedIndex != -1)
            {
                departmentName = cbDepartment.SelectedItem.ToString();
            }
            Department? _department = DepartmentController.Get(departmentName);
            int _shifts = 0;

            if (_name.Length == 0 || _password.Length == 0 || _username.Length == 0)
            {
                MessageBox.Show("Name, username and password cannot be empty!");
                return;
            }

            if (_salary == 0)
            {
                MessageBox.Show("Salary cannot be 0!");
                return;
            }

            if (ckbMorning.Checked == true && ckbAfternoon.Checked == true && ckbEvening.Checked == true)
            {
                MessageBox.Show("You cannot select more than 2 preferred shifts!");
                return;
            }
            else
            {
                if (ckbMorning.Checked == false && ckbAfternoon.Checked == false && ckbEvening.Checked == false)
                {
                    MessageBox.Show("Please select at least one preferred shift!");
                    return;
                }
                else
                {
                    if (ckbMorning.Checked == true && ckbAfternoon.Checked == true)
                    {
                        _shifts.AddShift(ShiftType.Morning);
                        _shifts.AddShift(ShiftType.Afternoon);

                    }
                    else if (ckbMorning.Checked == true && ckbEvening.Checked == true)
                    {
                        _shifts.AddShift(ShiftType.Morning);
                        _shifts.AddShift(ShiftType.Evening);
                    }
                    else if (ckbAfternoon.Checked == true && ckbEvening.Checked == true)
                    {
                        _shifts.AddShift(ShiftType.Afternoon);
                        _shifts.AddShift(ShiftType.Evening);
                    }
                    else if (ckbMorning.Checked == true) _shifts.AddShift(ShiftType.Morning);
                    else if (ckbAfternoon.Checked == true) _shifts.AddShift(ShiftType.Afternoon);
                    else if (ckbEvening.Checked == true) _shifts.AddShift(ShiftType.Evening);
                }
            }

            Employee employee = new Employee(_username, _password, _department, _name, _email, _phone, _salary, _shifts);



            if (EmployeeController.AddEmployee(employee))
            {
                MessageBox.Show("Employee has been added successfully");
            }
            else
            {
                MessageBox.Show("Error creating employee");
            }

            AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

        }

        private void cbMorning_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAfternoon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEvening_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}
