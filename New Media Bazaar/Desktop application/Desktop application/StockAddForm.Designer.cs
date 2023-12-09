namespace Desktop_application
{
	partial class StockAddForm
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
			btnBack = new Button();
			btnAdd = new Button();
			lblVrajeala = new Label();
			lblName = new Label();
			lblQuantity = new Label();
			lblType = new Label();
			cbType = new ComboBox();
			tbName = new TextBox();
			NUDQuantity = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)NUDQuantity).BeginInit();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnBack.Location = new Point(79, 288);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(118, 48);
			btnBack.TabIndex = 0;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.Location = new Point(229, 288);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(118, 48);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Add new stock";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblVrajeala
			// 
			lblVrajeala.AutoSize = true;
			lblVrajeala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblVrajeala.Location = new Point(139, 21);
			lblVrajeala.Name = "lblVrajeala";
			lblVrajeala.Size = new Size(134, 21);
			lblVrajeala.TabIndex = 2;
			lblVrajeala.Text = "Add a new stock";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.Location = new Point(39, 117);
			lblName.Name = "lblName";
			lblName.Size = new Size(103, 21);
			lblName.TabIndex = 30;
			lblName.Text = "Stock name:";
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblQuantity.Location = new Point(61, 151);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(81, 21);
			lblQuantity.TabIndex = 29;
			lblQuantity.Text = "Quantity:";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblType.Location = new Point(48, 83);
			lblType.Name = "lblType";
			lblType.Size = new Size(94, 21);
			lblType.TabIndex = 28;
			lblType.Text = "Stock type:";
			// 
			// cbType
			// 
			cbType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			cbType.FormattingEnabled = true;
			cbType.Location = new Point(152, 83);
			cbType.Name = "cbType";
			cbType.Size = new Size(152, 28);
			cbType.TabIndex = 31;
			// 
			// tbName
			// 
			tbName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			tbName.Location = new Point(152, 117);
			tbName.Name = "tbName";
			tbName.Size = new Size(152, 27);
			tbName.TabIndex = 32;
			// 
			// NUDQuantity
			// 
			NUDQuantity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			NUDQuantity.Location = new Point(152, 150);
			NUDQuantity.Name = "NUDQuantity";
			NUDQuantity.Size = new Size(151, 27);
			NUDQuantity.TabIndex = 33;
			// 
			// StockAddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 374);
			Controls.Add(NUDQuantity);
			Controls.Add(tbName);
			Controls.Add(cbType);
			Controls.Add(lblName);
			Controls.Add(lblQuantity);
			Controls.Add(lblType);
			Controls.Add(lblVrajeala);
			Controls.Add(btnAdd);
			Controls.Add(btnBack);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "StockAddForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add new stocks";
			((System.ComponentModel.ISupportInitialize)NUDQuantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBack;
		private Button btnAdd;
		private Label lblVrajeala;
		private Label lblName;
		private Label lblQuantity;
		private Label lblType;
		private ComboBox cbType;
		private TextBox tbName;
		private NumericUpDown NUDQuantity;
	}
}