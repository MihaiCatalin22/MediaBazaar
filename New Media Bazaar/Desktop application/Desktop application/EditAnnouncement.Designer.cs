namespace Desktop_application
{
    partial class EditAnnouncement
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
            bttnDelete = new Button();
            bttnEdit = new Button();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            lblED = new Label();
            tbDetails = new TextBox();
            tbTitle = new TextBox();
            lblSD = new Label();
            lblTitle = new Label();
            lblDetails = new Label();
            bttnSave = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // bttnDelete
            // 
            bttnDelete.BackColor = Color.Firebrick;
            bttnDelete.FlatAppearance.BorderSize = 0;
            bttnDelete.FlatStyle = FlatStyle.Flat;
            bttnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bttnDelete.ForeColor = Color.White;
            bttnDelete.Location = new Point(533, 307);
            bttnDelete.Margin = new Padding(3, 4, 3, 4);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(171, 65);
            bttnDelete.TabIndex = 61;
            bttnDelete.Text = "Delete Announcement";
            bttnDelete.UseVisualStyleBackColor = false;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // bttnEdit
            // 
            bttnEdit.BackColor = Color.Orange;
            bttnEdit.FlatAppearance.BorderSize = 0;
            bttnEdit.FlatStyle = FlatStyle.Flat;
            bttnEdit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bttnEdit.ForeColor = Color.White;
            bttnEdit.Location = new Point(96, 307);
            bttnEdit.Margin = new Padding(3, 4, 3, 4);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(171, 65);
            bttnEdit.TabIndex = 60;
            bttnEdit.Text = "Edit Announcement";
            bttnEdit.UseVisualStyleBackColor = false;
            bttnEdit.Click += bttnEdit_Click;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Location = new Point(446, 192);
            dtpEndTime.Margin = new Padding(3, 4, 3, 4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(258, 27);
            dtpEndTime.TabIndex = 59;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Location = new Point(446, 101);
            dtpStartTime.Margin = new Padding(3, 4, 3, 4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(258, 27);
            dtpStartTime.TabIndex = 58;
            // 
            // lblED
            // 
            lblED.AutoSize = true;
            lblED.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblED.Location = new Point(446, 157);
            lblED.Name = "lblED";
            lblED.Size = new Size(189, 18);
            lblED.TabIndex = 57;
            lblED.Text = "End date of announcement:";
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(96, 180);
            tbDetails.Margin = new Padding(3, 4, 3, 4);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(223, 83);
            tbDetails.TabIndex = 55;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(96, 101);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(223, 27);
            tbTitle.TabIndex = 54;
            // 
            // lblSD
            // 
            lblSD.AutoSize = true;
            lblSD.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSD.Location = new Point(446, 79);
            lblSD.Name = "lblSD";
            lblSD.Size = new Size(194, 18);
            lblSD.TabIndex = 53;
            lblSD.Text = "Start date of announcement:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(96, 79);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 18);
            lblTitle.TabIndex = 52;
            lblTitle.Text = "Title of announcement:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetails.Location = new Point(96, 157);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(176, 18);
            lblDetails.TabIndex = 56;
            lblDetails.Text = "Details of announcement:";
            // 
            // bttnSave
            // 
            bttnSave.BackColor = Color.MediumSeaGreen;
            bttnSave.FlatAppearance.BorderSize = 0;
            bttnSave.FlatStyle = FlatStyle.Flat;
            bttnSave.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bttnSave.ForeColor = Color.White;
            bttnSave.Location = new Point(320, 307);
            bttnSave.Margin = new Padding(3, 4, 3, 4);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(171, 65);
            bttnSave.TabIndex = 62;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = false;
            bttnSave.Click += bttnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Firebrick;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(752, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(49, 37);
            btnBack.TabIndex = 63;
            btnBack.Text = "X";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(96, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 4);
            panel2.TabIndex = 64;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(446, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 4);
            panel1.TabIndex = 65;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(96, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 4);
            panel3.TabIndex = 66;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(96, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 4);
            panel4.TabIndex = 67;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(446, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 4);
            panel5.TabIndex = 68;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(320, 368);
            panel6.Name = "panel6";
            panel6.Size = new Size(171, 4);
            panel6.TabIndex = 69;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(533, 368);
            panel7.Name = "panel7";
            panel7.Size = new Size(171, 4);
            panel7.TabIndex = 70;
            // 
            // EditAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnBack);
            Controls.Add(bttnSave);
            Controls.Add(bttnDelete);
            Controls.Add(bttnEdit);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblED);
            Controls.Add(tbDetails);
            Controls.Add(tbTitle);
            Controls.Add(lblSD);
            Controls.Add(lblTitle);
            Controls.Add(lblDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditAnnouncement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit an announcement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnDelete;
        private Button bttnEdit;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private Label lblED;
        private TextBox tbDetails;
        private TextBox tbTitle;
        private Label lblSD;
        private Label lblTitle;
        private Label lblDetails;
        private Button bttnSave;
        private Button btnBack;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}