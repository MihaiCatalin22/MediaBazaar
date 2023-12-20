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
    public partial class EditAnnouncement : Form
    {
        private Employee _loggedInEmployee;
        private Announcement _announcement;
        public EditAnnouncement(Announcement oldAnnouncement, Employee loggedInEmployee)
        {
            InitializeComponent();
            tbTitle.ReadOnly = true;
            tbDetails.ReadOnly = true;

            tbTitle.Text = oldAnnouncement.Title;
            tbDetails.Text = oldAnnouncement.Details;
            _loggedInEmployee = loggedInEmployee;
            _announcement = oldAnnouncement;
        }
        //Announcement announcement = new Announcement();
        public AnnoucementController AnnoucementController { get; private set; } = new(new DALAnnoucement());
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            tbTitle.ReadOnly = false;
            tbDetails.ReadOnly = false;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            _announcement.Title = tbTitle.Text;
            _announcement.Details = tbDetails.Text;
            _announcement.StartDate = DateOnly.FromDateTime(dtpStartTime.Value.Date);
            _announcement.EndDate = DateOnly.FromDateTime(dtpEndTime.Value.Date);
            AnnoucementController.UpdateAnnouncement(_announcement);

            AdminLandingForm adminLandingForm = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            adminLandingForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminLandingForm adminLandingForm = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            adminLandingForm.ShowDialog();
            this.Close();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
