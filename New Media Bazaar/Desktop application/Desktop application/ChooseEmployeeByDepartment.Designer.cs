namespace Desktop_application
{
    partial class ChooseEmployeeByDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseEmployeeByDepartment));
            btnAdd = new Button();
            btnSearch = new Button();
            lbxEmployees = new ListBox();
            label1 = new Label();
            txbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnExitChooseEmpByDepartment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(123, 688);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 101);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(357, 99);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lbxEmployees
            // 
            lbxEmployees.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxEmployees.FormattingEnabled = true;
            lbxEmployees.ItemHeight = 23;
            lbxEmployees.Location = new Point(14, 147);
            lbxEmployees.Margin = new Padding(3, 4, 3, 4);
            lbxEmployees.Name = "lbxEmployees";
            lbxEmployees.Size = new Size(388, 487);
            lbxEmployees.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 60);
            label1.Name = "label1";
            label1.Size = new Size(261, 33);
            label1.TabIndex = 6;
            label1.Text = "Choose employee";
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearch.Location = new Point(14, 99);
            txbSearch.Margin = new Padding(3, 4, 3, 4);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(335, 36);
            txbSearch.TabIndex = 5;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(12, 132);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 3);
            panel7.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(16, 630);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 4);
            panel1.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(123, 786);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 3);
            panel2.TabIndex = 53;
            // 
            // btnExitChooseEmpByDepartment
            // 
            btnExitChooseEmpByDepartment.BackColor = Color.Firebrick;
            btnExitChooseEmpByDepartment.FlatAppearance.BorderSize = 0;
            btnExitChooseEmpByDepartment.FlatStyle = FlatStyle.Flat;
            btnExitChooseEmpByDepartment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitChooseEmpByDepartment.ForeColor = Color.White;
            btnExitChooseEmpByDepartment.Location = new Point(382, -5);
            btnExitChooseEmpByDepartment.Name = "btnExitChooseEmpByDepartment";
            btnExitChooseEmpByDepartment.Size = new Size(35, 36);
            btnExitChooseEmpByDepartment.TabIndex = 54;
            btnExitChooseEmpByDepartment.Text = "X";
            btnExitChooseEmpByDepartment.UseVisualStyleBackColor = false;
            btnExitChooseEmpByDepartment.Click += btnExitChooseEmpByDepartment_Click;
            // 
            // ChooseEmployeeByDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 815);
            Controls.Add(btnExitChooseEmpByDepartment);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lbxEmployees);
            Controls.Add(label1);
            Controls.Add(txbSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseEmployeeByDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseEmployeeByDepartment";
            Load += ChooseEmployeeByDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private ListBox lbxEmployees;
        private Label label1;
        private TextBox txbSearch;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel1;
        private Panel panel2;
        private Button btnExitChooseEmpByDepartment;
    }
}