namespace GarageManagementApp.Vehicles
{
    partial class frmCreateVehicle
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
            panel1 = new Panel();
            txtboxRegplate = new TextBox();
            txtboxVehiclecolour = new TextBox();
            txtboxVehiclemodel = new TextBox();
            txtboxVehiclemake = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCreatevehicle = new Button();
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
            label5.Size = new Size(204, 21);
            label5.TabIndex = 0;
            label5.Text = "Enter vehicle details below";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 43);
            panel1.TabIndex = 10;
            // 
            // txtboxRegplate
            // 
            txtboxRegplate.Location = new Point(159, 151);
            txtboxRegplate.Name = "txtboxRegplate";
            txtboxRegplate.Size = new Size(230, 23);
            txtboxRegplate.TabIndex = 16;
            // 
            // txtboxVehiclecolour
            // 
            txtboxVehiclecolour.Location = new Point(159, 180);
            txtboxVehiclecolour.Name = "txtboxVehiclecolour";
            txtboxVehiclecolour.Size = new Size(230, 23);
            txtboxVehiclecolour.TabIndex = 18;
            // 
            // txtboxVehiclemodel
            // 
            txtboxVehiclemodel.Location = new Point(159, 122);
            txtboxVehiclemodel.Name = "txtboxVehiclemodel";
            txtboxVehiclemodel.Size = new Size(230, 23);
            txtboxVehiclemodel.TabIndex = 14;
            // 
            // txtboxVehiclemake
            // 
            txtboxVehiclemake.Location = new Point(159, 93);
            txtboxVehiclemake.Name = "txtboxVehiclemake";
            txtboxVehiclemake.Size = new Size(230, 23);
            txtboxVehiclemake.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 301);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 227);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 126);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 96);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 11;
            label1.Text = "Vehicle Make";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 125);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 19;
            label6.Text = "Vehicle Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 154);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 20;
            label7.Text = "Registration Plate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 183);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 21;
            label8.Text = "Vehicle Colour";
            // 
            // btnCreatevehicle
            // 
            btnCreatevehicle.BackColor = Color.LightBlue;
            btnCreatevehicle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatevehicle.Location = new Point(159, 259);
            btnCreatevehicle.Name = "btnCreatevehicle";
            btnCreatevehicle.Size = new Size(113, 48);
            btnCreatevehicle.TabIndex = 22;
            btnCreatevehicle.Text = "Submit";
            btnCreatevehicle.UseVisualStyleBackColor = false;
            btnCreatevehicle.Click += btnCreatevehicle_Click;
            // 
            // frmCreateVehicle
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateVehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private TextBox txtboxRegplate;
        private TextBox txtboxVehiclecolour;
        private TextBox txtboxVehiclemodel;
        private TextBox txtboxVehiclemake;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCreatevehicle;
    }
}