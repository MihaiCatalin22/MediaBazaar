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
            btnAddEvening = new Button();
            btnAddAfternoon = new Button();
            btnAddMorning = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddEvening
            // 
            btnAddEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEvening.Location = new Point(925, 307);
            btnAddEvening.Margin = new Padding(3, 4, 3, 4);
            btnAddEvening.Name = "btnAddEvening";
            btnAddEvening.Size = new Size(130, 44);
            btnAddEvening.TabIndex = 31;
            btnAddEvening.Text = "Add shift";
            btnAddEvening.UseVisualStyleBackColor = true;
            btnAddEvening.Click += btnAddEvening_Click;
            // 
            // btnAddAfternoon
            // 
            btnAddAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAfternoon.Location = new Point(710, 307);
            btnAddAfternoon.Margin = new Padding(3, 4, 3, 4);
            btnAddAfternoon.Name = "btnAddAfternoon";
            btnAddAfternoon.Size = new Size(130, 44);
            btnAddAfternoon.TabIndex = 30;
            btnAddAfternoon.Text = "Add shift";
            btnAddAfternoon.UseVisualStyleBackColor = true;
            btnAddAfternoon.Click += btnAddAfternoon_Click;
            // 
            // btnAddMorning
            // 
            btnAddMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMorning.Location = new Point(513, 307);
            btnAddMorning.Margin = new Padding(3, 4, 3, 4);
            btnAddMorning.Name = "btnAddMorning";
            btnAddMorning.Size = new Size(130, 44);
            btnAddMorning.TabIndex = 29;
            btnAddMorning.Text = "Add shift";
            btnAddMorning.UseVisualStyleBackColor = true;
            btnAddMorning.Click += btnAddMorning_Click;
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
            btnCheck.Size = new Size(107, 65);
            btnCheck.TabIndex = 24;
            btnCheck.Text = "Check day";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalendar.Location = new Point(64, 325);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(81, 20);
            lblCalendar.TabIndex = 22;
            lblCalendar.Text = "Calendar:";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(152, 235);
            cbDepartment.Margin = new Padding(3, 4, 3, 4);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(262, 28);
            cbDepartment.TabIndex = 21;
            cbDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.Location = new Point(45, 235);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(102, 20);
            lblDepartment.TabIndex = 20;
            lblDepartment.Text = "Department:";
            // 
            // lblShiftsPage
            // 
            lblShiftsPage.AutoSize = true;
            lblShiftsPage.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblShiftsPage.Location = new Point(507, 171);
            lblShiftsPage.Name = "lblShiftsPage";
            lblShiftsPage.Size = new Size(146, 29);
            lblShiftsPage.TabIndex = 19;
            lblShiftsPage.Text = "Shifts Page";
            // 
            // lblShifts
            // 
            lblShifts.AutoSize = true;
            lblShifts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifts.Location = new Point(1035, 45);
            lblShifts.Name = "lblShifts";
            lblShifts.Size = new Size(67, 25);
            lblShifts.TabIndex = 3;
            lblShifts.Text = "Shifts";
            // 
            // lblDepartments
            // 
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartments.Location = new Point(689, 45);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new Size(134, 25);
            lblDepartments.TabIndex = 2;
            lblDepartments.Text = "Departments";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployees.Location = new Point(337, 45);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(118, 25);
            lblEmployees.TabIndex = 1;
            lblEmployees.Text = "Employees";
            lblEmployees.Click += lblEmployees_Click;
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(25, 45);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(168, 25);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            lblAnnouncements.Click += lblAnnouncements_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(151, 325);
            monthCalendar1.Margin = new Padding(9, 11, 9, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 125);
            panel1.TabIndex = 18;
            // 
            // flowLayoutPanelEvening
            // 
            flowLayoutPanelEvening.AutoScroll = true;
            flowLayoutPanelEvening.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelEvening.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelEvening.Location = new Point(925, 376);
            flowLayoutPanelEvening.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelEvening.Name = "flowLayoutPanelEvening";
            flowLayoutPanelEvening.Size = new Size(130, 276);
            flowLayoutPanelEvening.TabIndex = 34;
            // 
            // flowLayoutPanelAfternoon
            // 
            flowLayoutPanelAfternoon.AutoScroll = true;
            flowLayoutPanelAfternoon.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelAfternoon.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelAfternoon.Location = new Point(710, 376);
            flowLayoutPanelAfternoon.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelAfternoon.Name = "flowLayoutPanelAfternoon";
            flowLayoutPanelAfternoon.Size = new Size(130, 276);
            flowLayoutPanelAfternoon.TabIndex = 33;
            // 
            // flowLayoutPanelMorning
            // 
            flowLayoutPanelMorning.AutoScroll = true;
            flowLayoutPanelMorning.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMorning.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelMorning.Location = new Point(513, 376);
            flowLayoutPanelMorning.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelMorning.Name = "flowLayoutPanelMorning";
            flowLayoutPanelMorning.Size = new Size(130, 276);
            flowLayoutPanelMorning.TabIndex = 32;
            // 
            // AdminShiftsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 691);
            Controls.Add(flowLayoutPanelEvening);
            Controls.Add(flowLayoutPanelAfternoon);
            Controls.Add(flowLayoutPanelMorning);
            Controls.Add(btnAddEvening);
            Controls.Add(btnAddAfternoon);
            Controls.Add(btnAddMorning);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminShiftsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminShiftsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddEvening;
        private Button btnAddAfternoon;
        private Button btnAddMorning;
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
    }
}