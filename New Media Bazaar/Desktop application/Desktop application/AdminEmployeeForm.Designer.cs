﻿namespace Desktop_application
{
    partial class AdminEmployeeForm
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
			btnDelete = new Button();
			btnEditDetails = new Button();
			btnAddEmp = new Button();
			btnClear = new Button();
			btnSearch = new Button();
			lbEmployees = new ListBox();
			tbSearch = new TextBox();
			lblEmp = new Label();
			panel2 = new Panel();
			btnLogout = new Button();
			btnStocks = new Button();
			bttnAnnouncement = new Button();
			btnDepartments = new Button();
			bttnShifts = new Button();
			bttnEmployees = new Button();
			label1 = new Label();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(804, 366);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(107, 61);
			btnDelete.TabIndex = 18;
			btnDelete.Text = "Delete selected employee";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEditDetails
			// 
			btnEditDetails.Location = new Point(804, 432);
			btnEditDetails.Name = "btnEditDetails";
			btnEditDetails.Size = new Size(107, 61);
			btnEditDetails.TabIndex = 17;
			btnEditDetails.Text = "Edit details of selected employee";
			btnEditDetails.UseVisualStyleBackColor = true;
			btnEditDetails.Click += btnEditDetails_Click;
			// 
			// btnAddEmp
			// 
			btnAddEmp.Location = new Point(804, 299);
			btnAddEmp.Name = "btnAddEmp";
			btnAddEmp.Size = new Size(107, 61);
			btnAddEmp.TabIndex = 16;
			btnAddEmp.Text = "Add a new employee";
			btnAddEmp.UseVisualStyleBackColor = true;
			btnAddEmp.Click += btnAddEmp_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(864, 232);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(75, 51);
			btnClear.TabIndex = 15;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(774, 231);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(75, 52);
			btnSearch.TabIndex = 14;
			btnSearch.Text = "Search employee";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// lbEmployees
			// 
			lbEmployees.FormattingEnabled = true;
			lbEmployees.ItemHeight = 15;
			lbEmployees.Location = new Point(144, 289);
			lbEmployees.Name = "lbEmployees";
			lbEmployees.Size = new Size(466, 199);
			lbEmployees.TabIndex = 13;
			lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
			// 
			// tbSearch
			// 
			tbSearch.Location = new Point(144, 246);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new Size(466, 23);
			tbSearch.TabIndex = 12;
			// 
			// lblEmp
			// 
			lblEmp.AutoSize = true;
			lblEmp.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblEmp.Location = new Point(406, 131);
			lblEmp.Name = "lblEmp";
			lblEmp.Size = new Size(211, 29);
			lblEmp.TabIndex = 11;
			lblEmp.Text = "Employees Page";
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(141, 222);
			label1.Name = "label1";
			label1.Size = new Size(168, 21);
			label1.TabIndex = 37;
			label1.Text = "Search an employee:";
			// 
			// AdminEmployeeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1034, 518);
			Controls.Add(label1);
			Controls.Add(panel2);
			Controls.Add(btnDelete);
			Controls.Add(btnEditDetails);
			Controls.Add(btnAddEmp);
			Controls.Add(btnClear);
			Controls.Add(btnSearch);
			Controls.Add(lbEmployees);
			Controls.Add(tbSearch);
			Controls.Add(lblEmp);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "AdminEmployeeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Employees";
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnDelete;
        private Button btnEditDetails;
        private Button btnAddEmp;
        private Button btnClear;
        private Button btnSearch;
        private ListBox lbEmployees;
        private TextBox tbSearch;
        private Label lblEmp;
		private Panel panel2;
		private Button btnLogout;
		private Button btnStocks;
		private Button bttnAnnouncement;
		private Button btnDepartments;
		private Button bttnShifts;
		private Button bttnEmployees;
		private Label label1;
	}
}