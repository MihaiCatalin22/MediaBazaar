namespace Desktop_application
{
    partial class AdminShiftsForm
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
            lbEveningShifts = new ListBox();
            lbAfternoonShifts = new ListBox();
            lbMorningShifts = new ListBox();
            btnAdd3 = new Button();
            btnAdd2 = new Button();
            btnAdd1 = new Button();
            lblEvening = new Label();
            lblAfternoon = new Label();
            lblMorning = new Label();
            btnRefresh = new Button();
            btnCheck = new Button();
            lblCalendar = new Label();
            cbDepartment = new ComboBox();
            lblDepartment = new Label();
            lblShiftsPage = new Label();
            lblShifts = new Label();
            lblDepartments = new Label();
            lblEmployees = new Label();
            lblAnnouncements = new Label();
            monthCalendar1 = new MonthCalendar();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbEveningShifts
            // 
            lbEveningShifts.FormattingEnabled = true;
            lbEveningShifts.ItemHeight = 20;
            lbEveningShifts.Location = new Point(925, 376);
            lbEveningShifts.Margin = new Padding(3, 4, 3, 4);
            lbEveningShifts.Name = "lbEveningShifts";
            lbEveningShifts.Size = new Size(130, 244);
            lbEveningShifts.TabIndex = 34;
            // 
            // lbAfternoonShifts
            // 
            lbAfternoonShifts.FormattingEnabled = true;
            lbAfternoonShifts.ItemHeight = 20;
            lbAfternoonShifts.Location = new Point(710, 376);
            lbAfternoonShifts.Margin = new Padding(3, 4, 3, 4);
            lbAfternoonShifts.Name = "lbAfternoonShifts";
            lbAfternoonShifts.Size = new Size(130, 244);
            lbAfternoonShifts.TabIndex = 33;
            // 
            // lbMorningShifts
            // 
            lbMorningShifts.FormattingEnabled = true;
            lbMorningShifts.ItemHeight = 20;
            lbMorningShifts.Location = new Point(515, 376);
            lbMorningShifts.Margin = new Padding(3, 4, 3, 4);
            lbMorningShifts.Name = "lbMorningShifts";
            lbMorningShifts.Size = new Size(128, 244);
            lbMorningShifts.TabIndex = 32;
            // 
            // btnAdd3
            // 
            btnAdd3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd3.Location = new Point(925, 307);
            btnAdd3.Margin = new Padding(3, 4, 3, 4);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(130, 44);
            btnAdd3.TabIndex = 31;
            btnAdd3.Text = "Add shift";
            btnAdd3.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            btnAdd2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd2.Location = new Point(710, 306);
            btnAdd2.Margin = new Padding(3, 4, 3, 4);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(130, 44);
            btnAdd2.TabIndex = 30;
            btnAdd2.Text = "Add shift";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // btnAdd1
            // 
            btnAdd1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd1.Location = new Point(513, 307);
            btnAdd1.Margin = new Padding(3, 4, 3, 4);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(130, 44);
            btnAdd1.TabIndex = 29;
            btnAdd1.Text = "Add shift";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // lblEvening
            // 
            lblEvening.AutoSize = true;
            lblEvening.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEvening.Location = new Point(922, 271);
            lblEvening.Name = "lblEvening";
            lblEvening.Size = new Size(133, 25);
            lblEvening.TabIndex = 28;
            lblEvening.Text = "Evening shifts";
            // 
            // lblAfternoon
            // 
            lblAfternoon.AutoSize = true;
            lblAfternoon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAfternoon.Location = new Point(705, 271);
            lblAfternoon.Name = "lblAfternoon";
            lblAfternoon.Size = new Size(147, 25);
            lblAfternoon.TabIndex = 27;
            lblAfternoon.Text = "Afternoon shifts";
            // 
            // lblMorning
            // 
            lblMorning.AutoSize = true;
            lblMorning.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMorning.Location = new Point(510, 271);
            lblMorning.Name = "lblMorning";
            lblMorning.Size = new Size(133, 25);
            lblMorning.TabIndex = 26;
            lblMorning.Text = "Morning shifts";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(306, 601);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 65);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh calendar";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.Location = new Point(151, 601);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(108, 65);
            btnCheck.TabIndex = 24;
            btnCheck.Text = "Check day";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalendar.Location = new Point(64, 326);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(81, 20);
            lblCalendar.TabIndex = 22;
            lblCalendar.Text = "Calendar:";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(151, 266);
            cbDepartment.Margin = new Padding(3, 4, 3, 4);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(262, 28);
            cbDepartment.TabIndex = 21;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.Location = new Point(43, 266);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(102, 20);
            lblDepartment.TabIndex = 20;
            lblDepartment.Text = "Department:";
            // 
            // lblShiftsPage
            // 
            lblShiftsPage.AutoSize = true;
            lblShiftsPage.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblShiftsPage.Location = new Point(508, 171);
            lblShiftsPage.Name = "lblShiftsPage";
            lblShiftsPage.Size = new Size(146, 29);
            lblShiftsPage.TabIndex = 19;
            lblShiftsPage.Text = "Shifts Page";
            // 
            // lblShifts
            // 
            lblShifts.AutoSize = true;
            lblShifts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifts.Location = new Point(1035, 46);
            lblShifts.Name = "lblShifts";
            lblShifts.Size = new Size(67, 25);
            lblShifts.TabIndex = 3;
            lblShifts.Text = "Shifts";
            // 
            // lblDepartments
            // 
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartments.Location = new Point(689, 46);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new Size(134, 25);
            lblDepartments.TabIndex = 2;
            lblDepartments.Text = "Departments";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployees.Location = new Point(337, 46);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(118, 25);
            lblEmployees.TabIndex = 1;
            lblEmployees.Text = "Employees";
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(25, 46);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(168, 25);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(151, 326);
            monthCalendar1.Margin = new Padding(9, 11, 9, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(lblShifts);
            panel1.Controls.Add(lblDepartments);
            panel1.Controls.Add(lblEmployees);
            panel1.Controls.Add(lblAnnouncements);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 125);
            panel1.TabIndex = 18;
            // 
            // AdminShiftsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 691);
            Controls.Add(lbEveningShifts);
            Controls.Add(lbAfternoonShifts);
            Controls.Add(lbMorningShifts);
            Controls.Add(btnAdd3);
            Controls.Add(btnAdd2);
            Controls.Add(btnAdd1);
            Controls.Add(lblEvening);
            Controls.Add(lblAfternoon);
            Controls.Add(lblMorning);
            Controls.Add(btnRefresh);
            Controls.Add(btnCheck);
            Controls.Add(lblCalendar);
            Controls.Add(cbDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(lblShiftsPage);
            Controls.Add(monthCalendar1);
            Controls.Add(panel1);
            Name = "AdminShiftsForm";
            Text = "AdminShiftsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbEveningShifts;
        private ListBox lbAfternoonShifts;
        private ListBox lbMorningShifts;
        private Button btnAdd3;
        private Button btnAdd2;
        private Button btnAdd1;
        private Label lblEvening;
        private Label lblAfternoon;
        private Label lblMorning;
        private Button btnRefresh;
        private Button btnCheck;
        private Label lblCalendar;
        private ComboBox cbDepartment;
        private Label lblDepartment;
        private Label lblShiftsPage;
        private Label lblShifts;
        private Label lblDepartments;
        private Label lblEmployees;
        private Label lblAnnouncements;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
    }
}