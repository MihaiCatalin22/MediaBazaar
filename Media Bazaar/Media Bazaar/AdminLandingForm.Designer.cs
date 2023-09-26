namespace Media_Bazaar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAnno = new System.Windows.Forms.Label();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAnno = new System.Windows.Forms.Button();
            this.btnCreateAnno = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnSendAnno = new System.Windows.Forms.Button();
            this.btnEditAnno = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblShifts);
            this.panel1.Controls.Add(this.lblDepartments);
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Controls.Add(this.lblAnnouncements);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.Location = new System.Drawing.Point(25, 37);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(169, 24);
            this.lblAnnouncements.TabIndex = 0;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(337, 37);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(117, 24);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees";
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(689, 37);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(138, 24);
            this.lblDepartments.TabIndex = 2;
            this.lblDepartments.Text = "Departments";
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShifts.Location = new System.Drawing.Point(1035, 37);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(65, 24);
            this.lblShifts.TabIndex = 3;
            this.lblShifts.Text = "Shifts";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(57, 142);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, ~~user~~!";
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnno.Location = new System.Drawing.Point(58, 213);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(115, 18);
            this.lblAnno.TabIndex = 2;
            this.lblAnno.Text = "Announcements";
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 16;
            this.lbAnnouncements.Location = new System.Drawing.Point(41, 244);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(336, 196);
            this.lbAnnouncements.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(660, 244);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 18);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title of announcement:";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.Location = new System.Drawing.Point(629, 308);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(194, 18);
            this.lblSD.TabIndex = 6;
            this.lblSD.Text = "Start date of announcement:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(824, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(824, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 22);
            this.textBox2.TabIndex = 8;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(644, 277);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(176, 18);
            this.lblDetails.TabIndex = 9;
            this.lblDetails.Text = "Details of announcement:";
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblED.Location = new System.Drawing.Point(632, 330);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(189, 18);
            this.lblED.TabIndex = 10;
            this.lblED.Text = "End date of announcement:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(824, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(824, 330);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // btnDeleteAnno
            // 
            this.btnDeleteAnno.Location = new System.Drawing.Point(269, 446);
            this.btnDeleteAnno.Name = "btnDeleteAnno";
            this.btnDeleteAnno.Size = new System.Drawing.Size(108, 56);
            this.btnDeleteAnno.TabIndex = 13;
            this.btnDeleteAnno.Text = "Delete announcement";
            this.btnDeleteAnno.UseVisualStyleBackColor = true;
            // 
            // btnCreateAnno
            // 
            this.btnCreateAnno.Location = new System.Drawing.Point(41, 446);
            this.btnCreateAnno.Name = "btnCreateAnno";
            this.btnCreateAnno.Size = new System.Drawing.Size(108, 56);
            this.btnCreateAnno.TabIndex = 14;
            this.btnCreateAnno.Text = "Create announcement";
            this.btnCreateAnno.UseVisualStyleBackColor = true;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(45, 136);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(110, 35);
            this.btnResetFilters.TabIndex = 15;
            this.btnResetFilters.Text = "Reset filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnSendAnno
            // 
            this.btnSendAnno.Location = new System.Drawing.Point(801, 376);
            this.btnSendAnno.Name = "btnSendAnno";
            this.btnSendAnno.Size = new System.Drawing.Size(121, 52);
            this.btnSendAnno.TabIndex = 16;
            this.btnSendAnno.Text = "Send announcement";
            this.btnSendAnno.UseVisualStyleBackColor = true;
            // 
            // btnEditAnno
            // 
            this.btnEditAnno.Location = new System.Drawing.Point(155, 446);
            this.btnEditAnno.Name = "btnEditAnno";
            this.btnEditAnno.Size = new System.Drawing.Size(108, 56);
            this.btnEditAnno.TabIndex = 17;
            this.btnEditAnno.Text = "Edit announcement";
            this.btnEditAnno.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(153, 20);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Past announcements";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 20);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Current announcements";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 20);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All announcements";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(14, 73);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(196, 20);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Post-poned announcements";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.radioButton4);
            this.gbFilters.Controls.Add(this.radioButton1);
            this.gbFilters.Controls.Add(this.btnResetFilters);
            this.gbFilters.Controls.Add(this.radioButton3);
            this.gbFilters.Controls.Add(this.radioButton2);
            this.gbFilters.Location = new System.Drawing.Point(383, 244);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(213, 194);
            this.gbFilters.TabIndex = 22;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(947, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 52);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel announcement";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AdminLandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnEditAnno);
            this.Controls.Add(this.btnSendAnno);
            this.Controls.Add(this.btnCreateAnno);
            this.Controls.Add(this.btnDeleteAnno);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblED);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSD);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblAnno);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminLandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnDeleteAnno;
        private System.Windows.Forms.Button btnCreateAnno;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnSendAnno;
        private System.Windows.Forms.Button btnEditAnno;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnCancel;
    }
}