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
    public partial class AdminDepartmentsForm : Form
    {
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        Employee _loggedInEmployee;
        public AdminDepartmentsForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            foreach (Department department in DepartmentController.GetAll())
            {
                lbDepartments.Items.Add(department.Name);
            }
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

        private void bttnShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
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

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (tbDepartmentName.Text != string.Empty)
            {
                Department department = new Department(tbDepartmentName.Text);
                DepartmentController.Create(department);
                lbDepartments.Items.Add(department.Name);
                tbDepartmentName.Text = "";
            }
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbDepartments.SelectedIndex != -1)
            {
                Department dep = DepartmentController.Get(lbDepartments.SelectedItem.ToString());
                DepartmentController.Remove(dep);
                lbDepartments.Items.Clear();
                foreach (Department department in DepartmentController.GetAll())
                {
                    lbDepartments.Items.Add(department.Name);
                }
            }
        }
    }
}
