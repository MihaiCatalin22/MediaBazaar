namespace Desktop_application
{
	partial class AdminLandingForm
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
			rbPostPonedAnnouncement = new RadioButton();
			rbPastAnnouncement = new RadioButton();
			rbAllAnnouncements = new RadioButton();
			rbCurrentAnnouncement = new RadioButton();
			btnResetFilters = new Button();
			gbFilters = new GroupBox();
			btnCreateAnno = new Button();
			lbAnnouncements = new ListBox();
			lblAnno = new Label();
			lblWelcome = new Label();
			lblAnnouncements = new Label();
			panel2 = new Panel();
			btnLogout = new Button();
			btnStocks = new Button();
			btnAnnouncements = new Button();
			btnDepartments = new Button();
			btnShifts = new Button();
			btnEmployees = new Button();
			gbFilters.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// rbPostPonedAnnouncement
			// 
			rbPostPonedAnnouncement.AutoSize = true;
			rbPostPonedAnnouncement.Location = new Point(12, 69);
			rbPostPonedAnnouncement.Name = "rbPostPonedAnnouncement";
			rbPostPonedAnnouncement.Size = new Size(176, 19);
			rbPostPonedAnnouncement.TabIndex = 21;
			rbPostPonedAnnouncement.TabStop = true;
			rbPostPonedAnnouncement.Text = "Post-poned announcements";
			rbPostPonedAnnouncement.UseVisualStyleBackColor = true;
			// 
			// rbPastAnnouncement
			// 
			rbPastAnnouncement.AutoSize = true;
			rbPastAnnouncement.Location = new Point(12, 20);
			rbPastAnnouncement.Name = "rbPastAnnouncement";
			rbPastAnnouncement.Size = new Size(136, 19);
			rbPastAnnouncement.TabIndex = 18;
			rbPastAnnouncement.TabStop = true;
			rbPastAnnouncement.Text = "Past announcements";
			rbPastAnnouncement.UseVisualStyleBackColor = true;
			// 
			// rbAllAnnouncements
			// 
			rbAllAnnouncements.AutoSize = true;
			rbAllAnnouncements.Location = new Point(12, 94);
			rbAllAnnouncements.Name = "rbAllAnnouncements";
			rbAllAnnouncements.Size = new Size(128, 19);
			rbAllAnnouncements.TabIndex = 20;
			rbAllAnnouncements.TabStop = true;
			rbAllAnnouncements.Text = "All announcements";
			rbAllAnnouncements.UseVisualStyleBackColor = true;
			// 
			// rbCurrentAnnouncement
			// 
			rbCurrentAnnouncement.AutoSize = true;
			rbCurrentAnnouncement.Location = new Point(12, 45);
			rbCurrentAnnouncement.Name = "rbCurrentAnnouncement";
			rbCurrentAnnouncement.Size = new Size(154, 19);
			rbCurrentAnnouncement.TabIndex = 19;
			rbCurrentAnnouncement.TabStop = true;
			rbCurrentAnnouncement.Text = "Current announcements";
			rbCurrentAnnouncement.UseVisualStyleBackColor = true;
			// 
			// btnResetFilters
			// 
			btnResetFilters.Location = new Point(39, 128);
			btnResetFilters.Name = "btnResetFilters";
			btnResetFilters.Size = new Size(96, 33);
			btnResetFilters.TabIndex = 15;
			btnResetFilters.Text = "Apply filters";
			btnResetFilters.UseVisualStyleBackColor = true;
			btnResetFilters.Click += btnResetFilters_Click;
			// 
			// gbFilters
			// 
			gbFilters.Controls.Add(rbPostPonedAnnouncement);
			gbFilters.Controls.Add(rbPastAnnouncement);
			gbFilters.Controls.Add(btnResetFilters);
			gbFilters.Controls.Add(rbAllAnnouncements);
			gbFilters.Controls.Add(rbCurrentAnnouncement);
			gbFilters.Location = new Point(507, 182);
			gbFilters.Name = "gbFilters";
			gbFilters.Size = new Size(200, 182);
			gbFilters.TabIndex = 40;
			gbFilters.TabStop = false;
			gbFilters.Text = "Filters";
			// 
			// btnCreateAnno
			// 
			btnCreateAnno.Location = new Point(207, 371);
			btnCreateAnno.Name = "btnCreateAnno";
			btnCreateAnno.Size = new Size(294, 52);
			btnCreateAnno.TabIndex = 37;
			btnCreateAnno.Text = "Create announcement";
			btnCreateAnno.UseVisualStyleBackColor = true;
			btnCreateAnno.Click += btnCreateAnno_Click;
			// 
			// lbAnnouncements
			// 
			lbAnnouncements.FormattingEnabled = true;
			lbAnnouncements.ItemHeight = 15;
			lbAnnouncements.Location = new Point(207, 182);
			lbAnnouncements.Name = "lbAnnouncements";
			lbAnnouncements.Size = new Size(294, 184);
			lbAnnouncements.TabIndex = 27;
			lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
			lbAnnouncements.MouseDoubleClick += lbAnnouncements_MouseDoubleClick;
			// 
			// lblAnno
			// 
			lblAnno.AutoSize = true;
			lblAnno.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblAnno.Location = new Point(207, 152);
			lblAnno.Name = "lblAnno";
			lblAnno.Size = new Size(96, 15);
			lblAnno.TabIndex = 26;
			lblAnno.Text = "Announcements";
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblWelcome.Location = new Point(39, 116);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(166, 18);
			lblWelcome.TabIndex = 25;
			lblWelcome.Text = "Welcome, ~~user~~!";
			// 
			// lblAnnouncements
			// 
			lblAnnouncements.AutoSize = true;
			lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblAnnouncements.Location = new Point(27, 226);
			lblAnnouncements.Name = "lblAnnouncements";
			lblAnnouncements.Size = new Size(0, 20);
			lblAnnouncements.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DimGray;
			panel2.Controls.Add(btnLogout);
			panel2.Controls.Add(btnStocks);
			panel2.Controls.Add(btnAnnouncements);
			panel2.Controls.Add(btnDepartments);
			panel2.Controls.Add(btnShifts);
			panel2.Controls.Add(btnEmployees);
			panel2.Location = new Point(1, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(864, 94);
			panel2.TabIndex = 41;
			// 
			// btnLogout
			// 
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogout.Location = new Point(702, 0);
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
			btnStocks.Location = new Point(556, -1);
			btnStocks.Margin = new Padding(3, 2, 3, 2);
			btnStocks.Name = "btnStocks";
			btnStocks.Size = new Size(140, 94);
			btnStocks.TabIndex = 45;
			btnStocks.Text = "Stocks";
			btnStocks.UseVisualStyleBackColor = true;
			btnStocks.Click += btnStocks_Click;
			// 
			// btnAnnouncements
			// 
			btnAnnouncements.FlatAppearance.BorderSize = 0;
			btnAnnouncements.FlatStyle = FlatStyle.Flat;
			btnAnnouncements.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnAnnouncements.Location = new Point(0, 0);
			btnAnnouncements.Margin = new Padding(3, 2, 3, 2);
			btnAnnouncements.Name = "btnAnnouncements";
			btnAnnouncements.Size = new Size(157, 94);
			btnAnnouncements.TabIndex = 41;
			btnAnnouncements.Text = "Announcements";
			btnAnnouncements.UseVisualStyleBackColor = true;
			btnAnnouncements.Click += button1_Click;
			// 
			// btnDepartments
			// 
			btnDepartments.FlatAppearance.BorderSize = 0;
			btnDepartments.FlatStyle = FlatStyle.Flat;
			btnDepartments.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnDepartments.Location = new Point(288, 0);
			btnDepartments.Margin = new Padding(3, 2, 3, 2);
			btnDepartments.Name = "btnDepartments";
			btnDepartments.Size = new Size(138, 94);
			btnDepartments.TabIndex = 43;
			btnDepartments.Text = "Departments";
			btnDepartments.UseVisualStyleBackColor = true;
			btnDepartments.Click += btnDepartments_Click;
			// 
			// btnShifts
			// 
			btnShifts.FlatAppearance.BorderSize = 0;
			btnShifts.FlatStyle = FlatStyle.Flat;
			btnShifts.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			btnShifts.Location = new Point(432, -1);
			btnShifts.Margin = new Padding(3, 2, 3, 2);
			btnShifts.Name = "btnShifts";
			btnShifts.Size = new Size(118, 94);
			btnShifts.TabIndex = 44;
			btnShifts.Text = "Shifts";
			btnShifts.UseVisualStyleBackColor = true;
			btnShifts.Click += btnShifts_Click;
			// 
			// btnEmployees
			// 
			btnEmployees.FlatAppearance.BorderSize = 0;
			btnEmployees.FlatStyle = FlatStyle.Flat;
			btnEmployees.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnEmployees.Location = new Point(163, 0);
			btnEmployees.Margin = new Padding(3, 2, 3, 2);
			btnEmployees.Name = "btnEmployees";
			btnEmployees.Size = new Size(119, 94);
			btnEmployees.TabIndex = 42;
			btnEmployees.Text = "Employees";
			btnEmployees.UseVisualStyleBackColor = true;
			btnEmployees.Click += btnEmployees_Click;
			// 
			// AdminLandingForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(836, 467);
			Controls.Add(panel2);
			Controls.Add(gbFilters);
			Controls.Add(lblAnnouncements);
			Controls.Add(btnCreateAnno);
			Controls.Add(lbAnnouncements);
			Controls.Add(lblAnno);
			Controls.Add(lblWelcome);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "AdminLandingForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main page";
			Load += AdminLandingForm_Load;
			gbFilters.ResumeLayout(false);
			gbFilters.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private RadioButton rbPostPonedAnnouncement;
		private RadioButton rbPastAnnouncement;
		private RadioButton rbAllAnnouncements;
		private RadioButton rbCurrentAnnouncement;
		private Button btnResetFilters;
		private GroupBox gbFilters;
		private Button btnCreateAnno;
		private ListBox lbAnnouncements;
		private Label lblAnno;
		private Label lblWelcome;
		private Label lblAnnouncements;
		private Panel panel2;
		private Button btnLogout;
		private Button btnStocks;
		private Button btnAnnouncements;
		private Button btnDepartments;
		private Button btnShifts;
		private Button btnEmployees;
	}
}