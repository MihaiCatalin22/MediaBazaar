namespace Desktop_application
{
	partial class Vacations
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
			listBoxVacations = new ListBox();
			label1 = new Label();
			btnReject = new Button();
			btnApprove = new Button();
			labelReason = new Label();
			labelEndDate = new Label();
			labelStartDate = new Label();
			labelEmployee = new Label();
			labelStatus = new Label();
			btnExitCreateAnnouncement = new Button();
			SuspendLayout();
			// 
			// listBoxVacations
			// 
			listBoxVacations.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			listBoxVacations.FormattingEnabled = true;
			listBoxVacations.HorizontalScrollbar = true;
			listBoxVacations.ItemHeight = 30;
			listBoxVacations.Location = new Point(50, 100);
			listBoxVacations.Margin = new Padding(3, 4, 3, 4);
			listBoxVacations.Name = "listBoxVacations";
			listBoxVacations.Size = new Size(399, 424);
			listBoxVacations.TabIndex = 8;
			listBoxVacations.SelectedIndexChanged += listBoxVacations_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(354, 25);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(204, 31);
			label1.TabIndex = 9;
			label1.Text = "Vacations Page";
			// 
			// btnReject
			// 
			btnReject.BackColor = Color.IndianRed;
			btnReject.FlatStyle = FlatStyle.Flat;
			btnReject.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			btnReject.ForeColor = Color.White;
			btnReject.Location = new Point(658, 475);
			btnReject.Margin = new Padding(2, 1, 2, 1);
			btnReject.Name = "btnReject";
			btnReject.Size = new Size(152, 49);
			btnReject.TabIndex = 27;
			btnReject.Text = "Reject";
			btnReject.UseVisualStyleBackColor = false;
			btnReject.Visible = false;
			btnReject.Click += btnReject_Click;
			// 
			// btnApprove
			// 
			btnApprove.BackColor = Color.SeaGreen;
			btnApprove.FlatStyle = FlatStyle.Flat;
			btnApprove.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			btnApprove.ForeColor = Color.White;
			btnApprove.Location = new Point(474, 475);
			btnApprove.Margin = new Padding(2, 1, 2, 1);
			btnApprove.Name = "btnApprove";
			btnApprove.Size = new Size(152, 49);
			btnApprove.TabIndex = 26;
			btnApprove.Text = "Approve";
			btnApprove.UseVisualStyleBackColor = false;
			btnApprove.Visible = false;
			btnApprove.Click += btnApprove_Click;
			// 
			// labelReason
			// 
			labelReason.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			labelReason.Location = new Point(474, 248);
			labelReason.Margin = new Padding(2, 0, 2, 0);
			labelReason.Name = "labelReason";
			labelReason.Size = new Size(395, 161);
			labelReason.TabIndex = 25;
			labelReason.Text = "Reason:\r\n";
			labelReason.Visible = false;
			// 
			// labelEndDate
			// 
			labelEndDate.AutoSize = true;
			labelEndDate.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			labelEndDate.Location = new Point(474, 200);
			labelEndDate.Margin = new Padding(2, 0, 2, 0);
			labelEndDate.Name = "labelEndDate";
			labelEndDate.Size = new Size(130, 31);
			labelEndDate.TabIndex = 24;
			labelEndDate.Text = "End date:";
			labelEndDate.Visible = false;
			// 
			// labelStartDate
			// 
			labelStartDate.AutoSize = true;
			labelStartDate.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			labelStartDate.Location = new Point(474, 149);
			labelStartDate.Margin = new Padding(2, 0, 2, 0);
			labelStartDate.Name = "labelStartDate";
			labelStartDate.Size = new Size(140, 31);
			labelStartDate.TabIndex = 23;
			labelStartDate.Text = "Start date:";
			labelStartDate.Visible = false;
			// 
			// labelEmployee
			// 
			labelEmployee.AutoSize = true;
			labelEmployee.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			labelEmployee.Location = new Point(474, 100);
			labelEmployee.Margin = new Padding(2, 0, 2, 0);
			labelEmployee.Name = "labelEmployee";
			labelEmployee.Size = new Size(142, 31);
			labelEmployee.TabIndex = 22;
			labelEmployee.Text = "Employee:";
			labelEmployee.Visible = false;
			// 
			// labelStatus
			// 
			labelStatus.AutoSize = true;
			labelStatus.Font = new Font("Microsoft Sans Serif", 15.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			labelStatus.Location = new Point(474, 409);
			labelStatus.Margin = new Padding(2, 0, 2, 0);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(107, 31);
			labelStatus.TabIndex = 28;
			labelStatus.Text = "Status: ";
			labelStatus.Visible = false;
			// 
			// btnExitCreateAnnouncement
			// 
			btnExitCreateAnnouncement.BackColor = Color.Firebrick;
			btnExitCreateAnnouncement.FlatAppearance.BorderSize = 0;
			btnExitCreateAnnouncement.FlatStyle = FlatStyle.Flat;
			btnExitCreateAnnouncement.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnExitCreateAnnouncement.ForeColor = Color.White;
			btnExitCreateAnnouncement.Location = new Point(847, 0);
			btnExitCreateAnnouncement.Name = "btnExitCreateAnnouncement";
			btnExitCreateAnnouncement.Size = new Size(35, 36);
			btnExitCreateAnnouncement.TabIndex = 56;
			btnExitCreateAnnouncement.Text = "X";
			btnExitCreateAnnouncement.UseVisualStyleBackColor = false;
			btnExitCreateAnnouncement.Click += btnExitCreateAnnouncement_Click;
			// 
			// Vacations
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(880, 550);
			Controls.Add(btnExitCreateAnnouncement);
			Controls.Add(btnReject);
			Controls.Add(btnApprove);
			Controls.Add(labelReason);
			Controls.Add(labelEndDate);
			Controls.Add(labelStartDate);
			Controls.Add(labelEmployee);
			Controls.Add(labelStatus);
			Controls.Add(label1);
			Controls.Add(listBoxVacations);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Vacations";
			Text = "Vacations";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBoxVacations;
		private Label label1;
		private Button btnReject;
		private Button btnApprove;
		private Label labelReason;
		private Label labelEndDate;
		private Label labelStartDate;
		private Label labelEmployee;
		private Label labelStatus;
		private Button btnExitCreateAnnouncement;
	}
}