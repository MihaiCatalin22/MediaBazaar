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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLandingForm));
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            gbFilters.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rbPostPonedAnnouncement
            // 
            rbPostPonedAnnouncement.AutoSize = true;
            rbPostPonedAnnouncement.Location = new Point(14, 92);
            rbPostPonedAnnouncement.Margin = new Padding(3, 4, 3, 4);
            rbPostPonedAnnouncement.Name = "rbPostPonedAnnouncement";
            rbPostPonedAnnouncement.Size = new Size(284, 25);
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
            rbPastAnnouncement.Size = new Size(219, 25);
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
            rbAllAnnouncements.Size = new Size(203, 25);
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
            rbCurrentAnnouncement.Size = new Size(248, 25);
            rbCurrentAnnouncement.TabIndex = 19;
            rbCurrentAnnouncement.TabStop = true;
            rbCurrentAnnouncement.Text = "Current announcements";
            rbCurrentAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.Black;
            btnResetFilters.FlatAppearance.BorderSize = 0;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(89, 168);
            btnResetFilters.Margin = new Padding(3, 4, 3, 4);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(133, 44);
            btnResetFilters.TabIndex = 15;
            btnResetFilters.Text = "Apply filters";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(rbPostPonedAnnouncement);
            gbFilters.Controls.Add(rbPastAnnouncement);
            gbFilters.Controls.Add(btnResetFilters);
            gbFilters.Controls.Add(rbAllAnnouncements);
            gbFilters.Controls.Add(rbCurrentAnnouncement);
            gbFilters.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbFilters.Location = new Point(579, 243);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(337, 243);
            gbFilters.TabIndex = 40;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // btnCreateAnno
            // 
            btnCreateAnno.BackColor = Color.MediumSeaGreen;
            btnCreateAnno.FlatAppearance.BorderSize = 0;
            btnCreateAnno.FlatStyle = FlatStyle.Flat;
            btnCreateAnno.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateAnno.ForeColor = Color.White;
            btnCreateAnno.Location = new Point(237, 495);
            btnCreateAnno.Margin = new Padding(3, 4, 3, 4);
            btnCreateAnno.Name = "btnCreateAnno";
            btnCreateAnno.Size = new Size(336, 69);
            btnCreateAnno.TabIndex = 37;
            btnCreateAnno.Text = "Create announcement";
            btnCreateAnno.UseVisualStyleBackColor = false;
            btnCreateAnno.Click += btnCreateAnno_Click;
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 23;
            lbAnnouncements.Location = new Point(237, 243);
            lbAnnouncements.Margin = new Padding(3, 4, 3, 4);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(335, 234);
            lbAnnouncements.TabIndex = 27;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            lbAnnouncements.MouseDoubleClick += lbAnnouncements_MouseDoubleClick;
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnno.Location = new Point(237, 203);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(171, 23);
            lblAnno.TabIndex = 26;
            lblAnno.Text = "Announcements";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(45, 155);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(196, 22);
            lblWelcome.TabIndex = 25;
            lblWelcome.Text = "Welcome, ~~user~~!";
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(31, 301);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(0, 25);
            lblAnnouncements.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnStocks);
            panel2.Controls.Add(btnAnnouncements);
            panel2.Controls.Add(btnDepartments);
            panel2.Controls.Add(btnShifts);
            panel2.Controls.Add(btnEmployees);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 125);
            panel2.TabIndex = 41;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(802, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 125);
            btnLogout.TabIndex = 43;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStocks
            // 
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStocks.ForeColor = Color.White;
            btnStocks.Location = new Point(667, -1);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(160, 125);
            btnStocks.TabIndex = 45;
            btnStocks.Text = "Stocks";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.FlatAppearance.BorderSize = 0;
            btnAnnouncements.FlatStyle = FlatStyle.Flat;
            btnAnnouncements.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnouncements.ForeColor = Color.White;
            btnAnnouncements.Location = new Point(0, 0);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(210, 125);
            btnAnnouncements.TabIndex = 41;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = true;
            btnAnnouncements.Click += button1_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.White;
            btnDepartments.Location = new Point(379, -1);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(183, 125);
            btnDepartments.TabIndex = 43;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnShifts
            // 
            btnShifts.FlatAppearance.BorderSize = 0;
            btnShifts.FlatStyle = FlatStyle.Flat;
            btnShifts.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifts.ForeColor = Color.White;
            btnShifts.Location = new Point(557, -1);
            btnShifts.Name = "btnShifts";
            btnShifts.Size = new Size(135, 125);
            btnShifts.TabIndex = 44;
            btnShifts.Text = "Shifts";
            btnShifts.UseVisualStyleBackColor = true;
            btnShifts.Click += btnShifts_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(216, 0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(165, 125);
            btnEmployees.TabIndex = 42;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(237, 561);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 3);
            panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(716, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // AdminLandingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 623);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(gbFilters);
            Controls.Add(lblAnnouncements);
            Controls.Add(btnCreateAnno);
            Controls.Add(lbAnnouncements);
            Controls.Add(lblAnno);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main page";
            Load += AdminLandingForm_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}