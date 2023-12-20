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

        public AnnoucementController AnnoucementController { get; private set; } = new(new DALAnnoucement());

        private void btnSendAnno_Click(object sender, EventArgs e)
        {
            bool isFilledIn = true;

            if (isFilledIn == true)
            {
                Announcement announcement = new Announcement();
                announcement.Title = tbTitle.Text;
                announcement.Details = tbDetails.Text;
                announcement.StartDate = DateOnly.FromDateTime(dtpStartTime.Value.Date);
                announcement.EndDate = DateOnly.FromDateTime(dtpEndTime.Value.Date);
                AnnoucementController.AddAnnouncement(announcement);
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

        private void btnExitCreateAnnouncement_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
