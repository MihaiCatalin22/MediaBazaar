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

namespace Desktop_application
{
    public partial class EmployeeAddForm : Form
    {
        private Employee employee;
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());


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
            idSeeder++;
            string selectedDep = this.cbDepartment.GetItemText(this.cbDepartment.SelectedItem);

            Department department = this.cbDepartment.GetItemText(this.cbDepartment.SelectedItem);
            DateTime dateTime = DateTime.Now;
            int totalChecked = 0;
            foreach (CheckBox i in this.Controls)
            {
                if (i.Checked) { totalChecked++; }
            }
            employee = new Employee(idSeeder, tbUsername.Text, tbPassword.Text, department, tbName.Text, tbEmail.Text, tbPhone.Text, Convert.ToDecimal(numUDSalary.Value), dateTime, totalChecked);
            MessageBox.Show(employee.ToString());

        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
