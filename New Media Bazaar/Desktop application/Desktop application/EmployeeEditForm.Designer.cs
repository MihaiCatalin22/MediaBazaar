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
			lblEdit.Location = new Point(139, 40);
			lblEdit.Name = "lblEdit";
			lblEdit.Size = new Size(215, 36);
			lblEdit.TabIndex = 62;
			lblEdit.Text = "Edit employee";
			// 
			// dtpDOB
			// 
			dtpDOB.Location = new Point(201, 425);
			dtpDOB.Name = "dtpDOB";
			dtpDOB.Size = new Size(245, 27);
			dtpDOB.TabIndex = 86;
			// 
			// lblDOB
			// 
			lblDOB.AutoSize = true;
			lblDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDOB.Location = new Point(53, 425);
			lblDOB.Name = "lblDOB";
			lblDOB.Size = new Size(127, 22);
			lblDOB.TabIndex = 85;
			lblDOB.Text = "Date of birth:";
			// 
			// tbBSN
			// 
			tbBSN.Location = new Point(201, 382);
			tbBSN.Margin = new Padding(3, 4, 3, 4);
			tbBSN.MaxLength = 9;
			tbBSN.Name = "tbBSN";
			tbBSN.Size = new Size(245, 27);
			tbBSN.TabIndex = 84;
			// 
			// lblBSN
			// 
			lblBSN.AutoSize = true;
			lblBSN.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblBSN.Location = new Point(124, 383);
			lblBSN.Name = "lblBSN";
			lblBSN.Size = new Size(56, 22);
			lblBSN.TabIndex = 83;
			lblBSN.Text = "BSN:";
			// 
			// btnEdit
			// 
			btnEdit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnEdit.Location = new Point(324, 650);
			btnEdit.Margin = new Padding(3, 4, 3, 4);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(92, 68);
			btnEdit.TabIndex = 82;
			btnEdit.Text = "Edit employee";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(80, 650);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 68);
			btnBack.TabIndex = 81;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// tbName
			// 
			tbName.Location = new Point(202, 99);
			tbName.Margin = new Padding(3, 4, 3, 4);
			tbName.Name = "tbName";
			tbName.Size = new Size(244, 27);
			tbName.TabIndex = 80;
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(202, 146);
			tbUsername.Margin = new Padding(3, 4, 3, 4);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(244, 27);
			tbUsername.TabIndex = 79;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(202, 195);
			tbPassword.Margin = new Padding(3, 4, 3, 4);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(244, 27);
			tbPassword.TabIndex = 78;
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(202, 242);
			tbEmail.Margin = new Padding(3, 4, 3, 4);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(244, 27);
			tbEmail.TabIndex = 77;
			// 
			// cbDepartment
			// 
			cbDepartment.FormattingEnabled = true;
			cbDepartment.Location = new Point(201, 283);
			cbDepartment.Margin = new Padding(3, 4, 3, 4);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(245, 28);
			cbDepartment.TabIndex = 76;
			// 
			// tbPhone
			// 
			tbPhone.Location = new Point(201, 335);
			tbPhone.Margin = new Padding(3, 4, 3, 4);
			tbPhone.MaxLength = 12;
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(245, 27);
			tbPhone.TabIndex = 75;
			// 
			// numUDSalary
			// 
			numUDSalary.DecimalPlaces = 2;
			numUDSalary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			numUDSalary.Location = new Point(201, 472);
			numUDSalary.Margin = new Padding(3, 4, 3, 4);
			numUDSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numUDSalary.Name = "numUDSalary";
			numUDSalary.Size = new Size(245, 27);
			numUDSalary.TabIndex = 74;
			// 
			// ckbEvening
			// 
			ckbEvening.AutoSize = true;
			ckbEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbEvening.Location = new Point(201, 592);
			ckbEvening.Margin = new Padding(3, 4, 3, 4);
			ckbEvening.Name = "ckbEvening";
			ckbEvening.Size = new Size(127, 24);
			ckbEvening.TabIndex = 73;
			ckbEvening.Text = "Evening shift";
			ckbEvening.UseVisualStyleBackColor = true;
			// 
			// ckbAfternoon
			// 
			ckbAfternoon.AutoSize = true;
			ckbAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbAfternoon.Location = new Point(201, 558);
			ckbAfternoon.Margin = new Padding(3, 4, 3, 4);
			ckbAfternoon.Name = "ckbAfternoon";
			ckbAfternoon.Size = new Size(140, 24);
			ckbAfternoon.TabIndex = 72;
			ckbAfternoon.Text = "Afternoon shift";
			ckbAfternoon.UseVisualStyleBackColor = true;
			// 
			// ckbMorning
			// 
			ckbMorning.AutoSize = true;
			ckbMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ckbMorning.Location = new Point(201, 525);
			ckbMorning.Margin = new Padding(3, 4, 3, 4);
			ckbMorning.Name = "ckbMorning";
			ckbMorning.Size = new Size(128, 24);
			ckbMorning.TabIndex = 71;
			ckbMorning.Text = "Morning shift";
			ckbMorning.UseVisualStyleBackColor = true;
			// 
			// lblSalary
			// 
			lblSalary.AutoSize = true;
			lblSalary.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblSalary.Location = new Point(107, 472);
			lblSalary.Name = "lblSalary";
			lblSalary.Size = new Size(73, 22);
			lblSalary.TabIndex = 70;
			lblSalary.Text = "Salary:";
			// 
			// lblAvailability
			// 
			lblAvailability.AutoSize = true;
			lblAvailability.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblAvailability.Location = new Point(67, 524);
			lblAvailability.Name = "lblAvailability";
			lblAvailability.Size = new Size(113, 22);
			lblAvailability.TabIndex = 69;
			lblAvailability.Text = "Availability:";
			// 
			// lblPhone
			// 
			lblPhone.AutoSize = true;
			lblPhone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPhone.Location = new Point(35, 336);
			lblPhone.Name = "lblPhone";
			lblPhone.Size = new Size(145, 22);
			lblPhone.TabIndex = 68;
			lblPhone.Text = "Phone number:";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblEmail.Location = new Point(115, 239);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(65, 22);
			lblEmail.TabIndex = 67;
			lblEmail.Text = "Email:";
			// 
			// lblDepartment
			// 
			lblDepartment.AutoSize = true;
			lblDepartment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDepartment.Location = new Point(66, 281);
			lblDepartment.Name = "lblDepartment";
			lblDepartment.Size = new Size(119, 22);
			lblDepartment.TabIndex = 66;
			lblDepartment.Text = "Department:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblPassword.Location = new Point(77, 192);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(103, 22);
			lblPassword.TabIndex = 65;
			lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblUsername.Location = new Point(74, 143);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(106, 22);
			lblUsername.TabIndex = 64;
			lblUsername.Text = "Username:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.Location = new Point(113, 99);
			lblName.Name = "lblName";
			lblName.Size = new Size(67, 22);
			lblName.TabIndex = 63;
			lblName.Text = "Name:";
			// 
			// EmployeeEditForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(482, 748);
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
			Name = "EmployeeEditForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EmployeeEditForm";
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