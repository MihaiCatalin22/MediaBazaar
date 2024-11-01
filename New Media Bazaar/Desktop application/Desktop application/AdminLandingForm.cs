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
        public AnnoucementController AnnoucementController { get; private set; } = new(new DALAnnoucement());

        private void btnCreateAnno_Click(object sender, EventArgs e)
        {
            CreateAnnouncement createAnnouncement = new CreateAnnouncement(_loggedInEmployee);
            this.Hide();
            createAnnouncement.ShowDialog();
            this.Close();
        }


        private void lbAnnouncements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            announcements = AnnoucementController.GetAllAnnouncements().ToList<Announcement>();
            if (lbAnnouncements.SelectedItems != null)
            {
                foreach (Announcement currentAnnouncement in announcements)
                {
                    if (lbAnnouncements.SelectedItem.ToString() == currentAnnouncement.Title)
                    {
                        announcement = AnnoucementController.GetAnnouncement(currentAnnouncement.Id);
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
            foreach (Announcement announcement in AnnoucementController.GetAllAnnouncements())
            {
                lbAnnouncements.Items.Add(announcement.Title).ToString();
            }
        }

        private void bttnAnnouncement_Click(object sender, EventArgs e)
        {

        }

        private void bttnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm adminEmployeeForm = new AdminEmployeeForm(_loggedInEmployee);
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

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            if (rbAllAnnouncements.Checked)
            {
                filterAllAnno();
            }
            else if (rbCurrentAnnouncement.Checked)
            {
                filterCurrentAnno();
            }
            else if (rbPastAnnouncement.Checked)
            {
                filterPastAnno();
            }
            else if (rbPostPonedAnnouncement.Checked)
            {
                filterFutureAnno();
            }

        }
        private void filterPastAnno()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            foreach (Announcement announcement in AnnoucementController.GetAllAnnouncements())
            {
                if (announcement.EndDate < today)
                {
                    lbAnnouncements.Items.Add(announcement.Title).ToString();
                }
            }
        }
        private void filterFutureAnno()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            foreach (Announcement announcement in AnnoucementController.GetAllAnnouncements())
            {
                if (announcement.EndDate > today)
                {
                    lbAnnouncements.Items.Add(announcement.Title).ToString();
                }
            }
        }
        private void filterCurrentAnno()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            foreach (Announcement announcement in AnnoucementController.GetAllAnnouncements())
            {
                if (announcement.StartDate <= today && announcement.EndDate >= today)
                {
                    lbAnnouncements.Items.Add(announcement.Title).ToString();
                }
            }
        }
        private void filterAllAnno()
        {
            foreach (Announcement announcement in AnnoucementController.GetAllAnnouncements())
            {
                lbAnnouncements.Items.Add(announcement.Title).ToString();
            }
        }



        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm form = new AdminEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            AdminDepartmentsForm form = new AdminDepartmentsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            AdminStockDetails form = new AdminStockDetails(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
