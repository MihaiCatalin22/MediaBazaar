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
            SuspendLayout();
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(533, 307);
            bttnDelete.Margin = new Padding(3, 4, 3, 4);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(171, 65);
            bttnDelete.TabIndex = 61;
            bttnDelete.Text = "Delete Announcement";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnEdit
            // 
            bttnEdit.Location = new Point(96, 307);
            bttnEdit.Margin = new Padding(3, 4, 3, 4);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(171, 65);
            bttnEdit.TabIndex = 60;
            bttnEdit.Text = "Edit Announcement";
            bttnEdit.UseVisualStyleBackColor = true;
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
            lblED.Location = new Point(446, 158);
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
            tbDetails.Size = new Size(224, 83);
            tbDetails.TabIndex = 55;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(96, 101);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(224, 27);
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
            lblDetails.Location = new Point(96, 158);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(176, 18);
            lblDetails.TabIndex = 56;
            lblDetails.Text = "Details of announcement:";
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(319, 307);
            bttnSave.Margin = new Padding(3, 4, 3, 4);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(171, 65);
            bttnSave.TabIndex = 62;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // EditAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "EditAnnouncement";
            Text = "EditAnnouncement";
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
    }
}