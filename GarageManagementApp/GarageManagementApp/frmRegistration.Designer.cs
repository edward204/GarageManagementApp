namespace GarageManagementApp
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            panel1 = new Panel();
            btnCreateuser = new Button();
            txtboxConfirmpassword = new TextBox();
            lblConfirmpassword = new Label();
            txtboxCreatepassword = new TextBox();
            txtboxCreateusername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            panel2 = new Panel();
            lblUsercreation = new Label();
            picboxLogo = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnCreateuser);
            panel1.Controls.Add(txtboxConfirmpassword);
            panel1.Controls.Add(lblConfirmpassword);
            panel1.Controls.Add(txtboxCreatepassword);
            panel1.Controls.Add(txtboxCreateusername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(503, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 320);
            panel1.TabIndex = 0;
            // 
            // btnCreateuser
            // 
            btnCreateuser.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateuser.Location = new Point(80, 267);
            btnCreateuser.Name = "btnCreateuser";
            btnCreateuser.Size = new Size(135, 39);
            btnCreateuser.TabIndex = 6;
            btnCreateuser.Text = "Create User";
            btnCreateuser.UseVisualStyleBackColor = true;
            // 
            // txtboxConfirmpassword
            // 
            txtboxConfirmpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxConfirmpassword.Location = new Point(44, 199);
            txtboxConfirmpassword.Name = "txtboxConfirmpassword";
            txtboxConfirmpassword.PlaceholderText = "Confirm Password";
            txtboxConfirmpassword.Size = new Size(220, 39);
            txtboxConfirmpassword.TabIndex = 5;
            // 
            // lblConfirmpassword
            // 
            lblConfirmpassword.AutoSize = true;
            lblConfirmpassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmpassword.Location = new Point(44, 176);
            lblConfirmpassword.Name = "lblConfirmpassword";
            lblConfirmpassword.Size = new Size(127, 20);
            lblConfirmpassword.TabIndex = 4;
            lblConfirmpassword.Text = "Confirm Password";
            // 
            // txtboxCreatepassword
            // 
            txtboxCreatepassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxCreatepassword.Location = new Point(44, 117);
            txtboxCreatepassword.Name = "txtboxCreatepassword";
            txtboxCreatepassword.PlaceholderText = "Password";
            txtboxCreatepassword.Size = new Size(220, 39);
            txtboxCreatepassword.TabIndex = 3;
            // 
            // txtboxCreateusername
            // 
            txtboxCreateusername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxCreateusername.Location = new Point(44, 35);
            txtboxCreateusername.Name = "txtboxCreateusername";
            txtboxCreateusername.PlaceholderText = "Username";
            txtboxCreateusername.Size = new Size(220, 39);
            txtboxCreateusername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(44, 94);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(44, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(lblUsercreation);
            panel2.Location = new Point(503, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 62);
            panel2.TabIndex = 1;
            // 
            // lblUsercreation
            // 
            lblUsercreation.Dock = DockStyle.Fill;
            lblUsercreation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsercreation.ForeColor = Color.White;
            lblUsercreation.Location = new Point(0, 0);
            lblUsercreation.Name = "lblUsercreation";
            lblUsercreation.Size = new Size(300, 62);
            lblUsercreation.TabIndex = 0;
            lblUsercreation.Text = "User Creation ";
            lblUsercreation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxLogo
            // 
            picboxLogo.BackgroundImage = (Image)resources.GetObject("picboxLogo.BackgroundImage");
            picboxLogo.Image = (Image)resources.GetObject("picboxLogo.Image");
            picboxLogo.Location = new Point(12, 12);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(476, 366);
            picboxLogo.TabIndex = 2;
            picboxLogo.TabStop = false;
            // 
            // frmRegistration
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
            Name = "frmRegistration";
            Text = "Create User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblUsercreation;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtboxCreateusername;
        private TextBox txtboxCreatepassword;
        private TextBox txtboxConfirmpassword;
        private Label lblConfirmpassword;
        private Button btnCreateuser;
        private PictureBox picboxLogo;
    }
}