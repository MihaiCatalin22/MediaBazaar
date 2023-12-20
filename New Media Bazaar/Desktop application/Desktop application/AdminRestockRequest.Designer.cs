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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRestockRequest));
            lblRestockReq = new Label();
            btnSend = new Button();
            btnBack = new Button();
            lblType = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            cbType = new ComboBox();
            NUDQuantity = new NumericUpDown();
            cbName = new ComboBox();
            btnExitAdminRestockDetails = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRestockReq
            // 
            lblRestockReq.AutoSize = true;
            lblRestockReq.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestockReq.Location = new Point(79, 89);
            lblRestockReq.Name = "lblRestockReq";
            lblRestockReq.Size = new Size(342, 36);
            lblRestockReq.TabIndex = 22;
            lblRestockReq.Text = "Send a restock request";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Black;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(282, 385);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(128, 80);
            btnSend.TabIndex = 23;
            btnSend.Text = "Send request";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(88, 385);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 80);
            btnBack.TabIndex = 24;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(64, 151);
            lblType.Name = "lblType";
            lblType.Size = new Size(117, 28);
            lblType.TabIndex = 25;
            lblType.Text = "Stock type:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(79, 241);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 28);
            lblQuantity.TabIndex = 26;
            lblQuantity.Text = "Quantity:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(54, 196);
            lblName.Name = "lblName";
            lblName.Size = new Size(127, 28);
            lblName.TabIndex = 27;
            lblName.Text = "Stock name:";
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(176, 147);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(207, 36);
            cbType.TabIndex = 28;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // NUDQuantity
            // 
            NUDQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NUDQuantity.Location = new Point(176, 239);
            NUDQuantity.Margin = new Padding(3, 4, 3, 4);
            NUDQuantity.Name = "NUDQuantity";
            NUDQuantity.Size = new Size(208, 34);
            NUDQuantity.TabIndex = 29;
            // 
            // cbName
            // 
            cbName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(176, 193);
            cbName.Margin = new Padding(3, 4, 3, 4);
            cbName.Name = "cbName";
            cbName.Size = new Size(207, 36);
            cbName.TabIndex = 30;
            // 
            // btnExitAdminRestockDetails
            // 
            btnExitAdminRestockDetails.BackColor = Color.Firebrick;
            btnExitAdminRestockDetails.FlatAppearance.BorderSize = 0;
            btnExitAdminRestockDetails.FlatStyle = FlatStyle.Flat;
            btnExitAdminRestockDetails.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitAdminRestockDetails.ForeColor = Color.White;
            btnExitAdminRestockDetails.Location = new Point(448, -1);
            btnExitAdminRestockDetails.Name = "btnExitAdminRestockDetails";
            btnExitAdminRestockDetails.Size = new Size(35, 29);
            btnExitAdminRestockDetails.TabIndex = 31;
            btnExitAdminRestockDetails.Text = "X";
            btnExitAdminRestockDetails.UseVisualStyleBackColor = false;
            btnExitAdminRestockDetails.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(176, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 3);
            panel1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(176, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 3);
            panel2.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(176, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 3);
            panel3.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // AdminRestockRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 499);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExitAdminRestockDetails);
            Controls.Add(cbName);
            Controls.Add(NUDQuantity);
            Controls.Add(cbType);
            Controls.Add(lblName);
            Controls.Add(lblQuantity);
            Controls.Add(lblType);
            Controls.Add(btnBack);
            Controls.Add(btnSend);
            Controls.Add(lblRestockReq);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminRestockRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Send a restock request";
            Load += AdminRestockRequest_Load_1;
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnExitAdminRestockDetails;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}