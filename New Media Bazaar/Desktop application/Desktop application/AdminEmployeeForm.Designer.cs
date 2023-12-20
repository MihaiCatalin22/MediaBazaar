namespace Desktop_application
{
    partial class AdminEmployeeForm
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
            btnDelete = new Button();
            btnEditDetails = new Button();
            btnAddEmp = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            lbEmployees = new ListBox();
            tbSearch = new TextBox();
            lblEmp = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnStocks = new Button();
            bttnAnnouncement = new Button();
            btnDepartments = new Button();
            bttnShifts = new Button();
            bttnEmployees = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(919, 488);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 81);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete selected employee";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditDetails
            // 
            btnEditDetails.BackColor = Color.Black;
            btnEditDetails.FlatAppearance.BorderSize = 0;
            btnEditDetails.FlatStyle = FlatStyle.Flat;
            btnEditDetails.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditDetails.ForeColor = Color.White;
            btnEditDetails.Location = new Point(919, 576);
            btnEditDetails.Margin = new Padding(3, 4, 3, 4);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(122, 81);
            btnEditDetails.TabIndex = 17;
            btnEditDetails.Text = "Edit details of selected employee";
            btnEditDetails.UseVisualStyleBackColor = false;
            btnEditDetails.Click += btnEditDetails_Click;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = Color.MediumSeaGreen;
            btnAddEmp.FlatAppearance.BorderSize = 0;
            btnAddEmp.FlatStyle = FlatStyle.Flat;
            btnAddEmp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Location = new Point(919, 399);
            btnAddEmp.Margin = new Padding(3, 4, 3, 4);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(122, 81);
            btnAddEmp.TabIndex = 16;
            btnAddEmp.Text = "Add a new employee";
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(987, 309);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 69);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(837, 308);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 69);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search employee";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbEmployees
            // 
            lbEmployees.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 23;
            lbEmployees.Location = new Point(165, 385);
            lbEmployees.Margin = new Padding(3, 4, 3, 4);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(532, 257);
            lbEmployees.TabIndex = 13;
            lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Location = new Point(165, 328);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(532, 20);
            tbSearch.TabIndex = 12;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Century Gothic", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmp.Location = new Point(464, 175);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(277, 39);
            lblEmp.TabIndex = 11;
            lblEmp.Text = "Employees Page";
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
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 125);
            panel2.TabIndex = 36;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1025, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 125);
            btnLogout.TabIndex = 43;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStocks
            // 
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStocks.ForeColor = Color.White;
            btnStocks.Location = new Point(837, 1);
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
            bttnAnnouncement.Location = new Point(0, 0);
            bttnAnnouncement.Name = "bttnAnnouncement";
            bttnAnnouncement.Size = new Size(218, 125);
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
            btnDepartments.Location = new Point(452, 1);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(177, 125);
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
            bttnShifts.Location = new Point(674, 0);
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
            bttnEmployees.Location = new Point(244, 0);
            bttnEmployees.Name = "bttnEmployees";
            bttnEmployees.Size = new Size(172, 125);
            bttnEmployees.TabIndex = 42;
            bttnEmployees.Text = "Employees";
            bttnEmployees.UseVisualStyleBackColor = true;
            bttnEmployees.Click += bttnEmployees_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 296);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 37;
            label1.Text = "Search an employee:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(802, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(165, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 3);
            panel1.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(919, 477);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 3);
            panel3.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(919, 566);
            panel4.Name = "panel4";
            panel4.Size = new Size(122, 3);
            panel4.TabIndex = 41;
            // 
            // AdminEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 691);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnEditDetails);
            Controls.Add(btnAddEmp);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lbEmployees);
            Controls.Add(tbSearch);
            Controls.Add(lblEmp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private Button btnEditDetails;
        private Button btnAddEmp;
        private Button btnClear;
        private Button btnSearch;
        private ListBox lbEmployees;
        private TextBox tbSearch;
        private Label lblEmp;
        private Panel panel2;
        private Button btnLogout;
        private Button btnStocks;
        private Button bttnAnnouncement;
        private Button btnDepartments;
        private Button bttnShifts;
        private Button bttnEmployees;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
    }
}