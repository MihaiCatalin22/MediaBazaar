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
    public partial class AdminLandingForm : Form
    {
        public AdminLandingForm()
        {
            InitializeComponent();
        }
        AnnoucementController annoucementController = new AnnoucementController(new DALAnnoucement(new CreateConnection()));

        private void btnCreateAnno_Click(object sender, EventArgs e)
        {
            new CreateAnnouncement().Show();
            this.Hide();
        }

        //ToDo double click
        private void lbAnnouncements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAnnouncements.SelectedItems != null)
            {
                new EditAnnouncement().Show();
                this.Hide();
            }

        }

        private void AdminLandingForm_Load(object sender, EventArgs e)
        {
            foreach (Announcement announcement in annoucementController.GetAllAnnouncements())
            {
                lbAnnouncements.Items.Add(announcement).ToString();
            }
        }

        private void bttnAnnouncement_Click(object sender, EventArgs e)
        {

        }

        private void bttnEmployees_Click(object sender, EventArgs e)
        {
            new AdminEmployeeForm().Show();
            this.Hide();
        }

        private void bttnShifts_Click(object sender, EventArgs e)
        {
            new AdminShiftsForm().Show();
            this.Hide();
        }

        //Todo Filter
        private void btnResetFilters_Click(object sender, EventArgs e)
        {

        }

        //ToDo fix listbox
        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
