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
    public partial class AdminRestockRequest : Form
    {
        private Employee _loggedInEmployee;
        public RestockRequestController RestockRequestController { get; private set; }
        public AdminRestockRequest(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            RestockRequestController = new RestockRequestController(new DALRestockRequestsController());

            cbType.DataSource = Enum.GetValues(typeof(StockType));
            cbType.SelectedIndexChanged += new EventHandler(cbType_SelectedIndexChanged);

            this.Load += new EventHandler(AdminRestockRequest_Load);

        }
        private void AdminRestockRequest_Load(object sender, EventArgs e)
        {
            if (cbType.Items.Count > 0)
            {
                cbType.SelectedIndex = 0;
                StockType defaultType = (StockType)cbType.SelectedItem;
                PopulateStockNames(defaultType);
            }
        }

        private void PopulateStockNames(StockType stockType)
        {
            cbName.Items.Clear();
            var stockNames = RestockRequestController.GetStockNamesByType(stockType);
            foreach (var name in stockNames)
            {
                cbName.Items.Add(name);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminStockDetails form = new AdminStockDetails(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cbName.SelectedItem == null) return;

            string selectedStockName = cbName.SelectedItem.ToString();
            int quantity = (int)NUDQuantity.Value;

            bool success = RestockRequestController.CreateRestockRequest(selectedStockName, quantity);

            if (success)
            {
                MessageBox.Show("The restock request was submitted successfully. The stock will be updated.");
            }
            else
            {
                MessageBox.Show("The restock request failed.");
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem != null)
            {
                StockType selectedType = (StockType)cbType.SelectedItem;
                PopulateStockNames(selectedType);
            }
        }

        // exit button for adminRestockDetails
        private void button1_Click(object sender, EventArgs e)
        {

            AdminStockDetails adminStockDetails = new AdminStockDetails(_loggedInEmployee);
            this.Hide();
            adminStockDetails.ShowDialog();
            this.Close();
        }

        private void AdminRestockRequest_Load_1(object sender, EventArgs e)
        {

        }
    }
}
