using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Logic.Classes;
using Logic.Controllers;

namespace Desktop_application
{
	public partial class StockAddForm : Form
	{
		private Employee _loggedInEmployee;
		private RestockRequestController _stockController;
		public StockAddForm(Employee loggedInEmployee)
		{
			InitializeComponent();

			_loggedInEmployee = loggedInEmployee;
			_stockController = new RestockRequestController(new DALRestockRequestsController());

			PopulateStockType();
		}
		private void PopulateStockType()
		{
			cbType.DataSource = Enum.GetValues(typeof(StockType));
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminStockDetails form = new AdminStockDetails(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string stockName = tbName.Text;
			StockType stockType = (StockType)cbType.SelectedItem;
			int quantity = (int)NUDQuantity.Value;

			if (string.IsNullOrWhiteSpace(stockName))
			{
				MessageBox.Show("Please enter a valid stock name");
			}

			bool success = _stockController.AddNewStock(stockName, stockType, quantity);

			if (success)
			{
				MessageBox.Show("The new stock item was added successfully into the system.");
				ClearFormInputs();
			}
			else
			{
				MessageBox.Show("Failed to add the stock item to the system.");
			}
		}

		private void ClearFormInputs()
		{
			tbName.Clear();
			NUDQuantity.Value = NUDQuantity.Minimum;
			cbType.SelectedIndex = 0;
		}
	}
}
