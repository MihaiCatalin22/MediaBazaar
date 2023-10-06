using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Classes;
using Logic.Controllers;
using ClassLibrary.Controllers;
using ClassLibrary.Classes;
using DAL;
using DAL_Library;

namespace Desktop_application
{
    public partial class CreateAnnouncement : Form
    {
        private Employee _loggedInEmployee;
        public CreateAnnouncement(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
        }

        AnnoucementController annoucementController = new AnnoucementController(new DALAnnoucement(new CreateConnection()));

        private void btnSendAnno_Click(object sender, EventArgs e)
        {
            bool isFilledIn = true;

            if (isFilledIn == true)
            {
                Announcement announcement = new Announcement();
                announcement.Title = tbTitle.Text;
                announcement.Details = tbDetails.Text;
                announcement.StartDate = dtpStartTime.Value.Date;
                announcement.EndDate = dtpEndTime.Value.Date;
                annoucementController.AddAnnouncement(announcement);
                AdminLandingForm adminLandingForm = new AdminLandingForm(_loggedInEmployee);
                this.Hide();
                adminLandingForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not everything is filled in correctly");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminLandingForm adminLandingForm = new AdminLandingForm(_loggedInEmployee);
            this.Hide(); 
            adminLandingForm.ShowDialog();
            this.Close();
        }
    }
}
