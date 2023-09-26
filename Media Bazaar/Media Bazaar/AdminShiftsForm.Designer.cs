namespace Media_Bazaar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShifts = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.lblShiftsPage = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMorning = new System.Windows.Forms.Label();
            this.lblAfternoon = new System.Windows.Forms.Label();
            this.lblEvening = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.lbMorningShifts = new System.Windows.Forms.ListBox();
            this.lbAfternoonShifts = new System.Windows.Forms.ListBox();
            this.lbEveningShifts = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblShifts);
            this.panel1.Controls.Add(this.lblDepartments);
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Controls.Add(this.lblAnnouncements);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 100);
            this.panel1.TabIndex = 1;
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
            // lblShiftsPage
            // 
            this.lblShiftsPage.AutoSize = true;
            this.lblShiftsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftsPage.Location = new System.Drawing.Point(509, 117);
            this.lblShiftsPage.Name = "lblShiftsPage";
            this.lblShiftsPage.Size = new System.Drawing.Size(146, 29);
            this.lblShiftsPage.TabIndex = 2;
            this.lblShiftsPage.Text = "Shifts Page";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(44, 193);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(102, 20);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(152, 193);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(262, 24);
            this.cbDepartment.TabIndex = 4;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.Location = new System.Drawing.Point(65, 241);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(81, 20);
            this.lblCalendar.TabIndex = 5;
            this.lblCalendar.Text = "Calendar:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(152, 241);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(152, 461);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(108, 52);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check day";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(307, 461);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 52);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh calendar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorning.Location = new System.Drawing.Point(511, 197);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(133, 25);
            this.lblMorning.TabIndex = 9;
            this.lblMorning.Text = "Morning shifts";
            // 
            // lblAfternoon
            // 
            this.lblAfternoon.AutoSize = true;
            this.lblAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfternoon.Location = new System.Drawing.Point(706, 197);
            this.lblAfternoon.Name = "lblAfternoon";
            this.lblAfternoon.Size = new System.Drawing.Size(147, 25);
            this.lblAfternoon.TabIndex = 10;
            this.lblAfternoon.Text = "Afternoon shifts";
            // 
            // lblEvening
            // 
            this.lblEvening.AutoSize = true;
            this.lblEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvening.Location = new System.Drawing.Point(923, 197);
            this.lblEvening.Name = "lblEvening";
            this.lblEvening.Size = new System.Drawing.Size(133, 25);
            this.lblEvening.TabIndex = 11;
            this.lblEvening.Text = "Evening shifts";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.Location = new System.Drawing.Point(514, 226);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(130, 35);
            this.btnAdd1.TabIndex = 12;
            this.btnAdd1.Text = "Add shift";
            this.btnAdd1.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(711, 225);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(130, 35);
            this.btnAdd2.TabIndex = 13;
            this.btnAdd2.Text = "Add shift";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // btnAdd3
            // 
            this.btnAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd3.Location = new System.Drawing.Point(926, 226);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(130, 35);
            this.btnAdd3.TabIndex = 14;
            this.btnAdd3.Text = "Add shift";
            this.btnAdd3.UseVisualStyleBackColor = true;
            // 
            // lbMorningShifts
            // 
            this.lbMorningShifts.FormattingEnabled = true;
            this.lbMorningShifts.ItemHeight = 16;
            this.lbMorningShifts.Location = new System.Drawing.Point(516, 281);
            this.lbMorningShifts.Name = "lbMorningShifts";
            this.lbMorningShifts.Size = new System.Drawing.Size(128, 196);
            this.lbMorningShifts.TabIndex = 15;
            // 
            // lbAfternoonShifts
            // 
            this.lbAfternoonShifts.FormattingEnabled = true;
            this.lbAfternoonShifts.ItemHeight = 16;
            this.lbAfternoonShifts.Location = new System.Drawing.Point(711, 281);
            this.lbAfternoonShifts.Name = "lbAfternoonShifts";
            this.lbAfternoonShifts.Size = new System.Drawing.Size(130, 196);
            this.lbAfternoonShifts.TabIndex = 16;
            // 
            // lbEveningShifts
            // 
            this.lbEveningShifts.FormattingEnabled = true;
            this.lbEveningShifts.ItemHeight = 16;
            this.lbEveningShifts.Location = new System.Drawing.Point(926, 281);
            this.lbEveningShifts.Name = "lbEveningShifts";
            this.lbEveningShifts.Size = new System.Drawing.Size(130, 196);
            this.lbEveningShifts.TabIndex = 17;
            // 
            // AdminShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.lbEveningShifts);
            this.Controls.Add(this.lbAfternoonShifts);
            this.Controls.Add(this.lbMorningShifts);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.lblEvening);
            this.Controls.Add(this.lblAfternoon);
            this.Controls.Add(this.lblMorning);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblShiftsPage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminShiftsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminShiftsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.Label lblShiftsPage;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.Label lblAfternoon;
        private System.Windows.Forms.Label lblEvening;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.ListBox lbMorningShifts;
        private System.Windows.Forms.ListBox lbAfternoonShifts;
        private System.Windows.Forms.ListBox lbEveningShifts;
    }
}