namespace Desktop_application
{
	partial class AdminRestockRequest
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
			lblRestockReq = new Label();
			btnSend = new Button();
			btnBack = new Button();
			lblType = new Label();
			lblQuantity = new Label();
			lblName = new Label();
			cbType = new ComboBox();
			NUDQuantity = new NumericUpDown();
			cbName = new ComboBox();
			((System.ComponentModel.ISupportInitialize)NUDQuantity).BeginInit();
			SuspendLayout();
			// 
			// lblRestockReq
			// 
			lblRestockReq.AutoSize = true;
			lblRestockReq.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblRestockReq.Location = new Point(77, 28);
			lblRestockReq.Name = "lblRestockReq";
			lblRestockReq.Size = new Size(282, 29);
			lblRestockReq.TabIndex = 22;
			lblRestockReq.Text = "Send a restock request";
			// 
			// btnSend
			// 
			btnSend.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSend.Location = new Point(247, 289);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(112, 60);
			btnSend.TabIndex = 23;
			btnSend.Text = "Send request";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(77, 289);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(93, 60);
			btnBack.TabIndex = 24;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblType.Location = new Point(56, 113);
			lblType.Name = "lblType";
			lblType.Size = new Size(94, 21);
			lblType.TabIndex = 25;
			lblType.Text = "Stock type:";
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblQuantity.Location = new Point(69, 181);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(81, 21);
			lblQuantity.TabIndex = 26;
			lblQuantity.Text = "Quantity:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.Location = new Point(47, 147);
			lblName.Name = "lblName";
			lblName.Size = new Size(103, 21);
			lblName.TabIndex = 27;
			lblName.Text = "Stock name:";
			// 
			// cbType
			// 
			cbType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			cbType.FormattingEnabled = true;
			cbType.Location = new Point(154, 110);
			cbType.Name = "cbType";
			cbType.Size = new Size(182, 29);
			cbType.TabIndex = 28;
			cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
			// 
			// NUDQuantity
			// 
			NUDQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			NUDQuantity.Location = new Point(154, 179);
			NUDQuantity.Name = "NUDQuantity";
			NUDQuantity.Size = new Size(182, 29);
			NUDQuantity.TabIndex = 29;
			// 
			// cbName
			// 
			cbName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			cbName.FormattingEnabled = true;
			cbName.Location = new Point(154, 145);
			cbName.Name = "cbName";
			cbName.Size = new Size(182, 29);
			cbName.TabIndex = 30;
			// 
			// AdminRestockRequest
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 374);
			Controls.Add(cbName);
			Controls.Add(NUDQuantity);
			Controls.Add(cbType);
			Controls.Add(lblName);
			Controls.Add(lblQuantity);
			Controls.Add(lblType);
			Controls.Add(btnBack);
			Controls.Add(btnSend);
			Controls.Add(lblRestockReq);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AdminRestockRequest";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Send a restock request";
			((System.ComponentModel.ISupportInitialize)NUDQuantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblRestockReq;
		private Button btnSend;
		private Button btnBack;
		private Label lblType;
		private Label lblQuantity;
		private Label lblName;
		private ComboBox cbType;
		private NumericUpDown NUDQuantity;
		private ComboBox cbName;
	}
}