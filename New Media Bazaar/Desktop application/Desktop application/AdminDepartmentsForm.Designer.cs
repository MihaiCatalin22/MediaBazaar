namespace Desktop_application
{
    partial class AdminDepartmentsForm
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
            lbDepartments = new ListBox();
            label2 = new Label();
            label1 = new Label();
            btnAddDepartment = new Button();
            tbDepartmentName = new TextBox();
            btnRemoveDepartment = new Button();
            panel2 = new Panel();
            btnLogout = new Button();
            btnStocks = new Button();
            bttnAnnouncement = new Button();
            btnDepartments = new Button();
            bttnShifts = new Button();
            bttnEmployees = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbDepartments
            // 
            lbDepartments.BackColor = Color.White;
            lbDepartments.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartments.ForeColor = Color.Black;
            lbDepartments.FormattingEnabled = true;
            lbDepartments.ItemHeight = 23;
            lbDepartments.Location = new Point(45, 174);
            lbDepartments.Margin = new Padding(3, 4, 3, 4);
            lbDepartments.Name = "lbDepartments";
            lbDepartments.Size = new Size(463, 464);
            lbDepartments.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(586, 145);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 39);
            label2.TabIndex = 20;
            label2.Text = "Departments Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(524, 291);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 19;
            label1.Text = "Name:";
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.BackColor = Color.MediumSeaGreen;
            btnAddDepartment.FlatStyle = FlatStyle.Flat;
            btnAddDepartment.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDepartment.ForeColor = Color.White;
            btnAddDepartment.Location = new Point(638, 362);
            btnAddDepartment.Margin = new Padding(2, 1, 2, 1);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(239, 79);
            btnAddDepartment.TabIndex = 18;
            btnAddDepartment.Text = "Add department";
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // tbDepartmentName
            // 
            tbDepartmentName.BorderStyle = BorderStyle.None;
            tbDepartmentName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDepartmentName.Location = new Point(638, 297);
            tbDepartmentName.Margin = new Padding(3, 4, 3, 4);
            tbDepartmentName.Name = "tbDepartmentName";
            tbDepartmentName.Size = new Size(238, 30);
            tbDepartmentName.TabIndex = 17;
            // 
            // btnRemoveDepartment
            // 
            btnRemoveDepartment.BackColor = Color.Firebrick;
            btnRemoveDepartment.FlatStyle = FlatStyle.Flat;
            btnRemoveDepartment.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveDepartment.ForeColor = Color.White;
            btnRemoveDepartment.Location = new Point(637, 471);
            btnRemoveDepartment.Margin = new Padding(2, 1, 2, 1);
            btnRemoveDepartment.Name = "btnRemoveDepartment";
            btnRemoveDepartment.Size = new Size(239, 79);
            btnRemoveDepartment.TabIndex = 21;
            btnRemoveDepartment.Text = "Remove selected department";
            btnRemoveDepartment.UseVisualStyleBackColor = false;
            btnRemoveDepartment.Click += btnRemoveDepartment_Click;
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
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 109);
            panel2.TabIndex = 36;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1028, -6);
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
            btnStocks.Location = new Point(817, -5);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(160, 125);
            btnStocks.TabIndex = 45;
            btnStocks.Text = "Stocks";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // bttnAnnouncement
            // 
            bttnAnnouncement.BackColor = Color.Black;
            bttnAnnouncement.FlatAppearance.BorderSize = 0;
            bttnAnnouncement.FlatStyle = FlatStyle.Flat;
            bttnAnnouncement.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            bttnAnnouncement.ForeColor = Color.White;
            bttnAnnouncement.Location = new Point(10, -5);
            bttnAnnouncement.Name = "bttnAnnouncement";
            bttnAnnouncement.Size = new Size(211, 125);
            bttnAnnouncement.TabIndex = 41;
            bttnAnnouncement.Text = "Announcements";
            bttnAnnouncement.UseVisualStyleBackColor = false;
            bttnAnnouncement.Click += bttnAnnouncement_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.White;
            btnDepartments.Location = new Point(460, -5);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(176, 125);
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
            bttnShifts.Location = new Point(676, -5);
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
            bttnEmployees.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            bttnEmployees.ForeColor = Color.White;
            bttnEmployees.Location = new Point(262, -5);
            bttnEmployees.Name = "bttnEmployees";
            bttnEmployees.Size = new Size(158, 125);
            bttnEmployees.TabIndex = 42;
            bttnEmployees.Text = "Employees";
            bttnEmployees.UseVisualStyleBackColor = true;
            bttnEmployees.Click += bttnEmployees_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(637, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 3);
            panel1.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(638, 438);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 3);
            panel3.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(638, 547);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 3);
            panel4.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.department;
            pictureBox1.Location = new Point(934, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // AdminDepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 691);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnRemoveDepartment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddDepartment);
            Controls.Add(tbDepartmentName);
            Controls.Add(lbDepartments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDepartmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDepartmentsForm";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbDepartments;
        private Label label2;
        private Label label1;
        private Button btnAddDepartment;
        private TextBox tbDepartmentName;
        private Button btnRemoveDepartment;
        private Panel panel2;
        private Button btnLogout;
        private Button btnStocks;
        private Button bttnAnnouncement;
        private Button btnDepartments;
        private Button bttnShifts;
        private Button bttnEmployees;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}