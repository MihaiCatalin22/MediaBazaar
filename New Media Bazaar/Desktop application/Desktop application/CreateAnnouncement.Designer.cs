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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblED = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(426, 215);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(224, 27);
            dateTimePicker2.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(426, 124);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 27);
            dateTimePicker1.TabIndex = 48;
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
            // textBox2
            // 
            textBox2.Location = new Point(76, 203);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 83);
            textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 124);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 44;
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
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblED);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblSD);
            Controls.Add(lblTitle);
            Controls.Add(lblDetails);
            Name = "CreateAnnouncement";
            Text = "CreateAnnouncement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSendAnno;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label lblED;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblSD;
        private Label lblTitle;
        private Label lblDetails;
    }
}