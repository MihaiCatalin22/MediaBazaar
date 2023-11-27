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
            panel1 = new Panel();
            button2 = new Button();
            bttnShifts = new Button();
            bttnEmployees = new Button();
            bttnAnnouncement = new Button();
            gbFilters.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbPostPonedAnnouncement
            // 
            rbPostPonedAnnouncement.AutoSize = true;
            rbPostPonedAnnouncement.Location = new Point(14, 92);
            rbPostPonedAnnouncement.Margin = new Padding(3, 4, 3, 4);
            rbPostPonedAnnouncement.Name = "rbPostPonedAnnouncement";
            rbPostPonedAnnouncement.Size = new Size(214, 24);
            rbPostPonedAnnouncement.TabIndex = 21;
            rbPostPonedAnnouncement.TabStop = true;
            rbPostPonedAnnouncement.Text = "Post-poned announcements";
            rbPostPonedAnnouncement.UseVisualStyleBackColor = true;
            // 
            // rbPastAnnouncement
            // 
            rbPastAnnouncement.AutoSize = true;
            rbPastAnnouncement.Location = new Point(14, 27);
            rbPastAnnouncement.Margin = new Padding(3, 4, 3, 4);
            rbPastAnnouncement.Name = "rbPastAnnouncement";
            rbPastAnnouncement.Size = new Size(164, 24);
            rbPastAnnouncement.TabIndex = 18;
            rbPastAnnouncement.TabStop = true;
            rbPastAnnouncement.Text = "Past announcements";
            rbPastAnnouncement.UseVisualStyleBackColor = true;
            // 
            // rbAllAnnouncements
            // 
            rbAllAnnouncements.AutoSize = true;
            rbAllAnnouncements.Location = new Point(14, 125);
            rbAllAnnouncements.Margin = new Padding(3, 4, 3, 4);
            rbAllAnnouncements.Name = "rbAllAnnouncements";
            rbAllAnnouncements.Size = new Size(156, 24);
            rbAllAnnouncements.TabIndex = 20;
            rbAllAnnouncements.TabStop = true;
            rbAllAnnouncements.Text = "All announcements";
            rbAllAnnouncements.UseVisualStyleBackColor = true;
            // 
            // rbCurrentAnnouncement
            // 
            rbCurrentAnnouncement.AutoSize = true;
            rbCurrentAnnouncement.Location = new Point(14, 60);
            rbCurrentAnnouncement.Margin = new Padding(3, 4, 3, 4);
            rbCurrentAnnouncement.Name = "rbCurrentAnnouncement";
            rbCurrentAnnouncement.Size = new Size(186, 24);
            rbCurrentAnnouncement.TabIndex = 19;
            rbCurrentAnnouncement.TabStop = true;
            rbCurrentAnnouncement.Text = "Current announcements";
            rbCurrentAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(45, 170);
            btnResetFilters.Margin = new Padding(3, 4, 3, 4);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(110, 44);
            btnResetFilters.TabIndex = 15;
            btnResetFilters.Text = "Reset filters";
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
            gbFilters.Location = new Point(579, 242);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(213, 242);
            gbFilters.TabIndex = 40;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // btnCreateAnno
            // 
            btnCreateAnno.Location = new Point(237, 495);
            btnCreateAnno.Margin = new Padding(3, 4, 3, 4);
            btnCreateAnno.Name = "btnCreateAnno";
            btnCreateAnno.Size = new Size(336, 70);
            btnCreateAnno.TabIndex = 37;
            btnCreateAnno.Text = "Create announcement";
            btnCreateAnno.UseVisualStyleBackColor = true;
            btnCreateAnno.Click += btnCreateAnno_Click;
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 20;
            lbAnnouncements.Location = new Point(237, 242);
            lbAnnouncements.Margin = new Padding(3, 4, 3, 4);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(336, 244);
            lbAnnouncements.TabIndex = 27;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            lbAnnouncements.MouseDoubleClick += lbAnnouncements_MouseDoubleClick;
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnno.Location = new Point(237, 203);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(115, 18);
            lblAnno.TabIndex = 26;
            lblAnno.Text = "Announcements";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(45, 154);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(154, 20);
            lblWelcome.TabIndex = 25;
            lblWelcome.Text = "Welcome, ~~user~~!";
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(31, 302);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(0, 25);
            lblAnnouncements.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(bttnShifts);
            panel1.Controls.Add(bttnEmployees);
            panel1.Controls.Add(bttnAnnouncement);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 125);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(489, 0);
            button2.Name = "button2";
            button2.Size = new Size(244, 125);
            button2.TabIndex = 43;
            button2.Text = "Departments";
            button2.UseVisualStyleBackColor = true;
            // 
            // bttnShifts
            // 
            bttnShifts.FlatAppearance.BorderSize = 0;
            bttnShifts.FlatStyle = FlatStyle.Flat;
            bttnShifts.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnShifts.Location = new Point(727, 0);
            bttnShifts.Name = "bttnShifts";
            bttnShifts.Size = new Size(236, 125);
            bttnShifts.TabIndex = 44;
            bttnShifts.Text = "Shifts";
            bttnShifts.UseVisualStyleBackColor = true;
            bttnShifts.Click += bttnShifts_Click;
            // 
            // bttnEmployees
            // 
            bttnEmployees.FlatAppearance.BorderSize = 0;
            bttnEmployees.FlatStyle = FlatStyle.Flat;
            bttnEmployees.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnEmployees.Location = new Point(236, 0);
            bttnEmployees.Name = "bttnEmployees";
            bttnEmployees.Size = new Size(257, 125);
            bttnEmployees.TabIndex = 42;
            bttnEmployees.Text = "Employees";
            bttnEmployees.UseVisualStyleBackColor = true;
            bttnEmployees.Click += bttnEmployees_Click;
            // 
            // bttnAnnouncement
            // 
            bttnAnnouncement.FlatAppearance.BorderSize = 0;
            bttnAnnouncement.FlatStyle = FlatStyle.Flat;
            bttnAnnouncement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnAnnouncement.Location = new Point(0, 0);
            bttnAnnouncement.Name = "bttnAnnouncement";
            bttnAnnouncement.Size = new Size(247, 125);
            bttnAnnouncement.TabIndex = 41;
            bttnAnnouncement.Text = "Announcements";
            bttnAnnouncement.UseVisualStyleBackColor = true;
            bttnAnnouncement.Click += bttnAnnouncement_Click;
            // 
            // AdminLandingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 623);
            Controls.Add(gbFilters);
            Controls.Add(lblAnnouncements);
            Controls.Add(btnCreateAnno);
            Controls.Add(lbAnnouncements);
            Controls.Add(lblAnno);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminLandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLandingForm";
            Load += AdminLandingForm_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button bttnAnnouncement;
        private Button button2;
        private Button bttnShifts;
        private Button bttnEmployees;
    }
}