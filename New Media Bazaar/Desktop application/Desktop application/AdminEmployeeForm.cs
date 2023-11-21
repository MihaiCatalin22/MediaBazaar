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
    public partial class AdminEmployeeForm : Form
    {

        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        Employee _loggedInEmployee;
        private Employee selectedEmployee;

        public AdminEmployeeForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;

            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 0)
                {
                    lbEmployees.Items.Add(new EmployeeListItem(employee.Id, employee.ToString()));
                }
            }

            lbEmployees.DisplayMember = "Text";
            lbEmployees.ValueMember = "Id";
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 0 && employee.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                    lbEmployees.Items.Add(employee.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            lbEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 0)
                    lbEmployees.Items.Add(employee.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                string[] split = lbEmployees.SelectedItem.ToString().Split(new char[] { ':' });

                int _index = Convert.ToInt32(split[0]);

                Employee _employee = EmployeeController.GetById(_index);
                EmployeeController.RemoveEmployee(_employee);
                lbEmployees.Items.Clear();
                foreach (Employee employee in EmployeeController.GetAll())
                    if (employee.Department.Id > 2) lbEmployees.Items.Add(employee.ToString());
            }
            else MessageBox.Show("Please select an employee!");
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmployeeAddForm form = new EmployeeAddForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                EmployeeListItem selectedItem = (EmployeeListItem)lbEmployees.SelectedItem;
                selectedEmployee = EmployeeController.GetById(selectedItem.Id);

                EmployeeEditForm form = new EmployeeEditForm(_loggedInEmployee, selectedEmployee);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an employee!");
            }
        }

        private void lblAnnouncements_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lblShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
