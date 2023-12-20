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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAddForm));
            btnBack = new Button();
            btnAdd = new Button();
            lblVrajeala = new Label();
            lblName = new Label();
            lblQuantity = new Label();
            lblType = new Label();
            cbType = new ComboBox();
            tbName = new TextBox();
            NUDQuantity = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Firebrick;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(426, -1);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(58, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "X";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(89, 295);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(315, 64);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new stock";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblVrajeala
            // 
            lblVrajeala.AutoSize = true;
            lblVrajeala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVrajeala.Location = new Point(150, 48);
            lblVrajeala.Name = "lblVrajeala";
            lblVrajeala.Size = new Size(168, 28);
            lblVrajeala.TabIndex = 2;
            lblVrajeala.Text = "Add a new stock";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(79, 159);
            lblName.Name = "lblName";
            lblName.Size = new Size(127, 28);
            lblName.TabIndex = 30;
            lblName.Text = "Stock name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(104, 204);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 28);
            lblQuantity.TabIndex = 29;
            lblQuantity.Text = "Quantity:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(89, 114);
            lblType.Name = "lblType";
            lblType.Size = new Size(117, 28);
            lblType.TabIndex = 28;
            lblType.Text = "Stock type:";
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(208, 114);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(173, 33);
            cbType.TabIndex = 31;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.Location = new Point(208, 159);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(173, 32);
            tbName.TabIndex = 32;
            // 
            // NUDQuantity
            // 
            NUDQuantity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NUDQuantity.Location = new Point(208, 203);
            NUDQuantity.Margin = new Padding(3, 4, 3, 4);
            NUDQuantity.Name = "NUDQuantity";
            NUDQuantity.Size = new Size(173, 32);
            NUDQuantity.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // StockAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 430);
            Controls.Add(pictureBox1);
            Controls.Add(NUDQuantity);
            Controls.Add(tbName);
            Controls.Add(cbType);
            Controls.Add(lblName);
            Controls.Add(lblQuantity);
            Controls.Add(lblType);
            Controls.Add(lblVrajeala);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StockAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new stocks";
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}