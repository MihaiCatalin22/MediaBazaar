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
            lbxEmployees.FormattingEnabled = true;
            lbxEmployees.ItemHeight = 20;
            lbxEmployees.Location = new Point(14, 147);
            lbxEmployees.Margin = new Padding(3, 4, 3, 4);
            lbxEmployees.Name = "lbxEmployees";
            lbxEmployees.Size = new Size(388, 504);
            lbxEmployees.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 25);
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
            // ChooseEmployeeByDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 815);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lbxEmployees);
            Controls.Add(label1);
            Controls.Add(txbSearch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseEmployeeByDepartment";
            StartPosition = FormStartPosition.CenterScreen;
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