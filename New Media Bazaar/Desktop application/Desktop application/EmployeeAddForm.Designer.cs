﻿namespace Desktop_application
{
	partial class EmployeeAddForm
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
			btnAdd = new Button();
			btnBack = new Button();
			tbName = new TextBox();
			tbUsername = new TextBox();
			tbPassword = new TextBox();
			tbEmail = new TextBox();
			cbDepartment = new ComboBox();
			tbPhone = new TextBox();
			numUDSalary = new NumericUpDown();
			ckbEvening = new CheckBox();
			ckbAfternoon = new CheckBox();
			ckbMorning = new CheckBox();
			lblSalary = new Label();
			lblAvailability = new Label();
			lblPhone = new Label();
			lblEmail = new Label();
			lblDepartment = new Label();
			lblPassword = new Label();
			lblUsername = new Label();
			lblName = new Label();
			lblNewEmployee = new Label();
			lblBSN = new Label();
			tbBSN = new TextBox();
			lblDOB = new Label();
			dtpDOB = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)numUDSalary).BeginInit();
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.Location = new Point(332, 662);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(92, 68);
			btnAdd.TabIndex = 41;
			btnAdd.Text = "Add employee";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(104, 662);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 68);
			btnBack.TabIndex = 40;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// tbName
			// 
			tbName.Location = new Point(195, 107);
			tbName.Margin = new Padding(3, 4, 3, 4);
			tbName.Name = "tbName";
			tbName.Size = new Size(244, 27);
			tbName.TabIndex = 39;
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(195, 154);
			tbUsername.Margin = new Padding(3, 4, 3, 4);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(244, 27);
			tbUsername.TabIndex = 38;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(195, 203);
			tbPassword.Margin = new Padding(3, 4, 3, 4);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(244, 27);
			tbPassword.TabIndex = 37;
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(195, 250);
			tbEmail.Margin = new Padding(3, 4, 3, 4);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(244, 27);
			tbEmail.TabIndex = 36;
			// 
			// cbDepartment
			// 
			cbDepartment.FormattingEnabled = true;
			cbDepartment.Location = new Point(194, 291);
			cbDepartment.Margin = new Padding(3, 4, 3, 4);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(245, 28);
			cbDepartment.TabIndex = 35;
			// 
			// tbPhone
			// 
			tbPhone.Location = new Point(194, 343);
			tbPhone.Margin = new Padding(3, 4, 3, 4);
			tbPhone.MaxLength = 12;
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(245, 27);
			tbPhone.TabIndex = 34;
			// 
			// numUDSalary
			// 
			numUDSalary.DecimalPlaces = 2;
			numUDSalary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			numUDSalary.Location = new Point(194, 480);
			numUDSalary.Margin = new Padding(3, 4, 3, 4);
			numUDSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numUDSalary.Name = "numUDSalary";
			numUDSalary.Size = new Size(245, 27);
			numUDSalary.TabIndex = 33;
			// 
			// ckbEvening
			// 
			ckbEvening.AutoSize = true;
			ckbEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbEvening.Location = new Point(194, 600);
			ckbEvening.Margin = new Padding(3, 4, 3, 4);
			ckbEvening.Name = "ckbEvening";
			ckbEvening.Size = new Size(127, 24);
			ckbEvening.TabIndex = 32;
			ckbEvening.Text = "Evening shift";
			ckbEvening.UseVisualStyleBackColor = true;
			ckbEvening.CheckedChanged += cbEvening_CheckedChanged;
			// 
			// ckbAfternoon
			// 
			ckbAfternoon.AutoSize = true;
			ckbAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbAfternoon.Location = new Point(194, 566);
			ckbAfternoon.Margin = new Padding(3, 4, 3, 4);
			ckbAfternoon.Name = "ckbAfternoon";
			ckbAfternoon.Size = new Size(140, 24);
			ckbAfternoon.TabIndex = 31;
			ckbAfternoon.Text = "Afternoon shift";
			ckbAfternoon.UseVisualStyleBackColor = true;
			ckbAfternoon.CheckedChanged += cbAfternoon_CheckedChanged;
			// 
			// ckbMorning
			// 
			ckbMorning.AutoSize = true;
			ckbMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbMorning.Location = new Point(194, 533);
			ckbMorning.Margin = new Padding(3, 4, 3, 4);
			ckbMorning.Name = "ckbMorning";
			ckbMorning.Size = new Size(128, 24);
			ckbMorning.TabIndex = 30;
			ckbMorning.Text = "Morning shift";
			ckbMorning.UseVisualStyleBackColor = true;
			ckbMorning.CheckedChanged += cbMorning_CheckedChanged;
			// 
			// lblSalary
			// 
			lblSalary.AutoSize = true;
			lblSalary.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblSalary.Location = new Point(100, 480);
			lblSalary.Name = "lblSalary";
			lblSalary.Size = new Size(73, 22);
			lblSalary.TabIndex = 29;
			lblSalary.Text = "Salary:";
			// 
			// lblAvailability
			// 
			lblAvailability.AutoSize = true;
			lblAvailability.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblAvailability.Location = new Point(60, 532);
			lblAvailability.Name = "lblAvailability";
			lblAvailability.Size = new Size(113, 22);
			lblAvailability.TabIndex = 28;
			lblAvailability.Text = "Availability:";
			// 
			// lblPhone
			// 
			lblPhone.AutoSize = true;
			lblPhone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPhone.Location = new Point(28, 344);
			lblPhone.Name = "lblPhone";
			lblPhone.Size = new Size(145, 22);
			lblPhone.TabIndex = 27;
			lblPhone.Text = "Phone number:";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblEmail.Location = new Point(108, 247);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(65, 22);
			lblEmail.TabIndex = 26;
			lblEmail.Text = "Email:";
			// 
			// lblDepartment
			// 
			lblDepartment.AutoSize = true;
			lblDepartment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDepartment.Location = new Point(59, 289);
			lblDepartment.Name = "lblDepartment";
			lblDepartment.Size = new Size(119, 22);
			lblDepartment.TabIndex = 25;
			lblDepartment.Text = "Department:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPassword.Location = new Point(70, 200);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(103, 22);
			lblPassword.TabIndex = 24;
			lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblUsername.Location = new Point(67, 151);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(106, 22);
			lblUsername.TabIndex = 23;
			lblUsername.Text = "Username:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.Location = new Point(106, 107);
			lblName.Name = "lblName";
			lblName.Size = new Size(67, 22);
			lblName.TabIndex = 22;
			lblName.Text = "Name:";
			// 
			// lblNewEmployee
			// 
			lblNewEmployee.AutoSize = true;
			lblNewEmployee.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblNewEmployee.Location = new Point(114, 43);
			lblNewEmployee.Name = "lblNewEmployee";
			lblNewEmployee.Size = new Size(310, 36);
			lblNewEmployee.TabIndex = 21;
			lblNewEmployee.Text = "Add a new employee";
			// 
			// lblBSN
			// 
			lblBSN.AutoSize = true;
			lblBSN.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblBSN.Location = new Point(117, 391);
			lblBSN.Name = "lblBSN";
			lblBSN.Size = new Size(56, 22);
			lblBSN.TabIndex = 42;
			lblBSN.Text = "BSN:";
			// 
			// tbBSN
			// 
			tbBSN.Location = new Point(194, 390);
			tbBSN.Margin = new Padding(3, 4, 3, 4);
			tbBSN.MaxLength = 9;
			tbBSN.Name = "tbBSN";
			tbBSN.Size = new Size(245, 27);
			tbBSN.TabIndex = 43;
			// 
			// lblDOB
			// 
			lblDOB.AutoSize = true;
			lblDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDOB.Location = new Point(46, 433);
			lblDOB.Name = "lblDOB";
			lblDOB.Size = new Size(127, 22);
			lblDOB.TabIndex = 44;
			lblDOB.Text = "Date of birth:";
			// 
			// dtpDOB
			// 
			dtpDOB.Location = new Point(194, 433);
			dtpDOB.Name = "dtpDOB";
			dtpDOB.Size = new Size(245, 27);
			dtpDOB.TabIndex = 45;
			// 
			// EmployeeAddForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(482, 748);
			Controls.Add(dtpDOB);
			Controls.Add(lblDOB);
			Controls.Add(tbBSN);
			Controls.Add(lblBSN);
			Controls.Add(btnAdd);
			Controls.Add(btnBack);
			Controls.Add(tbName);
			Controls.Add(tbUsername);
			Controls.Add(tbPassword);
			Controls.Add(tbEmail);
			Controls.Add(cbDepartment);
			Controls.Add(tbPhone);
			Controls.Add(numUDSalary);
			Controls.Add(ckbEvening);
			Controls.Add(ckbAfternoon);
			Controls.Add(ckbMorning);
			Controls.Add(lblSalary);
			Controls.Add(lblAvailability);
			Controls.Add(lblPhone);
			Controls.Add(lblEmail);
			Controls.Add(lblDepartment);
			Controls.Add(lblPassword);
			Controls.Add(lblUsername);
			Controls.Add(lblName);
			Controls.Add(lblNewEmployee);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "EmployeeAddForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EmployeeAddForm";
			Load += EmployeeAddForm_Load;
			((System.ComponentModel.ISupportInitialize)numUDSalary).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAdd;
		private Button btnBack;
		private TextBox tbName;
		private TextBox tbUsername;
		private TextBox tbPassword;
		private TextBox tbEmail;
		private ComboBox cbDepartment;
		private TextBox tbPhone;
		private NumericUpDown numUDSalary;
		private CheckBox ckbEvening;
		private CheckBox ckbAfternoon;
		private CheckBox ckbMorning;
		private Label lblSalary;
		private Label lblAvailability;
		private Label lblPhone;
		private Label lblEmail;
		private Label lblDepartment;
		private Label lblPassword;
		private Label lblUsername;
		private Label lblName;
		private Label lblNewEmployee;
		private Label lblBSN;
		private TextBox tbBSN;
		private Label lblDOB;
		private DateTimePicker dtpDOB;
	}
}