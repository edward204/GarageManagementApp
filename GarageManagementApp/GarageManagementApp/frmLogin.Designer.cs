namespace GarageManagementApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblSignup = new Label();
            lnklblSignup = new LinkLabel();
            panel1 = new Panel();
            btnShowpassword = new Button();
            btnHidepassword = new Button();
            lblUsername = new Label();
            btnLogin = new Button();
            txtboxPassword = new TextBox();
            txtboxUsername = new TextBox();
            lblPassword = new Label();
            panel2 = new Panel();
            lblLogin = new Label();
            picboxLogo = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.BackColor = Color.Gainsboro;
            lblSignup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignup.Location = new Point(44, 269);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(153, 19);
            lblSignup.TabIndex = 5;
            lblSignup.Text = "Don't have an account?";
            // 
            // lnklblSignup
            // 
            lnklblSignup.AutoSize = true;
            lnklblSignup.BackColor = Color.Gainsboro;
            lnklblSignup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lnklblSignup.Location = new Point(192, 269);
            lnklblSignup.Name = "lnklblSignup";
            lnklblSignup.Size = new Size(57, 19);
            lnklblSignup.TabIndex = 5;
            lnklblSignup.TabStop = true;
            lnklblSignup.Text = "Sign Up";
            lnklblSignup.LinkClicked += lnklblSignup_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnShowpassword);
            panel1.Controls.Add(btnHidepassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtboxPassword);
            panel1.Controls.Add(txtboxUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblSignup);
            panel1.Controls.Add(lnklblSignup);
            panel1.Location = new Point(503, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 320);
            panel1.TabIndex = 7;
            // 
            // btnShowpassword
            // 
            btnShowpassword.BackColor = Color.White;
            btnShowpassword.FlatAppearance.BorderColor = Color.Gray;
            btnShowpassword.FlatStyle = FlatStyle.Flat;
            btnShowpassword.Image = (Image)resources.GetObject("btnShowpassword.Image");
            btnShowpassword.Location = new Point(247, 125);
            btnShowpassword.Name = "btnShowpassword";
            btnShowpassword.Size = new Size(39, 39);
            btnShowpassword.TabIndex = 3;
            btnShowpassword.UseVisualStyleBackColor = false;
            btnShowpassword.Click += btnShowpassword_Click;
            // 
            // btnHidepassword
            // 
            btnHidepassword.BackColor = Color.White;
            btnHidepassword.FlatAppearance.BorderColor = Color.Gray;
            btnHidepassword.FlatStyle = FlatStyle.Flat;
            btnHidepassword.Image = (Image)resources.GetObject("btnHidepassword.Image");
            btnHidepassword.Location = new Point(247, 125);
            btnHidepassword.Name = "btnHidepassword";
            btnHidepassword.Size = new Size(39, 39);
            btnHidepassword.TabIndex = 9;
            btnHidepassword.UseVisualStyleBackColor = false;
            btnHidepassword.Click += btnHidepassword_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Gainsboro;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(14, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(93, 219);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxPassword.Location = new Point(14, 125);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '*';
            txtboxPassword.PlaceholderText = "Password";
            txtboxPassword.Size = new Size(272, 39);
            txtboxPassword.TabIndex = 2;
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxUsername.Location = new Point(14, 43);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PlaceholderText = "Username";
            txtboxUsername.Size = new Size(272, 39);
            txtboxUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Gainsboro;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(14, 102);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(lblLogin);
            panel2.Location = new Point(503, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 62);
            panel2.TabIndex = 8;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.LightBlue;
            lblLogin.Dock = DockStyle.Fill;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(0, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(300, 62);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login Form";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxLogo
            // 
            picboxLogo.BackgroundImage = (Image)resources.GetObject("picboxLogo.BackgroundImage");
            picboxLogo.Location = new Point(12, 13);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(476, 436);
            picboxLogo.TabIndex = 9;
            picboxLogo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(picboxLogo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblSignup;
        private LinkLabel lnklblSignup;
        private Panel panel1;
        private Label lblUsername;
        private Button btnLogin;
        private TextBox txtboxPassword;
        private TextBox txtboxUsername;
        private Label lblPassword;
        private Panel panel2;
        private Label lblLogin;
        private PictureBox picboxLogo;
        private Button btnHidepassword;
        private Button btnShowpassword;
    }
}