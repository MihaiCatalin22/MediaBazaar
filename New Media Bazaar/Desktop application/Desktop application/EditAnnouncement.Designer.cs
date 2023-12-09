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
			SuspendLayout();
			// 
			// bttnDelete
			// 
			bttnDelete.Location = new Point(466, 230);
			bttnDelete.Name = "bttnDelete";
			bttnDelete.Size = new Size(150, 49);
			bttnDelete.TabIndex = 61;
			bttnDelete.Text = "Delete Announcement";
			bttnDelete.UseVisualStyleBackColor = true;
			bttnDelete.Click += bttnDelete_Click;
			// 
			// bttnEdit
			// 
			bttnEdit.Location = new Point(84, 230);
			bttnEdit.Name = "bttnEdit";
			bttnEdit.Size = new Size(150, 49);
			bttnEdit.TabIndex = 60;
			bttnEdit.Text = "Edit Announcement";
			bttnEdit.UseVisualStyleBackColor = true;
			bttnEdit.Click += bttnEdit_Click;
			// 
			// dtpEndTime
			// 
			dtpEndTime.Location = new Point(390, 144);
			dtpEndTime.Name = "dtpEndTime";
			dtpEndTime.Size = new Size(226, 23);
			dtpEndTime.TabIndex = 59;
			// 
			// dtpStartTime
			// 
			dtpStartTime.Location = new Point(390, 76);
			dtpStartTime.Name = "dtpStartTime";
			dtpStartTime.Size = new Size(226, 23);
			dtpStartTime.TabIndex = 58;
			// 
			// lblED
			// 
			lblED.AutoSize = true;
			lblED.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblED.Location = new Point(390, 118);
			lblED.Name = "lblED";
			lblED.Size = new Size(158, 15);
			lblED.TabIndex = 57;
			lblED.Text = "End date of announcement:";
			// 
			// tbDetails
			// 
			tbDetails.Location = new Point(84, 135);
			tbDetails.Multiline = true;
			tbDetails.Name = "tbDetails";
			tbDetails.Size = new Size(196, 63);
			tbDetails.TabIndex = 55;
			// 
			// tbTitle
			// 
			tbTitle.Location = new Point(84, 76);
			tbTitle.Name = "tbTitle";
			tbTitle.Size = new Size(196, 23);
			tbTitle.TabIndex = 54;
			// 
			// lblSD
			// 
			lblSD.AutoSize = true;
			lblSD.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblSD.Location = new Point(390, 59);
			lblSD.Name = "lblSD";
			lblSD.Size = new Size(161, 15);
			lblSD.TabIndex = 53;
			lblSD.Text = "Start date of announcement:";
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(84, 59);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(132, 15);
			lblTitle.TabIndex = 52;
			lblTitle.Text = "Title of announcement:";
			// 
			// lblDetails
			// 
			lblDetails.AutoSize = true;
			lblDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblDetails.Location = new Point(84, 118);
			lblDetails.Name = "lblDetails";
			lblDetails.Size = new Size(147, 15);
			lblDetails.TabIndex = 56;
			lblDetails.Text = "Details of announcement:";
			// 
			// bttnSave
			// 
			bttnSave.Location = new Point(280, 230);
			bttnSave.Name = "bttnSave";
			bttnSave.Size = new Size(150, 49);
			bttnSave.TabIndex = 62;
			bttnSave.Text = "Save";
			bttnSave.UseVisualStyleBackColor = true;
			bttnSave.Click += bttnSave_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(23, 9);
			btnBack.Margin = new Padding(3, 2, 3, 2);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(83, 34);
			btnBack.TabIndex = 63;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// EditAnnouncement
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
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
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
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
	}
}