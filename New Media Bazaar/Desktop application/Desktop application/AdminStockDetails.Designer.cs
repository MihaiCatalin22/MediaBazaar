namespace Desktop_application
{
    partial class AdminStockDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStockDetails));
            panel2 = new Panel();
            btnLogout = new Button();
            btnStocks = new Button();
            bttnAnnouncement = new Button();
            btnDepartments = new Button();
            bttnShifts = new Button();
            bttnEmployees = new Button();
            cbStockTypes = new ComboBox();
            btnRestock = new Button();
            lVStockDetails = new ListView();
            StockName = new ColumnHeader();
            StockType = new ColumnHeader();
            Quantity = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            lblSearchName = new Label();
            tbName = new TextBox();
            panel7 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnStocks);
            panel2.Controls.Add(bttnAnnouncement);
            panel2.Controls.Add(btnDepartments);
            panel2.Controls.Add(bttnShifts);
            panel2.Controls.Add(bttnEmployees);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 125);
            panel2.TabIndex = 36;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1025, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 125);
            btnLogout.TabIndex = 43;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStocks
            // 
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStocks.ForeColor = Color.White;
            btnStocks.Location = new Point(846, 0);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(160, 125);
            btnStocks.TabIndex = 45;
            btnStocks.Text = "Stocks";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // bttnAnnouncement
            // 
            bttnAnnouncement.BackColor = Color.Black;
            bttnAnnouncement.FlatAppearance.BorderSize = 0;
            bttnAnnouncement.FlatStyle = FlatStyle.Flat;
            bttnAnnouncement.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnAnnouncement.ForeColor = Color.White;
            bttnAnnouncement.Location = new Point(12, 0);
            bttnAnnouncement.Name = "bttnAnnouncement";
            bttnAnnouncement.Size = new Size(211, 125);
            bttnAnnouncement.TabIndex = 41;
            bttnAnnouncement.Text = "Announcements";
            bttnAnnouncement.UseVisualStyleBackColor = false;
            bttnAnnouncement.Click += bttnAnnouncement_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.White;
            btnDepartments.Location = new Point(482, 0);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(203, 125);
            btnDepartments.TabIndex = 43;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // bttnShifts
            // 
            bttnShifts.FlatAppearance.BorderSize = 0;
            bttnShifts.FlatStyle = FlatStyle.Flat;
            bttnShifts.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnShifts.ForeColor = Color.White;
            bttnShifts.Location = new Point(705, 0);
            bttnShifts.Name = "bttnShifts";
            bttnShifts.Size = new Size(135, 125);
            bttnShifts.TabIndex = 44;
            bttnShifts.Text = "Shifts";
            bttnShifts.UseVisualStyleBackColor = true;
            bttnShifts.Click += bttnShifts_Click;
            // 
            // bttnEmployees
            // 
            bttnEmployees.FlatAppearance.BorderSize = 0;
            bttnEmployees.FlatStyle = FlatStyle.Flat;
            bttnEmployees.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bttnEmployees.ForeColor = Color.White;
            bttnEmployees.Location = new Point(267, 0);
            bttnEmployees.Name = "bttnEmployees";
            bttnEmployees.Size = new Size(170, 125);
            bttnEmployees.TabIndex = 42;
            bttnEmployees.Text = "Employees";
            bttnEmployees.UseVisualStyleBackColor = true;
            bttnEmployees.Click += bttnEmployees_Click;
            // 
            // cbStockTypes
            // 
            cbStockTypes.FormattingEnabled = true;
            cbStockTypes.Location = new Point(785, 259);
            cbStockTypes.Margin = new Padding(3, 4, 3, 4);
            cbStockTypes.Name = "cbStockTypes";
            cbStockTypes.Size = new Size(315, 28);
            cbStockTypes.TabIndex = 38;
            cbStockTypes.SelectedIndexChanged += cbStockTypes_SelectedIndexChanged;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.Black;
            btnRestock.FlatAppearance.BorderSize = 0;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(946, 547);
            btnRestock.Margin = new Padding(3, 4, 3, 4);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(154, 83);
            btnRestock.TabIndex = 39;
            btnRestock.Text = "Send a restock request";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // lVStockDetails
            // 
            lVStockDetails.Columns.AddRange(new ColumnHeader[] { StockName, StockType, Quantity });
            lVStockDetails.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lVStockDetails.Location = new Point(97, 247);
            lVStockDetails.Margin = new Padding(3, 4, 3, 4);
            lVStockDetails.Name = "lVStockDetails";
            lVStockDetails.Size = new Size(601, 383);
            lVStockDetails.TabIndex = 40;
            lVStockDetails.UseCompatibleStateImageBehavior = false;
            // 
            // StockName
            // 
            StockName.Text = "Stock Name";
            StockName.Width = 300;
            // 
            // StockType
            // 
            StockType.Text = "StockType";
            StockType.TextAlign = HorizontalAlignment.Center;
            StockType.Width = 150;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.TextAlign = HorizontalAlignment.Center;
            Quantity.Width = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(801, 215);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 41;
            label1.Text = "Select stock type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 215);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 42;
            label2.Text = "Stock info:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(785, 547);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 83);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add new stocks";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearchName.Location = new Point(800, 305);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(239, 25);
            lblSearchName.TabIndex = 44;
            lblSearchName.Text = "Search for a specific stock:";
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Location = new Point(785, 347);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(315, 20);
            tbName.TabIndex = 45;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(785, 285);
            panel7.Name = "panel7";
            panel7.Size = new Size(315, 4);
            panel7.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(785, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 4);
            panel1.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(97, 627);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 4);
            panel3.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(946, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // AdminStockDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 691);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(tbName);
            Controls.Add(lblSearchName);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lVStockDetails);
            Controls.Add(btnRestock);
            Controls.Add(cbStockTypes);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminStockDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stocks";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnLogout;
        private Button btnStocks;
        private Button bttnAnnouncement;
        private Button btnDepartments;
        private Button bttnShifts;
        private Button bttnEmployees;
        private ComboBox cbStockTypes;
        private Button btnRestock;
        private ListView lVStockDetails;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private ColumnHeader StockName;
        private ColumnHeader StockType;
        private ColumnHeader Quantity;
        private Label lblSearchName;
        private TextBox tbName;
        private Panel panel7;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}