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
        public EditAnnouncement()
        {
            InitializeComponent();
            tbTitle.ReadOnly = true;
            tbDetails.ReadOnly = true;
        }
        Announcement announcement = new Announcement();
        AnnoucementController annoucementController = new AnnoucementController(new DALAnnoucement(new CreateConnection()));
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            tbTitle.ReadOnly = false;
            tbDetails.ReadOnly = false;
        }

        //ToDo edit
        private void EditAnnouncement_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //ToDo save edit
        private void bttnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
