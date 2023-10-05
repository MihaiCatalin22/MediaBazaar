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
            flowLayoutPanelEvening = new FlowLayoutPanel();
            flowLayoutPanelAfternoon = new FlowLayoutPanel();
            flowLayoutPanelMorning = new FlowLayoutPanel();
            lblSelectedDate = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd3
            // 
            btnAdd3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd3.Location = new Point(809, 230);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(114, 33);
            btnAdd3.TabIndex = 31;
            btnAdd3.Text = "Add shift";
            btnAdd3.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            btnAdd2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd2.Location = new Point(621, 230);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(114, 33);
            btnAdd2.TabIndex = 30;
            btnAdd2.Text = "Add shift";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // btnAdd1
            // 
            btnAdd1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd1.Location = new Point(449, 230);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(114, 33);
            btnAdd1.TabIndex = 29;
            btnAdd1.Text = "Add shift";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // lblEvening
            // 
            lblEvening.AutoSize = true;
            lblEvening.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEvening.Location = new Point(807, 203);
            lblEvening.Name = "lblEvening";
            lblEvening.Size = new Size(108, 20);
            lblEvening.TabIndex = 28;
            lblEvening.Text = "Evening shifts";
            // 
            // lblAfternoon
            // 
            lblAfternoon.AutoSize = true;
            lblAfternoon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAfternoon.Location = new Point(617, 203);
            lblAfternoon.Name = "lblAfternoon";
            lblAfternoon.Size = new Size(122, 20);
            lblAfternoon.TabIndex = 27;
            lblAfternoon.Text = "Afternoon shifts";
            // 
            // lblMorning
            // 
            lblMorning.AutoSize = true;
            lblMorning.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMorning.Location = new Point(446, 203);
            lblMorning.Name = "lblMorning";
            lblMorning.Size = new Size(108, 20);
            lblMorning.TabIndex = 26;
            lblMorning.Text = "Morning shifts";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(268, 451);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 49);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh calendar";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.Location = new Point(132, 451);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 49);
            btnCheck.TabIndex = 24;
            btnCheck.Text = "Check day";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalendar.Location = new Point(56, 244);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(69, 17);
            lblCalendar.TabIndex = 22;
            lblCalendar.Text = "Calendar:";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(133, 176);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(230, 23);
            cbDepartment.TabIndex = 21;
            cbDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.Location = new Point(39, 176);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(86, 17);
            lblDepartment.TabIndex = 20;
            lblDepartment.Text = "Department:";
            // 
            // lblShiftsPage
            // 
            lblShiftsPage.AutoSize = true;
            lblShiftsPage.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblShiftsPage.Location = new Point(444, 128);
            lblShiftsPage.Name = "lblShiftsPage";
            lblShiftsPage.Size = new Size(114, 24);
            lblShiftsPage.TabIndex = 19;
            lblShiftsPage.Text = "Shifts Page";
            // 
            // lblShifts
            // 
            lblShifts.AutoSize = true;
            lblShifts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifts.Location = new Point(906, 34);
            lblShifts.Name = "lblShifts";
            lblShifts.Size = new Size(56, 20);
            lblShifts.TabIndex = 3;
            lblShifts.Text = "Shifts";
            // 
            // lblDepartments
            // 
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartments.Location = new Point(603, 34);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new Size(113, 20);
            lblDepartments.TabIndex = 2;
            lblDepartments.Text = "Departments";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployees.Location = new Point(295, 34);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(96, 20);
            lblEmployees.TabIndex = 1;
            lblEmployees.Text = "Employees";
            lblEmployees.Click += lblEmployees_Click;
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(22, 34);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(139, 20);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            lblAnnouncements.Click += lblAnnouncements_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(132, 244);
            monthCalendar1.Margin = new Padding(8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(lblShifts);
            panel1.Controls.Add(lblDepartments);
            panel1.Controls.Add(lblEmployees);
            panel1.Controls.Add(lblAnnouncements);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 94);
            panel1.TabIndex = 18;
            // 
            // flowLayoutPanelEvening
            // 
            flowLayoutPanelEvening.AutoScroll = true;
            flowLayoutPanelEvening.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelEvening.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelEvening.Location = new Point(809, 282);
            flowLayoutPanelEvening.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelEvening.Name = "flowLayoutPanelEvening";
            flowLayoutPanelEvening.Size = new Size(114, 207);
            flowLayoutPanelEvening.TabIndex = 34;
            // 
            // flowLayoutPanelAfternoon
            // 
            flowLayoutPanelAfternoon.AutoScroll = true;
            flowLayoutPanelAfternoon.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelAfternoon.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelAfternoon.Location = new Point(621, 282);
            flowLayoutPanelAfternoon.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelAfternoon.Name = "flowLayoutPanelAfternoon";
            flowLayoutPanelAfternoon.Size = new Size(114, 207);
            flowLayoutPanelAfternoon.TabIndex = 33;
            // 
            // flowLayoutPanelMorning
            // 
            flowLayoutPanelMorning.AutoScroll = true;
            flowLayoutPanelMorning.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMorning.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelMorning.Location = new Point(449, 282);
            flowLayoutPanelMorning.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelMorning.Name = "flowLayoutPanelMorning";
            flowLayoutPanelMorning.Size = new Size(114, 207);
            flowLayoutPanelMorning.TabIndex = 32;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Location = new Point(132, 208);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(38, 15);
            lblSelectedDate.TabIndex = 35;
            lblSelectedDate.Text = "label1";
            // 
            // AdminShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 518);
            Controls.Add(lblSelectedDate);
            Controls.Add(flowLayoutPanelEvening);
            Controls.Add(flowLayoutPanelAfternoon);
            Controls.Add(flowLayoutPanelMorning);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminShiftsForm";
            Text = "AdminShiftsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private FlowLayoutPanel flowLayoutPanelEvening;
        private FlowLayoutPanel flowLayoutPanelAfternoon;
        private FlowLayoutPanel flowLayoutPanelMorning;
        private Label lblSelectedDate;
    }
}