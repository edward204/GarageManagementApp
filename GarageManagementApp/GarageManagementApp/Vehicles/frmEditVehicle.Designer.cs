namespace GarageManagementApp.Vehicles
{
    partial class frmEditVehicle
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
            label5 = new Label();
            btnCreatevehicle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtboxRegplate = new TextBox();
            txtboxVehiclecolour = new TextBox();
            txtboxVehiclemodel = new TextBox();
            txtboxVehiclemake = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(194, 21);
            label5.TabIndex = 0;
            label5.Text = "Edit vehicle details below";
            // 
            // btnCreatevehicle
            // 
            btnCreatevehicle.BackColor = Color.LightBlue;
            btnCreatevehicle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatevehicle.Location = new Point(160, 259);
            btnCreatevehicle.Name = "btnCreatevehicle";
            btnCreatevehicle.Size = new Size(113, 48);
            btnCreatevehicle.TabIndex = 32;
            btnCreatevehicle.Text = "Save";
            btnCreatevehicle.UseVisualStyleBackColor = false;
            btnCreatevehicle.Click += btnCreatevehicle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 183);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 31;
            label8.Text = "Vehicle Colour";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 154);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 30;
            label7.Text = "Registration Plate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 125);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 29;
            label6.Text = "Vehicle Model";
            // 
            // txtboxRegplate
            // 
            txtboxRegplate.Location = new Point(160, 151);
            txtboxRegplate.Name = "txtboxRegplate";
            txtboxRegplate.Size = new Size(230, 23);
            txtboxRegplate.TabIndex = 27;
            // 
            // txtboxVehiclecolour
            // 
            txtboxVehiclecolour.Location = new Point(160, 180);
            txtboxVehiclecolour.Name = "txtboxVehiclecolour";
            txtboxVehiclecolour.Size = new Size(230, 23);
            txtboxVehiclecolour.TabIndex = 28;
            // 
            // txtboxVehiclemodel
            // 
            txtboxVehiclemodel.Location = new Point(160, 122);
            txtboxVehiclemodel.Name = "txtboxVehiclemodel";
            txtboxVehiclemodel.Size = new Size(230, 23);
            txtboxVehiclemodel.TabIndex = 26;
            // 
            // txtboxVehiclemake
            // 
            txtboxVehiclemake.Location = new Point(160, 93);
            txtboxVehiclemake.Name = "txtboxVehiclemake";
            txtboxVehiclemake.Size = new Size(230, 23);
            txtboxVehiclemake.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 96);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 24;
            label1.Text = "Vehicle Make";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 43);
            panel1.TabIndex = 23;
            // 
            // frmEditVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 321);
            Controls.Add(btnCreatevehicle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtboxRegplate);
            Controls.Add(txtboxVehiclecolour);
            Controls.Add(txtboxVehiclemodel);
            Controls.Add(txtboxVehiclemake);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditVehicle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnCreatevehicle;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtboxRegplate;
        private TextBox txtboxVehiclecolour;
        private TextBox txtboxVehiclemodel;
        private TextBox txtboxVehiclemake;
        private Label label1;
        private Panel panel1;
    }
}