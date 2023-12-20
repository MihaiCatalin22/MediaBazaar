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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnnouncement));
            btnSendAnno = new Button();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            lblED = new Label();
            tbDetails = new TextBox();
            tbTitle = new TextBox();
            lblSD = new Label();
            lblTitle = new Label();
            lblDetails = new Label();
            btnExitCreateAnnouncement = new Button();
            panel7 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSendAnno
            // 
            btnSendAnno.BackColor = Color.MediumSeaGreen;
            btnSendAnno.FlatAppearance.BorderSize = 0;
            btnSendAnno.FlatStyle = FlatStyle.Flat;
            btnSendAnno.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendAnno.ForeColor = Color.White;
            btnSendAnno.Location = new Point(75, 331);
            btnSendAnno.Margin = new Padding(3, 4, 3, 4);
            btnSendAnno.Name = "btnSendAnno";
            btnSendAnno.Size = new Size(609, 53);
            btnSendAnno.TabIndex = 50;
            btnSendAnno.Text = "Send announcement";
            btnSendAnno.UseVisualStyleBackColor = false;
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
            tbDetails.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbDetails.Location = new Point(75, 203);
            tbDetails.Margin = new Padding(3, 4, 3, 4);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(223, 83);
            tbDetails.TabIndex = 45;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(75, 124);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(223, 28);
            tbTitle.TabIndex = 44;
            // 
            // lblSD
            // 
            lblSD.AutoSize = true;
            lblSD.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSD.Location = new Point(426, 101);
            lblSD.Name = "lblSD";
            lblSD.Size = new Size(194, 18);
            lblSD.TabIndex = 43;
            lblSD.Text = "Start date of announcement:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(75, 101);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 18);
            lblTitle.TabIndex = 42;
            lblTitle.Text = "Title of announcement:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetails.Location = new Point(75, 181);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(176, 18);
            lblDetails.TabIndex = 46;
            lblDetails.Text = "Details of announcement:";
            // 
            // btnExitCreateAnnouncement
            // 
            btnExitCreateAnnouncement.BackColor = Color.Firebrick;
            btnExitCreateAnnouncement.FlatAppearance.BorderSize = 0;
            btnExitCreateAnnouncement.FlatStyle = FlatStyle.Flat;
            btnExitCreateAnnouncement.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitCreateAnnouncement.ForeColor = Color.White;
            btnExitCreateAnnouncement.Location = new Point(766, -1);
            btnExitCreateAnnouncement.Name = "btnExitCreateAnnouncement";
            btnExitCreateAnnouncement.Size = new Size(35, 36);
            btnExitCreateAnnouncement.TabIndex = 55;
            btnExitCreateAnnouncement.Text = "X";
            btnExitCreateAnnouncement.UseVisualStyleBackColor = false;
            btnExitCreateAnnouncement.Click += btnExitCreateAnnouncement_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(426, 148);
            panel7.Name = "panel7";
            panel7.Size = new Size(258, 4);
            panel7.TabIndex = 56;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(426, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 4);
            panel1.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(75, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 4);
            panel2.TabIndex = 58;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(75, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 4);
            panel3.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // CreateAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(btnExitCreateAnnouncement);
            Controls.Add(btnSendAnno);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblED);
            Controls.Add(tbDetails);
            Controls.Add(tbTitle);
            Controls.Add(lblSD);
            Controls.Add(lblTitle);
            Controls.Add(lblDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAnnouncement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create an announcement";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSendAnno;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private Label lblED;
        private TextBox tbDetails;
        private TextBox tbTitle;
        private Label lblSD;
        private Label lblTitle;
        private Label lblDetails;
        private Button btnExitCreateAnnouncement;
        private Panel panel7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}