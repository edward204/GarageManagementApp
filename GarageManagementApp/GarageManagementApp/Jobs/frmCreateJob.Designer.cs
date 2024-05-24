namespace GarageManagementApp.Jobs
{
    partial class frmCreateJob
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
            txtboxJobtype = new TextBox();
            lblJobType = new Label();
            btnCreatejob = new Button();
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
            label5.Size = new Size(177, 21);
            label5.TabIndex = 0;
            label5.Text = "Enter job details below";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 43);
            panel1.TabIndex = 11;
            // 
            // txtboxJobtype
            // 
            txtboxJobtype.Location = new Point(132, 83);
            txtboxJobtype.Name = "txtboxJobtype";
            txtboxJobtype.Size = new Size(230, 23);
            txtboxJobtype.TabIndex = 14;
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobType.Location = new Point(59, 83);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(67, 20);
            lblJobType.TabIndex = 13;
            lblJobType.Text = "Job Type";
            // 
            // btnCreatejob
            // 
            btnCreatejob.BackColor = Color.LightBlue;
            btnCreatejob.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatejob.Location = new Point(59, 176);
            btnCreatejob.Name = "btnCreatejob";
            btnCreatejob.Size = new Size(113, 48);
            btnCreatejob.TabIndex = 23;
            btnCreatejob.Text = "Submit";
            btnCreatejob.UseVisualStyleBackColor = false;
            btnCreatejob.Click += btnCreatejob_Click;
            // 
            // frmCreateJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 245);
            Controls.Add(btnCreatejob);
            Controls.Add(txtboxJobtype);
            Controls.Add(lblJobType);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateJob";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmCreateJob_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private TextBox txtboxJobtype;
        private Label lblJobType;
        private Button btnCreatejob;
    }
}