namespace Desktop_application
{
    partial class CreateAnnouncement
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
            btnCancel = new Button();
            btnSendAnno = new Button();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            lblED = new Label();
            tbDetails = new TextBox();
            tbTitle = new TextBox();
            lblSD = new Label();
            lblTitle = new Label();
            lblDetails = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(395, 330);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 65);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Cancel announcement";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSendAnno
            // 
            btnSendAnno.Location = new Point(233, 330);
            btnSendAnno.Margin = new Padding(3, 4, 3, 4);
            btnSendAnno.Name = "btnSendAnno";
            btnSendAnno.Size = new Size(121, 65);
            btnSendAnno.TabIndex = 50;
            btnSendAnno.Text = "Send announcement";
            btnSendAnno.UseVisualStyleBackColor = true;
            btnSendAnno.Click += btnSendAnno_Click;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Location = new Point(426, 215);
            dtpEndTime.Margin = new Padding(3, 4, 3, 4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(258, 27);
            dtpEndTime.TabIndex = 49;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Location = new Point(426, 124);
            dtpStartTime.Margin = new Padding(3, 4, 3, 4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(258, 27);
            dtpStartTime.TabIndex = 48;
            // 
            // lblED
            // 
            lblED.AutoSize = true;
            lblED.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblED.Location = new Point(426, 181);
            lblED.Name = "lblED";
            lblED.Size = new Size(189, 18);
            lblED.TabIndex = 47;
            lblED.Text = "End date of announcement:";
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(76, 203);
            tbDetails.Margin = new Padding(3, 4, 3, 4);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(224, 83);
            tbDetails.TabIndex = 45;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(76, 124);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(224, 27);
            tbTitle.TabIndex = 44;
            // 
            // lblSD
            // 
            lblSD.AutoSize = true;
            lblSD.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSD.Location = new Point(426, 102);
            lblSD.Name = "lblSD";
            lblSD.Size = new Size(194, 18);
            lblSD.TabIndex = 43;
            lblSD.Text = "Start date of announcement:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(76, 102);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 18);
            lblTitle.TabIndex = 42;
            lblTitle.Text = "Title of announcement:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetails.Location = new Point(76, 181);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(176, 18);
            lblDetails.TabIndex = 46;
            lblDetails.Text = "Details of announcement:";
            // 
            // CreateAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSendAnno);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblED);
            Controls.Add(tbDetails);
            Controls.Add(tbTitle);
            Controls.Add(lblSD);
            Controls.Add(lblTitle);
            Controls.Add(lblDetails);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateAnnouncement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAnnouncement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSendAnno;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private Label lblED;
        private TextBox tbDetails;
        private TextBox tbTitle;
        private Label lblSD;
        private Label lblTitle;
        private Label lblDetails;
    }
}