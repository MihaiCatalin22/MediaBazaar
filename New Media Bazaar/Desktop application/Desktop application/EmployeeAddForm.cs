using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private int shiftCounter = 0;


        private int idSeeder = 0;

        public EmployeeAddForm()
        {
            InitializeComponent();
            Department newDepartment = new Department("Department 1");
            DepartmentController.AddDepartment(newDepartment);
            cbDepartment.Items.Add(newDepartment.Name);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                idSeeder++;
                Department department = new Department(this.cbDepartment.GetItemText(this.cbDepartment.SelectedItem));
                DateTime dateTime = DateTime.Now;
                employee = new Employee(idSeeder, tbUsername.Text, tbPassword.Text, department, tbName.Text, tbEmail.Text, tbPhone.Text, Convert.ToDecimal(numUDSalary.Value), dateTime, shiftCounter);
                MessageBox.Show(employee.ToString());
            }

        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

        }

        private void cbMorning_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    shiftCounter++;
                }
                else
                {
                    shiftCounter--;
                }
            }
        }

        private void cbAfternoon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    shiftCounter++;
                }
                else
                {
                    shiftCounter--;
                }
            }
        }

        private void cbEvening_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    shiftCounter++;
                }
                else
                {
                    shiftCounter--;
                }
            }
        }

        public bool CheckFields()
        {
            if (tbName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            if (tbUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter a username.");
                return false;
            }
            
            if (tbPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter a password.");
                return false;
            }

            if (tbEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter an email address.");
                return false;
            }

            if (cbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
                return false;
            }

            if (tbPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter a phone number");
                return false;
            }

            if (numUDSalary.Value == 0)
            {
                MessageBox.Show("Salary must be higher than 0!");
                return false;
            }

            if (shiftCounter == 0)
            {
                MessageBox.Show("At least 1 shift must be assigned.");
                return false;
            }

            else return true;
        }
    }
}
