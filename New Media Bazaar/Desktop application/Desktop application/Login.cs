using ClassLibrary.Controllers;
using DAL;
using DAL_Library;
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
    public partial class Login : Form
    {
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public Employee? LoggedInEmployee { get; private set; } = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = tbUsername.Text;
            string _password = tbPassword.Text;

            if (EmployeeController.Login(_username, _password) == null)
            {
                MessageBox.Show("Incorrect login details, try again.");
                return;
            }
            else
            {
                LoggedInEmployee = EmployeeController.Login(_username, _password);

                if (EmployeeController.IsAdmin(LoggedInEmployee))
                {
                    AdminLandingForm form = new AdminLandingForm(LoggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You do not have permission to access the application.");
                }
            }
        }
    }
}
