namespace GarageManagementApp
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            panel1 = new Panel();
            btnLogout = new Button();
            button5 = new Button();
            btnJobs = new Button();
            btnVehicles = new Button();
            btnCustomers = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnJobs);
            panel1.Controls.Add(btnVehicles);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 793);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 731);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(218, 50);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "       Log Out";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 438);
            button5.Name = "button5";
            button5.Size = new Size(218, 50);
            button5.TabIndex = 7;
            button5.Text = "       Example";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            btnJobs.FlatAppearance.BorderSize = 0;
            btnJobs.FlatStyle = FlatStyle.Flat;
            btnJobs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobs.ForeColor = Color.White;
            btnJobs.Image = (Image)resources.GetObject("btnJobs.Image");
            btnJobs.ImageAlign = ContentAlignment.MiddleLeft;
            btnJobs.Location = new Point(12, 382);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(218, 50);
            btnJobs.TabIndex = 6;
            btnJobs.Text = "        Jobs";
            btnJobs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnJobs.UseVisualStyleBackColor = true;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehicles.ForeColor = Color.White;
            btnVehicles.Image = (Image)resources.GetObject("btnVehicles.Image");
            btnVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicles.Location = new Point(12, 326);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(218, 50);
            btnVehicles.TabIndex = 5;
            btnVehicles.Text = "       Vehicles";
            btnVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(12, 270);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(218, 50);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "       Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 214);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(218, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "       Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 183);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 170);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(0, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 10);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 15);
            panel2.TabIndex = 1;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 793);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Name = "frmMainMenu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button btnHome;
        private Button button5;
        private Button btnJobs;
        private Button btnVehicles;
        private Button btnCustomers;
        private Button btnLogout;
    }
}