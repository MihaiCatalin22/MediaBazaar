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
            btnAdd = new Button();
            btnSearch = new Button();
            lbxEmployees = new ListBox();
            label1 = new Label();
            txbSearch = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(108, 516);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 76);
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
            btnSearch.Location = new Point(312, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(39, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lbxEmployees
            // 
            lbxEmployees.FormattingEnabled = true;
            lbxEmployees.ItemHeight = 15;
            lbxEmployees.Location = new Point(12, 110);
            lbxEmployees.Name = "lbxEmployees";
            lbxEmployees.Size = new Size(340, 379);
            lbxEmployees.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 19);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 6;
            label1.Text = "Choose employee";
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearch.Location = new Point(12, 74);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(294, 30);
            txbSearch.TabIndex = 5;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // ChooseEmployeeByDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 611);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lbxEmployees);
            Controls.Add(label1);
            Controls.Add(txbSearch);
            Name = "ChooseEmployeeByDepartment";
            Text = "ChooseEmployeeByDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private ListBox lbxEmployees;
        private Label label1;
        private TextBox txbSearch;
    }
}