namespace Desktop_application
{
	partial class AdminStockDetails
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel2 = new Panel();
			btnLogout = new Button();
			btnStocks = new Button();
			bttnAnnouncement = new Button();
			btnDepartments = new Button();
			bttnShifts = new Button();
			bttnEmployees = new Button();
			cbStockTypes = new ComboBox();
			btnRestock = new Button();
			lVStockDetails = new ListView();
			StockName = new ColumnHeader();
			StockType = new ColumnHeader();
			Quantity = new ColumnHeader();
			label1 = new Label();
			label2 = new Label();
			btnAdd = new Button();
			lblSearchName = new Label();
			tbName = new TextBox();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.DimGray;
			panel2.Controls.Add(btnLogout);
			panel2.Controls.Add(btnStocks);
			panel2.Controls.Add(bttnAnnouncement);
			panel2.Controls.Add(btnDepartments);
			panel2.Controls.Add(bttnShifts);
			panel2.Controls.Add(bttnEmployees);
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1033, 94);
			panel2.TabIndex = 36;
			// 
			// btnLogout
			// 
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogout.Location = new Point(897, 0);
			btnLogout.Margin = new Padding(3, 2, 3, 2);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(136, 94);
			btnLogout.TabIndex = 43;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// btnStocks
			// 
			btnStocks.FlatAppearance.BorderSize = 0;
			btnStocks.FlatStyle = FlatStyle.Flat;
			btnStocks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			btnStocks.Location = new Point(700, -1);
			btnStocks.Margin = new Padding(3, 2, 3, 2);
			btnStocks.Name = "btnStocks";
			btnStocks.Size = new Size(140, 94);
			btnStocks.TabIndex = 45;
			btnStocks.Text = "Stocks";
			btnStocks.UseVisualStyleBackColor = true;
			btnStocks.Click += btnStocks_Click;
			// 
			// bttnAnnouncement
			// 
			bttnAnnouncement.FlatAppearance.BorderSize = 0;
			bttnAnnouncement.FlatStyle = FlatStyle.Flat;
			bttnAnnouncement.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			bttnAnnouncement.Location = new Point(0, 0);
			bttnAnnouncement.Margin = new Padding(3, 2, 3, 2);
			bttnAnnouncement.Name = "bttnAnnouncement";
			bttnAnnouncement.Size = new Size(157, 94);
			bttnAnnouncement.TabIndex = 41;
			bttnAnnouncement.Text = "Announcements";
			bttnAnnouncement.UseVisualStyleBackColor = true;
			bttnAnnouncement.Click += bttnAnnouncement_Click;
			// 
			// btnDepartments
			// 
			btnDepartments.FlatAppearance.BorderSize = 0;
			btnDepartments.FlatStyle = FlatStyle.Flat;
			btnDepartments.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnDepartments.Location = new Point(354, 0);
			btnDepartments.Margin = new Padding(3, 2, 3, 2);
			btnDepartments.Name = "btnDepartments";
			btnDepartments.Size = new Size(138, 94);
			btnDepartments.TabIndex = 43;
			btnDepartments.Text = "Departments";
			btnDepartments.UseVisualStyleBackColor = true;
			btnDepartments.Click += btnDepartments_Click;
			// 
			// bttnShifts
			// 
			bttnShifts.FlatAppearance.BorderSize = 0;
			bttnShifts.FlatStyle = FlatStyle.Flat;
			bttnShifts.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			bttnShifts.Location = new Point(531, -1);
			bttnShifts.Margin = new Padding(3, 2, 3, 2);
			bttnShifts.Name = "bttnShifts";
			bttnShifts.Size = new Size(118, 94);
			bttnShifts.TabIndex = 44;
			bttnShifts.Text = "Shifts";
			bttnShifts.UseVisualStyleBackColor = true;
			bttnShifts.Click += bttnShifts_Click;
			// 
			// bttnEmployees
			// 
			bttnEmployees.FlatAppearance.BorderSize = 0;
			bttnEmployees.FlatStyle = FlatStyle.Flat;
			bttnEmployees.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			bttnEmployees.Location = new Point(190, 0);
			bttnEmployees.Margin = new Padding(3, 2, 3, 2);
			bttnEmployees.Name = "bttnEmployees";
			bttnEmployees.Size = new Size(119, 94);
			bttnEmployees.TabIndex = 42;
			bttnEmployees.Text = "Employees";
			bttnEmployees.UseVisualStyleBackColor = true;
			bttnEmployees.Click += bttnEmployees_Click;
			// 
			// cbStockTypes
			// 
			cbStockTypes.FormattingEnabled = true;
			cbStockTypes.Location = new Point(687, 194);
			cbStockTypes.Name = "cbStockTypes";
			cbStockTypes.Size = new Size(276, 23);
			cbStockTypes.TabIndex = 38;
			cbStockTypes.SelectedIndexChanged += cbStockTypes_SelectedIndexChanged;
			// 
			// btnRestock
			// 
			btnRestock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnRestock.Location = new Point(828, 416);
			btnRestock.Name = "btnRestock";
			btnRestock.Size = new Size(135, 57);
			btnRestock.TabIndex = 39;
			btnRestock.Text = "Send a restock request";
			btnRestock.UseVisualStyleBackColor = true;
			btnRestock.Click += btnRestock_Click;
			// 
			// lVStockDetails
			// 
			lVStockDetails.Columns.AddRange(new ColumnHeader[] { StockName, StockType, Quantity });
			lVStockDetails.Location = new Point(85, 185);
			lVStockDetails.Name = "lVStockDetails";
			lVStockDetails.Size = new Size(526, 288);
			lVStockDetails.TabIndex = 40;
			lVStockDetails.UseCompatibleStateImageBehavior = false;
			// 
			// StockName
			// 
			StockName.Text = "Stock Name";
			StockName.Width = 300;
			// 
			// StockType
			// 
			StockType.Text = "StockType";
			StockType.TextAlign = HorizontalAlignment.Center;
			StockType.Width = 150;
			// 
			// Quantity
			// 
			Quantity.Text = "Quantity";
			Quantity.TextAlign = HorizontalAlignment.Center;
			Quantity.Width = 70;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(701, 161);
			label1.Name = "label1";
			label1.Size = new Size(139, 21);
			label1.TabIndex = 41;
			label1.Text = "Select stock type:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(85, 161);
			label2.Name = "label2";
			label2.Size = new Size(91, 21);
			label2.TabIndex = 42;
			label2.Text = "Stock info:";
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.Location = new Point(687, 416);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(135, 57);
			btnAdd.TabIndex = 43;
			btnAdd.Text = "Add new stocks";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblSearchName
			// 
			lblSearchName.AutoSize = true;
			lblSearchName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblSearchName.Location = new Point(700, 229);
			lblSearchName.Name = "lblSearchName";
			lblSearchName.Size = new Size(189, 20);
			lblSearchName.TabIndex = 44;
			lblSearchName.Text = "Search for a specific stock:";
			// 
			// tbName
			// 
			tbName.Location = new Point(687, 260);
			tbName.Name = "tbName";
			tbName.Size = new Size(276, 23);
			tbName.TabIndex = 45;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// AdminStockDetails
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1034, 518);
			Controls.Add(tbName);
			Controls.Add(lblSearchName);
			Controls.Add(btnAdd);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lVStockDetails);
			Controls.Add(btnRestock);
			Controls.Add(cbStockTypes);
			Controls.Add(panel2);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AdminStockDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Stocks";
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel2;
		private Button btnLogout;
		private Button btnStocks;
		private Button bttnAnnouncement;
		private Button btnDepartments;
		private Button bttnShifts;
		private Button bttnEmployees;
		private ComboBox cbStockTypes;
		private Button btnRestock;
		private ListView lVStockDetails;
		private Label label1;
		private Label label2;
		private Button btnAdd;
		private ColumnHeader StockName;
		private ColumnHeader StockType;
		private ColumnHeader Quantity;
		private Label lblSearchName;
		private TextBox tbName;
	}
}