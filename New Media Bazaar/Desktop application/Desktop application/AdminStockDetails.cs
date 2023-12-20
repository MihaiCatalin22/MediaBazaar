using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Logic.Classes;
using Logic.Controllers;
using Logic.Interfaces;

namespace Desktop_application
{
    public partial class AdminStockDetails : Form
    {
        private Employee _loggedInEmployee;
        private RestockRequestController _stockController;
        private ListViewColumnSorter lvwColumnSorter;
        public AdminStockDetails(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            _stockController = new RestockRequestController(new DALRestockRequestsController());
            PopulateStockTypesComboBox();
            SetupListView();
            UpdateListView();
            lvwColumnSorter = new ListViewColumnSorter();
            lVStockDetails.ListViewItemSorter = lvwColumnSorter;
            lVStockDetails.ColumnClick += new ColumnClickEventHandler(lVStockDetails_ColumnClick);
            tbName.TextChanged += new EventHandler(tbName_TextChanged);
        }

        private void bttnAnnouncement_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void bttnEmployees_Click(object sender, EventArgs e)
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

        private void bttnShifts_Click(object sender, EventArgs e)
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

        private void cbStockTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            AdminRestockRequest form = new AdminRestockRequest(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void PopulateStockTypesComboBox()
        {
            cbStockTypes.Items.Clear();
            cbStockTypes.Items.Add("All");
            foreach (var type in Enum.GetValues(typeof(StockType)))
            {
                cbStockTypes.Items.Add(type);
            }
            cbStockTypes.SelectedIndex = 0;
        }
        private void SetupListView()
        {
            lVStockDetails.Columns.Clear();
            lVStockDetails.Columns.Add("Stock Name", 300);
            lVStockDetails.Columns.Add("Stock Type", 150);
            lVStockDetails.Columns.Add("Quantity", 70);
            lVStockDetails.View = View.Details;
        }
        private void UpdateListView(string filter = "")
        {
            lVStockDetails.Items.Clear();

            List<StockDetails> stockDetails;
            if (cbStockTypes.SelectedItem == null || cbStockTypes.SelectedItem.ToString() == "All")
            {
                stockDetails = _stockController.GetStockDetails();
            }
            else
            {
                var selectedTypeString = cbStockTypes.SelectedItem.ToString();
                if (Enum.TryParse(selectedTypeString, out StockType selectedType))
                {
                    stockDetails = _stockController.GetStockDetailsByType(selectedType);
                }
                else
                {
                    return;
                }
            }

            foreach (var detail in stockDetails)
            {
                if (string.IsNullOrEmpty(filter) || detail.StockName.Contains(filter, StringComparison.OrdinalIgnoreCase))
                {
                    ListViewItem item = new ListViewItem(new[] { detail.StockName, detail.StockType.ToString(), detail.Quantity.ToString() });
                    if (detail.Quantity <= 10)
                    {
                        item.ForeColor = Color.Red;
                    }
                    lVStockDetails.Items.Add(item);
                }
            }
        }
        private void lVStockDetails_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lVStockDetails.Sort();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockAddForm form = new StockAddForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        #region SORTER
        private class ListViewColumnSorter : IComparer
        {
            private int ColumnToSort;
            private SortOrder OrderOfSort;

            public ListViewColumnSorter()
            {
                ColumnToSort = 0;
                OrderOfSort = SortOrder.Ascending;
            }

            public int Compare(object x, object y)
            {
                ListViewItem item1 = x as ListViewItem;
                ListViewItem item2 = y as ListViewItem;

                int compareResult;
                if (ColumnToSort == 2)
                {
                    int quantity1 = int.TryParse(item1.SubItems[ColumnToSort].Text, out int q1) ? q1 : 0;
                    int quantity2 = int.TryParse(item2.SubItems[ColumnToSort].Text, out int q2) ? q2 : 0;
                    compareResult = quantity1.CompareTo(quantity2);
                }
                else
                {
                    compareResult = string.Compare(item1.SubItems[ColumnToSort].Text, item2.SubItems[ColumnToSort].Text);
                }

                return OrderOfSort == SortOrder.Ascending ? compareResult : -compareResult;
            }

            public int SortColumn
            {
                set => ColumnToSort = value;
                get => ColumnToSort;
            }

            public SortOrder Order
            {
                set => OrderOfSort = value;
                get => OrderOfSort;
            }
        }
        #endregion

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(tbName.Text);
        }
    }
}