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
			monthCalendar1 = new MonthCalendar();
			flowLayoutPanelEvening = new FlowLayoutPanel();
			flowLayoutPanelAfternoon = new FlowLayoutPanel();
			flowLayoutPanelMorning = new FlowLayoutPanel();
			panel2 = new Panel();
			btnLogout = new Button();
			btnStocks = new Button();
			bttnAnnouncement = new Button();
			btnDepartments = new Button();
			bttnShifts = new Button();
			bttnEmployees = new Button();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnAddEvening
			// 
			btnAddEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddEvening.Location = new Point(809, 230);
			btnAddEvening.Name = "btnAddEvening";
			btnAddEvening.Size = new Size(114, 33);
			btnAddEvening.TabIndex = 31;
			btnAddEvening.Text = "Add shift";
			btnAddEvening.UseVisualStyleBackColor = true;
			btnAddEvening.Click += btnAddEvening_Click;
			// 
			// btnAddAfternoon
			// 
			btnAddAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddAfternoon.Location = new Point(621, 230);
			btnAddAfternoon.Name = "btnAddAfternoon";
			btnAddAfternoon.Size = new Size(114, 33);
			btnAddAfternoon.TabIndex = 30;
			btnAddAfternoon.Text = "Add shift";
			btnAddAfternoon.UseVisualStyleBackColor = true;
			btnAddAfternoon.Click += btnAddAfternoon_Click;
			// 
			// btnAddMorning
			// 
			btnAddMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddMorning.Location = new Point(449, 230);
			btnAddMorning.Name = "btnAddMorning";
			btnAddMorning.Size = new Size(114, 33);
			btnAddMorning.TabIndex = 29;
			btnAddMorning.Text = "Add shift";
			btnAddMorning.UseVisualStyleBackColor = true;
			btnAddMorning.Click += btnAddMorning_Click;
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
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(132, 244);
			monthCalendar1.Margin = new Padding(8);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 23;
			monthCalendar1.DateSelected += monthCalendar1_DateSelected;
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
			// panel2
			// 
			panel2.BackColor = Color.DimGray;
			panel2.Controls.Add(btnLogout);
			panel2.Controls.Add(btnStocks);
			panel2.Controls.Add(bttnAnnouncement);
			panel2.Controls.Add(btnDepartments);
			panel2.Controls.Add(bttnShifts);
			panel2.Controls.Add(bttnEmployees);
			panel2.Location = new Point(1, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1033, 94);
			panel2.TabIndex = 35;
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
			// AdminShiftsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1034, 518);
			Controls.Add(panel2);
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
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "AdminShiftsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Shifts";
			panel2.ResumeLayout(false);
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
        private MonthCalendar monthCalendar1;
        private FlowLayoutPanel flowLayoutPanelEvening;
        private FlowLayoutPanel flowLayoutPanelAfternoon;
        private FlowLayoutPanel flowLayoutPanelMorning;
		private Panel panel2;
		private Button btnLogout;
		private Button btnStocks;
		private Button bttnAnnouncement;
		private Button btnDepartments;
		private Button bttnShifts;
		private Button bttnEmployees;
	}
}