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

        private void btnCreateAnno_Click(object sender, EventArgs e)
        {
            (new CreateAnnouncement()).Show();
            this.Hide();
        }

        private void lbAnnouncements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAnnouncements.SelectedItems != null)
            {
                (new EditAnnouncement()).Show();
                this.Hide();
            }
            
        }
    }
}
