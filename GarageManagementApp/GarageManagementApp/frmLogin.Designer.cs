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
            lblUsername = new Label();
            btnLogin = new Button();
            txtboxPassword = new TextBox();
            txtboxUsername = new TextBox();
            lblPassword = new Label();
            panel2 = new Panel();
            lblLogin = new Label();
            picboxLogo = new PictureBox();
            lstTest = new ListBox();
            btnTest = new Button();
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
            lnklblSignup.TabIndex = 6;
            lnklblSignup.TabStop = true;
            lnklblSignup.Text = "Sign Up";
            lnklblSignup.LinkClicked += lnklblSignup_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Gainsboro;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(44, 21);
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
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxPassword.Location = new Point(44, 126);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PlaceholderText = "Password";
            txtboxPassword.Size = new Size(220, 39);
            txtboxPassword.TabIndex = 10;
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxUsername.Location = new Point(44, 44);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PlaceholderText = "Username";
            txtboxUsername.Size = new Size(220, 39);
            txtboxUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Gainsboro;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(44, 103);
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
            lblLogin.BackColor = Color.DeepSkyBlue;
            lblLogin.Dock = DockStyle.Fill;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.White;
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
            // lstTest
            // 
            lstTest.FormattingEnabled = true;
            lstTest.ItemHeight = 15;
            lstTest.Location = new Point(12, 22);
            lstTest.Name = "lstTest";
            lstTest.Size = new Size(287, 199);
            lstTest.TabIndex = 10;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(362, 115);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 11;
            btnTest.Text = "Load";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(btnTest);
            Controls.Add(lstTest);
            Controls.Add(picboxLogo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
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
        private ListBox lstTest;
        private Button btnTest;
    }
}