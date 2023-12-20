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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShiftsForm));
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddEvening
            // 
            btnAddEvening.BackColor = Color.MediumSeaGreen;
            btnAddEvening.FlatAppearance.BorderSize = 0;
            btnAddEvening.FlatStyle = FlatStyle.Flat;
            btnAddEvening.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEvening.ForeColor = Color.White;
            btnAddEvening.Location = new Point(925, 307);
            btnAddEvening.Margin = new Padding(3, 4, 3, 4);
            btnAddEvening.Name = "btnAddEvening";
            btnAddEvening.Size = new Size(130, 44);
            btnAddEvening.TabIndex = 31;
            btnAddEvening.Text = "Add shift";
            btnAddEvening.UseVisualStyleBackColor = false;
            btnAddEvening.Click += btnAddEvening_Click;
            // 
            // btnAddAfternoon
            // 
            btnAddAfternoon.BackColor = Color.MediumSeaGreen;
            btnAddAfternoon.FlatAppearance.BorderSize = 0;
            btnAddAfternoon.FlatStyle = FlatStyle.Flat;
            btnAddAfternoon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAfternoon.ForeColor = Color.White;
            btnAddAfternoon.Location = new Point(710, 307);
            btnAddAfternoon.Margin = new Padding(3, 4, 3, 4);
            btnAddAfternoon.Name = "btnAddAfternoon";
            btnAddAfternoon.Size = new Size(130, 44);
            btnAddAfternoon.TabIndex = 30;
            btnAddAfternoon.Text = "Add shift";
            btnAddAfternoon.UseVisualStyleBackColor = false;
            btnAddAfternoon.Click += btnAddAfternoon_Click;
            // 
            // btnAddMorning
            // 
            btnAddMorning.BackColor = Color.MediumSeaGreen;
            btnAddMorning.FlatAppearance.BorderSize = 0;
            btnAddMorning.FlatStyle = FlatStyle.Flat;
            btnAddMorning.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMorning.ForeColor = Color.White;
            btnAddMorning.Location = new Point(513, 307);
            btnAddMorning.Margin = new Padding(3, 4, 3, 4);
            btnAddMorning.Name = "btnAddMorning";
            btnAddMorning.Size = new Size(130, 44);
            btnAddMorning.TabIndex = 29;
            btnAddMorning.Text = "Add shift";
            btnAddMorning.UseVisualStyleBackColor = false;
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
            btnRefresh.BackColor = Color.Black;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(306, 601);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 65);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh calendar";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Black;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(151, 601);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(107, 65);
            btnCheck.TabIndex = 24;
            btnCheck.Text = "Check day";
            btnCheck.UseVisualStyleBackColor = false;
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
            lblShiftsPage.Location = new Point(542, 170);
            lblShiftsPage.Name = "lblShiftsPage";
            lblShiftsPage.Size = new Size(146, 29);
            lblShiftsPage.TabIndex = 19;
            lblShiftsPage.Text = "Shifts Page";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(151, 325);
            monthCalendar1.Margin = new Padding(9, 11, 9, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnStocks);
            panel2.Controls.Add(bttnAnnouncement);
            panel2.Controls.Add(btnDepartments);
            panel2.Controls.Add(bttnShifts);
            panel2.Controls.Add(bttnEmployees);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 125);
            panel2.TabIndex = 35;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1025, 0);
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
            btnStocks.Location = new Point(859, 0);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(160, 125);
            btnStocks.TabIndex = 45;
            btnStocks.Text = "Stocks";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // bttnAnnouncement
            // 
            bttnAnnouncement.FlatAppearance.BorderSize = 0;
            bttnAnnouncement.FlatStyle = FlatStyle.Flat;
            bttnAnnouncement.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnAnnouncement.ForeColor = Color.White;
            bttnAnnouncement.Location = new Point(11, 0);
            bttnAnnouncement.Name = "bttnAnnouncement";
            bttnAnnouncement.Size = new Size(214, 125);
            bttnAnnouncement.TabIndex = 41;
            bttnAnnouncement.Text = "Announcements";
            bttnAnnouncement.UseVisualStyleBackColor = true;
            bttnAnnouncement.Click += bttnAnnouncement_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.White;
            btnDepartments.Location = new Point(482, 0);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(216, 125);
            btnDepartments.TabIndex = 43;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // bttnShifts
            // 
            bttnShifts.FlatAppearance.BorderSize = 0;
            bttnShifts.FlatStyle = FlatStyle.Flat;
            bttnShifts.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnShifts.ForeColor = Color.White;
            bttnShifts.Location = new Point(704, 0);
            bttnShifts.Name = "bttnShifts";
            bttnShifts.Size = new Size(135, 125);
            bttnShifts.TabIndex = 44;
            bttnShifts.Text = "Shifts";
            bttnShifts.UseVisualStyleBackColor = true;
            bttnShifts.Click += bttnShifts_Click;
            // 
            // bttnEmployees
            // 
            bttnEmployees.FlatAppearance.BorderSize = 0;
            bttnEmployees.FlatStyle = FlatStyle.Flat;
            bttnEmployees.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnEmployees.ForeColor = Color.White;
            bttnEmployees.Location = new Point(264, 0);
            bttnEmployees.Name = "bttnEmployees";
            bttnEmployees.Size = new Size(195, 125);
            bttnEmployees.TabIndex = 42;
            bttnEmployees.Text = "Employees";
            bttnEmployees.UseVisualStyleBackColor = true;
            bttnEmployees.Click += bttnEmployees_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(152, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 3);
            panel1.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(152, 529);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 3);
            panel3.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(513, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(130, 3);
            panel4.TabIndex = 46;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(710, 348);
            panel5.Name = "panel5";
            panel5.Size = new Size(130, 3);
            panel5.TabIndex = 47;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(925, 348);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 3);
            panel6.TabIndex = 48;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(513, 649);
            panel7.Name = "panel7";
            panel7.Size = new Size(130, 4);
            panel7.TabIndex = 49;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 3);
            panel8.TabIndex = 50;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(130, 3);
            panel9.TabIndex = 51;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(925, 649);
            panel10.Name = "panel10";
            panel10.Size = new Size(130, 4);
            panel10.TabIndex = 52;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(710, 649);
            panel11.Name = "panel11";
            panel11.Size = new Size(130, 4);
            panel11.TabIndex = 53;
            // 
            // AdminShiftsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 691);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminShiftsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shifts";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
    }
}