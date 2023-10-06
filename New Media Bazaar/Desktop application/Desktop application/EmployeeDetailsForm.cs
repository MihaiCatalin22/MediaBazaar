using Logic.Classes;
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
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        public EmployeeDetailsForm(Employee loggedInEmployee, Employee employee)
        {
            LoggedInEmployee = loggedInEmployee;
            Employee = employee;
        }

        public Employee LoggedInEmployee { get; }
        public Employee Employee { get; }
    }
}
