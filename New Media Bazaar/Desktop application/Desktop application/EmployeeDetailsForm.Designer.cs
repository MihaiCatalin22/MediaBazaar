namespace Desktop_application
{
    partial class EmployeeDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailsForm));
            cbEvening = new CheckBox();
            cbAfternoon = new CheckBox();
            cbMorning = new CheckBox();
            btnBack = new Button();
            btnApply = new Button();
            lbWorkedShifts = new ListBox();
            lbFutureShifts = new ListBox();
            lblDate = new Label();
            numUDSalary = new NumericUpDown();
            cbDepartment = new ComboBox();
            tbUsername = new TextBox();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            lblSalary = new Label();
            lblShiftsWorked = new Label();
            lblFutShifts = new Label();
            lblAvailableTime = new Label();
            lblHireDate = new Label();
            lblDepartment = new Label();
            lblUsername = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblEmpDetails = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numUDSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbEvening
            // 
            cbEvening.AutoSize = true;
            cbEvening.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbEvening.Location = new Point(342, 561);
            cbEvening.Margin = new Padding(3, 4, 3, 4);
            cbEvening.Name = "cbEvening";
            cbEvening.Size = new Size(113, 22);
            cbEvening.TabIndex = 52;
            cbEvening.Text = "Evening shift";
            cbEvening.UseVisualStyleBackColor = true;
            // 
            // cbAfternoon
            // 
            cbAfternoon.AutoSize = true;
            cbAfternoon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbAfternoon.Location = new Point(342, 527);
            cbAfternoon.Margin = new Padding(3, 4, 3, 4);
            cbAfternoon.Name = "cbAfternoon";
            cbAfternoon.Size = new Size(125, 22);
            cbAfternoon.TabIndex = 51;
            cbAfternoon.Text = "Afternoon shift";
            cbAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbMorning
            // 
            cbMorning.AutoSize = true;
            cbMorning.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbMorning.Location = new Point(342, 494);
            cbMorning.Margin = new Padding(3, 4, 3, 4);
            cbMorning.Name = "cbMorning";
            cbMorning.Size = new Size(115, 22);
            cbMorning.TabIndex = 50;
            cbMorning.Text = "Morning shift";
            cbMorning.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Firebrick;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1120, 0);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 40);
            btnBack.TabIndex = 49;
            btnBack.Text = "X";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.MediumSeaGreen;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(221, 601);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(785, 47);
            btnApply.TabIndex = 48;
            btnApply.Text = "Apply changes";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // lbWorkedShifts
            // 
            lbWorkedShifts.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbWorkedShifts.FormattingEnabled = true;
            lbWorkedShifts.ItemHeight = 23;
            lbWorkedShifts.Location = new Point(717, 380);
            lbWorkedShifts.Margin = new Padding(3, 4, 3, 4);
            lbWorkedShifts.Name = "lbWorkedShifts";
            lbWorkedShifts.Size = new Size(289, 165);
            lbWorkedShifts.TabIndex = 47;
            // 
            // lbFutureShifts
            // 
            lbFutureShifts.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFutureShifts.FormattingEnabled = true;
            lbFutureShifts.ItemHeight = 23;
            lbFutureShifts.Location = new Point(717, 156);
            lbFutureShifts.Margin = new Padding(3, 4, 3, 4);
            lbFutureShifts.Name = "lbFutureShifts";
            lbFutureShifts.Size = new Size(289, 165);
            lbFutureShifts.TabIndex = 46;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(338, 324);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(68, 20);
            lblDate.TabIndex = 45;
            lblDate.Text = "LblDate";
            // 
            // numUDSalary
            // 
            numUDSalary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            numUDSalary.Location = new Point(364, 397);
            numUDSalary.Margin = new Padding(3, 4, 3, 4);
            numUDSalary.Name = "numUDSalary";
            numUDSalary.Size = new Size(120, 27);
            numUDSalary.TabIndex = 44;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(342, 265);
            cbDepartment.Margin = new Padding(3, 4, 3, 4);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(121, 28);
            cbDepartment.TabIndex = 43;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(342, 223);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(100, 27);
            tbUsername.TabIndex = 42;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(342, 187);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(100, 27);
            tbPhone.TabIndex = 41;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(342, 153);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(100, 27);
            tbEmail.TabIndex = 40;
            // 
            // tbName
            // 
            tbName.Location = new Point(342, 117);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 27);
            tbName.TabIndex = 39;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalary.Location = new Point(246, 391);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(81, 25);
            lblSalary.TabIndex = 38;
            lblSalary.Text = "Salary:";
            // 
            // lblShiftsWorked
            // 
            lblShiftsWorked.AutoSize = true;
            lblShiftsWorked.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShiftsWorked.Location = new Point(712, 345);
            lblShiftsWorked.Name = "lblShiftsWorked";
            lblShiftsWorked.Size = new Size(149, 25);
            lblShiftsWorked.TabIndex = 37;
            lblShiftsWorked.Text = "Shifts worked:";
            // 
            // lblFutShifts
            // 
            lblFutShifts.AutoSize = true;
            lblFutShifts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFutShifts.Location = new Point(712, 121);
            lblFutShifts.Name = "lblFutShifts";
            lblFutShifts.Size = new Size(138, 25);
            lblFutShifts.TabIndex = 36;
            lblFutShifts.Text = "Future shifts:";
            // 
            // lblAvailableTime
            // 
            lblAvailableTime.AutoSize = true;
            lblAvailableTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableTime.Location = new Point(204, 494);
            lblAvailableTime.Name = "lblAvailableTime";
            lblAvailableTime.Size = new Size(123, 25);
            lblAvailableTime.TabIndex = 35;
            lblAvailableTime.Text = "Availability:";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHireDate.Location = new Point(221, 324);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(106, 25);
            lblHireDate.TabIndex = 34;
            lblHireDate.Text = "Hire date:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.Location = new Point(204, 265);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(130, 25);
            lblDepartment.TabIndex = 33;
            lblDepartment.Text = "Department:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(219, 219);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 25);
            lblUsername.TabIndex = 32;
            lblUsername.Text = "Username:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.Location = new Point(176, 187);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(159, 25);
            lblPhone.TabIndex = 31;
            lblPhone.Text = "Phone number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(260, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 25);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(260, 121);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 25);
            lblName.TabIndex = 29;
            lblName.Text = "Name:";
            // 
            // lblEmpDetails
            // 
            lblEmpDetails.AutoSize = true;
            lblEmpDetails.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpDetails.Location = new Point(492, 26);
            lblEmpDetails.Name = "lblEmpDetails";
            lblEmpDetails.Size = new Size(248, 32);
            lblEmpDetails.TabIndex = 28;
            lblEmpDetails.Text = "Employee details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(342, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 4);
            panel3.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(342, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 4);
            panel1.TabIndex = 55;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(342, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 4);
            panel2.TabIndex = 56;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(342, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(100, 4);
            panel4.TabIndex = 57;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(342, 290);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 4);
            panel5.TabIndex = 58;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(364, 421);
            panel6.Name = "panel6";
            panel6.Size = new Size(120, 4);
            panel6.TabIndex = 59;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(717, 317);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 4);
            panel7.TabIndex = 60;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(717, 545);
            panel8.Name = "panel8";
            panel8.Size = new Size(289, 4);
            panel8.TabIndex = 61;
            // 
            // EmployeeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 691);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(cbEvening);
            Controls.Add(cbAfternoon);
            Controls.Add(cbMorning);
            Controls.Add(btnBack);
            Controls.Add(btnApply);
            Controls.Add(lbWorkedShifts);
            Controls.Add(lbFutureShifts);
            Controls.Add(lblDate);
            Controls.Add(numUDSalary);
            Controls.Add(cbDepartment);
            Controls.Add(tbUsername);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(lblSalary);
            Controls.Add(lblShiftsWorked);
            Controls.Add(lblFutShifts);
            Controls.Add(lblAvailableTime);
            Controls.Add(lblHireDate);
            Controls.Add(lblDepartment);
            Controls.Add(lblUsername);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblEmpDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDetailsForm";
            Text = "EmployeeDetailsForm";
            ((System.ComponentModel.ISupportInitialize)numUDSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbEvening;
        private CheckBox cbAfternoon;
        private CheckBox cbMorning;
        private Button btnBack;
        private Button btnApply;
        private ListBox lbWorkedShifts;
        private ListBox lbFutureShifts;
        private Label lblDate;
        private NumericUpDown numUDSalary;
        private ComboBox cbDepartment;
        private TextBox tbUsername;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label lblSalary;
        private Label lblShiftsWorked;
        private Label lblFutShifts;
        private Label lblAvailableTime;
        private Label lblHireDate;
        private Label lblDepartment;
        private Label lblUsername;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblName;
        private Label lblEmpDetails;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
    }
}