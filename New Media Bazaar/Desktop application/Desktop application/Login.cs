using ClassLibrary.Controllers;
using DAL_Library;
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
        public Login()
        {
            InitializeComponent();
        }

        LoginController login = new LoginController(new DALLogin());

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (username.Length== 0 || password.Length==0)
            {
                MessageBox.Show("Username and Password can not be empty");
                return;
            }

            if (login.CheckLogin(username, password) != null)
            {
                (new AdminLandingForm()).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is not correct");
            }
        }
    }
}
