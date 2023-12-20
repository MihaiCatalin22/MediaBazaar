namespace Desktop_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAddForm));
            btnAdd = new Button();
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
            BtnExitEmployeeAddForm = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numUDSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(46, 655);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(412, 48);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            tbUsername.Location = new Point(195, 155);
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
            tbEmail.Location = new Point(195, 251);
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
            ckbAfternoon.Location = new Point(194, 565);
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
            lblSalary.Location = new Point(101, 480);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(73, 22);
            lblSalary.TabIndex = 29;
            lblSalary.Text = "Salary:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailability.Location = new Point(59, 532);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(113, 22);
            lblAvailability.TabIndex = 28;
            lblAvailability.Text = "Availability:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.Location = new Point(27, 344);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(145, 22);
            lblPhone.TabIndex = 27;
            lblPhone.Text = "Phone number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(107, 247);
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
            lblNewEmployee.Location = new Point(117, 56);
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
            tbBSN.Location = new Point(194, 389);
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
            // BtnExitEmployeeAddForm
            // 
            BtnExitEmployeeAddForm.BackColor = Color.Firebrick;
            BtnExitEmployeeAddForm.FlatAppearance.BorderSize = 0;
            BtnExitEmployeeAddForm.FlatStyle = FlatStyle.Flat;
            BtnExitEmployeeAddForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExitEmployeeAddForm.ForeColor = Color.White;
            BtnExitEmployeeAddForm.Location = new Point(435, -2);
            BtnExitEmployeeAddForm.Name = "BtnExitEmployeeAddForm";
            BtnExitEmployeeAddForm.Size = new Size(49, 37);
            BtnExitEmployeeAddForm.TabIndex = 64;
            BtnExitEmployeeAddForm.Text = "X";
            BtnExitEmployeeAddForm.UseVisualStyleBackColor = false;
            BtnExitEmployeeAddForm.Click += BtnExitEmployeeAddForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(195, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 4);
            panel1.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(195, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 4);
            panel2.TabIndex = 67;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(194, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 4);
            panel3.TabIndex = 68;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(195, 274);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 4);
            panel4.TabIndex = 69;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(194, 315);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 4);
            panel5.TabIndex = 70;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(195, 366);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 4);
            panel6.TabIndex = 71;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(195, 412);
            panel7.Name = "panel7";
            panel7.Size = new Size(244, 4);
            panel7.TabIndex = 72;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(194, 456);
            panel8.Name = "panel8";
            panel8.Size = new Size(244, 4);
            panel8.TabIndex = 73;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(194, 503);
            panel9.Name = "panel9";
            panel9.Size = new Size(244, 4);
            panel9.TabIndex = 74;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(46, 699);
            panel10.Name = "panel10";
            panel10.Size = new Size(412, 4);
            panel10.TabIndex = 75;
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 748);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnExitEmployeeAddForm);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(tbBSN);
            Controls.Add(lblBSN);
            Controls.Add(btnAdd);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add an employee";
            Load += EmployeeAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUDSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
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
        private Button BtnExitEmployeeAddForm;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}