namespace Desktop_application
{
	partial class EmployeeEditForm
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
			lblEdit = new Label();
			dtpDOB = new DateTimePicker();
			lblDOB = new Label();
			tbBSN = new TextBox();
			lblBSN = new Label();
			btnEdit = new Button();
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
			((System.ComponentModel.ISupportInitialize)numUDSalary).BeginInit();
			SuspendLayout();
			// 
			// lblEdit
			// 
			lblEdit.AutoSize = true;
			lblEdit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblEdit.Location = new Point(122, 30);
			lblEdit.Name = "lblEdit";
			lblEdit.Size = new Size(181, 29);
			lblEdit.TabIndex = 62;
			lblEdit.Text = "Edit employee";
			// 
			// dtpDOB
			// 
			dtpDOB.Location = new Point(176, 319);
			dtpDOB.Margin = new Padding(3, 2, 3, 2);
			dtpDOB.Name = "dtpDOB";
			dtpDOB.Size = new Size(215, 23);
			dtpDOB.TabIndex = 86;
			// 
			// lblDOB
			// 
			lblDOB.AutoSize = true;
			lblDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDOB.Location = new Point(46, 319);
			lblDOB.Name = "lblDOB";
			lblDOB.Size = new Size(106, 18);
			lblDOB.TabIndex = 85;
			lblDOB.Text = "Date of birth:";
			// 
			// tbBSN
			// 
			tbBSN.Location = new Point(176, 286);
			tbBSN.MaxLength = 9;
			tbBSN.Name = "tbBSN";
			tbBSN.Size = new Size(215, 23);
			tbBSN.TabIndex = 84;
			// 
			// lblBSN
			// 
			lblBSN.AutoSize = true;
			lblBSN.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblBSN.Location = new Point(108, 287);
			lblBSN.Name = "lblBSN";
			lblBSN.Size = new Size(47, 18);
			lblBSN.TabIndex = 83;
			lblBSN.Text = "BSN:";
			// 
			// btnEdit
			// 
			btnEdit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnEdit.Location = new Point(284, 488);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(80, 51);
			btnEdit.TabIndex = 82;
			btnEdit.Text = "Edit employee";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(70, 488);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(82, 51);
			btnBack.TabIndex = 81;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// tbName
			// 
			tbName.Location = new Point(177, 74);
			tbName.Name = "tbName";
			tbName.Size = new Size(214, 23);
			tbName.TabIndex = 80;
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(177, 110);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(214, 23);
			tbUsername.TabIndex = 79;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(177, 146);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(214, 23);
			tbPassword.TabIndex = 78;
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(177, 182);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(214, 23);
			tbEmail.TabIndex = 77;
			// 
			// cbDepartment
			// 
			cbDepartment.FormattingEnabled = true;
			cbDepartment.Location = new Point(176, 212);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(215, 23);
			cbDepartment.TabIndex = 76;
			// 
			// tbPhone
			// 
			tbPhone.Location = new Point(176, 251);
			tbPhone.MaxLength = 12;
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(215, 23);
			tbPhone.TabIndex = 75;
			// 
			// numUDSalary
			// 
			numUDSalary.DecimalPlaces = 2;
			numUDSalary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			numUDSalary.Location = new Point(176, 354);
			numUDSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numUDSalary.Name = "numUDSalary";
			numUDSalary.Size = new Size(214, 23);
			numUDSalary.TabIndex = 74;
			// 
			// ckbEvening
			// 
			ckbEvening.AutoSize = true;
			ckbEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbEvening.Location = new Point(176, 444);
			ckbEvening.Name = "ckbEvening";
			ckbEvening.Size = new Size(108, 21);
			ckbEvening.TabIndex = 73;
			ckbEvening.Text = "Evening shift";
			ckbEvening.UseVisualStyleBackColor = true;
			// 
			// ckbAfternoon
			// 
			ckbAfternoon.AutoSize = true;
			ckbAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbAfternoon.Location = new Point(176, 418);
			ckbAfternoon.Name = "ckbAfternoon";
			ckbAfternoon.Size = new Size(119, 21);
			ckbAfternoon.TabIndex = 72;
			ckbAfternoon.Text = "Afternoon shift";
			ckbAfternoon.UseVisualStyleBackColor = true;
			// 
			// ckbMorning
			// 
			ckbMorning.AutoSize = true;
			ckbMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbMorning.Location = new Point(176, 394);
			ckbMorning.Name = "ckbMorning";
			ckbMorning.Size = new Size(108, 21);
			ckbMorning.TabIndex = 71;
			ckbMorning.Text = "Morning shift";
			ckbMorning.UseVisualStyleBackColor = true;
			// 
			// lblSalary
			// 
			lblSalary.AutoSize = true;
			lblSalary.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblSalary.Location = new Point(94, 354);
			lblSalary.Name = "lblSalary";
			lblSalary.Size = new Size(60, 18);
			lblSalary.TabIndex = 70;
			lblSalary.Text = "Salary:";
			// 
			// lblAvailability
			// 
			lblAvailability.AutoSize = true;
			lblAvailability.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblAvailability.Location = new Point(59, 393);
			lblAvailability.Name = "lblAvailability";
			lblAvailability.Size = new Size(91, 18);
			lblAvailability.TabIndex = 69;
			lblAvailability.Text = "Availability:";
			// 
			// lblPhone
			// 
			lblPhone.AutoSize = true;
			lblPhone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPhone.Location = new Point(31, 252);
			lblPhone.Name = "lblPhone";
			lblPhone.Size = new Size(122, 18);
			lblPhone.TabIndex = 68;
			lblPhone.Text = "Phone number:";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblEmail.Location = new Point(101, 179);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(55, 18);
			lblEmail.TabIndex = 67;
			lblEmail.Text = "Email:";
			// 
			// lblDepartment
			// 
			lblDepartment.AutoSize = true;
			lblDepartment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDepartment.Location = new Point(58, 211);
			lblDepartment.Name = "lblDepartment";
			lblDepartment.Size = new Size(100, 18);
			lblDepartment.TabIndex = 66;
			lblDepartment.Text = "Department:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPassword.Location = new Point(67, 144);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(88, 18);
			lblPassword.TabIndex = 65;
			lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblUsername.Location = new Point(65, 107);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(90, 18);
			lblUsername.TabIndex = 64;
			lblUsername.Text = "Username:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.Location = new Point(99, 74);
			lblName.Name = "lblName";
			lblName.Size = new Size(57, 18);
			lblName.TabIndex = 63;
			lblName.Text = "Name:";
			// 
			// EmployeeEditForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 561);
			Controls.Add(dtpDOB);
			Controls.Add(lblDOB);
			Controls.Add(tbBSN);
			Controls.Add(lblBSN);
			Controls.Add(btnEdit);
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
			Controls.Add(lblEdit);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "EmployeeEditForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Edit an employee";
			((System.ComponentModel.ISupportInitialize)numUDSalary).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblEdit;
		private DateTimePicker dtpDOB;
		private Label lblDOB;
		private TextBox tbBSN;
		private Label lblBSN;
		private Button btnEdit;
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
	}
}