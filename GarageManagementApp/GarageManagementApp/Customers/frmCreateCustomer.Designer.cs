namespace GarageManagementApp.Customers
{
    partial class frmCreateCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtboxFirstname = new TextBox();
            txtboxLastname = new TextBox();
            txtboxCity = new TextBox();
            txtboxAddress = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            txtboxPhone = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtboxEmail = new TextBox();
            btnCreatecustomer = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 70);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Address *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 140);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "City *";
            // 
            // txtboxFirstname
            // 
            txtboxFirstname.Location = new Point(51, 88);
            txtboxFirstname.Name = "txtboxFirstname";
            txtboxFirstname.Size = new Size(165, 23);
            txtboxFirstname.TabIndex = 1;
            // 
            // txtboxLastname
            // 
            txtboxLastname.Location = new Point(240, 88);
            txtboxLastname.Name = "txtboxLastname";
            txtboxLastname.Size = new Size(165, 23);
            txtboxLastname.TabIndex = 2;
            // 
            // txtboxCity
            // 
            txtboxCity.Location = new Point(240, 158);
            txtboxCity.Name = "txtboxCity";
            txtboxCity.Size = new Size(165, 23);
            txtboxCity.TabIndex = 4;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(51, 158);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(165, 23);
            txtboxAddress.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 43);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(5, 9);
            label5.Name = "label5";
            label5.Size = new Size(222, 21);
            label5.TabIndex = 0;
            label5.Text = "Enter customer details below";
            // 
            // txtboxPhone
            // 
            txtboxPhone.Location = new Point(51, 235);
            txtboxPhone.Name = "txtboxPhone";
            txtboxPhone.Size = new Size(165, 23);
            txtboxPhone.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 217);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Phone Number *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 217);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "Email *";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(240, 235);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(165, 23);
            txtboxEmail.TabIndex = 6;
            // 
            // btnCreatecustomer
            // 
            btnCreatecustomer.BackColor = Color.LightBlue;
            btnCreatecustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatecustomer.Location = new Point(51, 289);
            btnCreatecustomer.Name = "btnCreatecustomer";
            btnCreatecustomer.Size = new Size(113, 48);
            btnCreatecustomer.TabIndex = 7;
            btnCreatecustomer.Text = "Submit";
            btnCreatecustomer.UseVisualStyleBackColor = false;
            btnCreatecustomer.Click += btnCreatecustomer_Click;
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 349);
            Controls.Add(btnCreatecustomer);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxPhone);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxCity);
            Controls.Add(txtboxLastname);
            Controls.Add(txtboxFirstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += frmCreateCustomer_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxFirstname;
        private TextBox txtboxLastname;
        private TextBox txtboxCity;
        private TextBox txtboxAddress;
        private Panel panel1;
        private Label label5;
        private TextBox txtboxPhone;
        private Label label6;
        private Label label7;
        private TextBox txtboxEmail;
        private Button btnCreatecustomer;
    }
}