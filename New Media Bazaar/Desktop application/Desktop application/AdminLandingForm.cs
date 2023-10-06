﻿using DAL;
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
        private Employee _loggedInEmployee;
        public AdminLandingForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            lblWelcome.Text = "Welcome, " + _loggedInEmployee.Username + "!";
        }
        List<Announcement> announcements = new List<Announcement>();
        Announcement announcement = new Announcement();
        AnnoucementController annoucementController = new AnnoucementController(new DALAnnoucement(new CreateConnection()));

        private void btnCreateAnno_Click(object sender, EventArgs e)
        {
            CreateAnnouncement createAnnouncement = new CreateAnnouncement(_loggedInEmployee);
            this.Hide();
            createAnnouncement.ShowDialog();
            this.Close();
        }

        //ToDo double click
        private void lbAnnouncements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            announcements = annoucementController.GetAllAnnouncements().ToList<Announcement>();
            if (lbAnnouncements.SelectedItems != null)
            {
                foreach (Announcement currentAnnouncement in announcements)
                {
                    if (lbAnnouncements.SelectedItem.ToString() == currentAnnouncement.Title)
                    {
                        announcement = annoucementController.GetAnnouncement(currentAnnouncement.Id);
                    }
                }
                EditAnnouncement editAnnouncement = new EditAnnouncement(announcement, _loggedInEmployee);
                this.Hide();
                editAnnouncement.ShowDialog();
                this.Close();
            }

        }

        private void AdminLandingForm_Load(object sender, EventArgs e)
        {
            foreach (Announcement announcement in annoucementController.GetAllAnnouncements())
            {
                lbAnnouncements.Items.Add(announcement.Title).ToString();
            }
        }

        private void bttnAnnouncement_Click(object sender, EventArgs e)
        {

        }

        private void bttnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm adminEmployeeForm = new AdminEmployeeForm();
            this.Hide();
            adminEmployeeForm.ShowDialog();
            this.Close();
        }

        private void bttnShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm adminShiftsForm = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            adminShiftsForm.ShowDialog();
            this.Close();
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
