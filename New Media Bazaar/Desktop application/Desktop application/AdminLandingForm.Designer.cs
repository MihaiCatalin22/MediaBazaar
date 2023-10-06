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
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
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
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(14, 92);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(214, 24);
            radioButton4.TabIndex = 21;
            radioButton4.TabStop = true;
            radioButton4.Text = "Post-poned announcements";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 27);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 24);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Past announcements";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(14, 125);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(156, 24);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "All announcements";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 60);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(186, 24);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Current announcements";
            radioButton2.UseVisualStyleBackColor = true;
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
            gbFilters.Controls.Add(radioButton4);
            gbFilters.Controls.Add(radioButton1);
            gbFilters.Controls.Add(btnResetFilters);
            gbFilters.Controls.Add(radioButton3);
            gbFilters.Controls.Add(radioButton2);
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
            Name = "AdminLandingForm";
            Text = "AdminLandingForm";
            Load += AdminLandingForm_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
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