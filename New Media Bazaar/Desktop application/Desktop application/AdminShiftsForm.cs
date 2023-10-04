using Logic.Controllers;
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

namespace Desktop_application
{
    public partial class AdminShiftsForm : Form
    {
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController(new CreateConnection()));
        public AdminShiftsForm()
        {
            InitializeComponent();
        }
    }
}
