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
            panel1 = new Panel();
            lblShifts = new Label();
            lblDepartments = new Label();
            lblEmployees = new Label();
            lblAnnouncements = new Label();
            btnDelete = new Button();
            button4 = new Button();
            btnAddEmp = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            lbEmployees = new ListBox();
            tbSearch = new TextBox();
            lblEmp = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(lblShifts);
            panel1.Controls.Add(lblDepartments);
            panel1.Controls.Add(lblEmployees);
            panel1.Controls.Add(lblAnnouncements);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 125);
            panel1.TabIndex = 10;
            // 
            // lblShifts
            // 
            lblShifts.AutoSize = true;
            lblShifts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifts.Location = new Point(1035, 46);
            lblShifts.Name = "lblShifts";
            lblShifts.Size = new Size(67, 25);
            lblShifts.TabIndex = 3;
            lblShifts.Text = "Shifts";
            lblShifts.Click += lblShifts_Click;
            // 
            // lblDepartments
            // 
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartments.Location = new Point(689, 46);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new Size(134, 25);
            lblDepartments.TabIndex = 2;
            lblDepartments.Text = "Departments";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployees.Location = new Point(337, 46);
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
            lblAnnouncements.Location = new Point(25, 46);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(168, 25);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            lblAnnouncements.Click += lblAnnouncements_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(919, 488);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 81);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete selected employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(919, 576);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(122, 81);
            button4.TabIndex = 17;
            button4.Text = "Edit details of selected employee";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Location = new Point(919, 399);
            btnAddEmp.Margin = new Padding(3, 4, 3, 4);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(122, 81);
            btnAddEmp.TabIndex = 16;
            btnAddEmp.Text = "Add a new employee";
            btnAddEmp.UseVisualStyleBackColor = true;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(987, 309);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 68);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(885, 308);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 69);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search employee";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 20;
            lbEmployees.Location = new Point(165, 385);
            lbEmployees.Margin = new Padding(3, 4, 3, 4);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(532, 264);
            lbEmployees.TabIndex = 13;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(165, 328);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(532, 27);
            tbSearch.TabIndex = 12;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmp.Location = new Point(464, 175);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(252, 36);
            lblEmp.TabIndex = 11;
            lblEmp.Text = "Employees Page";
            // 
            // AdminEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 691);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(button4);
            Controls.Add(btnAddEmp);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lbEmployees);
            Controls.Add(tbSearch);
            Controls.Add(lblEmp);
            Name = "AdminEmployeeForm";
            Text = "AdminEmployeeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblShifts;
        private Label lblDepartments;
        private Label lblEmployees;
        private Label lblAnnouncements;
        private Button btnDelete;
        private Button button4;
        private Button btnAddEmp;
        private Button btnClear;
        private Button btnSearch;
        private ListBox lbEmployees;
        private TextBox tbSearch;
        private Label lblEmp;
    }
}