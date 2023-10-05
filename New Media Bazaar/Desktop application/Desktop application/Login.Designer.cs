namespace Desktop_application
{
    partial class Login
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
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lblLogin = new Label();
            lblMediaBazaar = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Thistle;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(262, 475);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 55);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(142, 374);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 25);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(139, 319);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 25);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(262, 379);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(176, 27);
            tbPassword.TabIndex = 10;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(262, 323);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(176, 27);
            tbUsername.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(298, 191);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(78, 29);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login";
            // 
            // lblMediaBazaar
            // 
            lblMediaBazaar.AutoSize = true;
            lblMediaBazaar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMediaBazaar.Location = new Point(229, 133);
            lblMediaBazaar.Name = "lblMediaBazaar";
            lblMediaBazaar.Size = new Size(209, 36);
            lblMediaBazaar.TabIndex = 7;
            lblMediaBazaar.Text = "Media Bazaar";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 691);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblLogin);
            Controls.Add(lblMediaBazaar);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblLogin;
        private Label lblMediaBazaar;
    }
}