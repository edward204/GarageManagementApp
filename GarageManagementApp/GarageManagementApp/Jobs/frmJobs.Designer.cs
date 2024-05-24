namespace GarageManagementApp
{
    partial class frmJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobs));
            label1 = new Label();
            btnCreateJob = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgJobs = new DataGridView();
            btnRefresh = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgJobs).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Job List";
            // 
            // btnCreateJob
            // 
            btnCreateJob.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateJob.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateJob.ForeColor = Color.White;
            btnCreateJob.Location = new Point(1072, 3);
            btnCreateJob.Name = "btnCreateJob";
            btnCreateJob.Size = new Size(155, 47);
            btnCreateJob.TabIndex = 0;
            btnCreateJob.Text = "CREATE";
            btnCreateJob.UseVisualStyleBackColor = false;
            btnCreateJob.Click += btnCreateJob_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.04868F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.2927551F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8558235F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.297966F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2523851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2523851F));
            tableLayoutPanel1.Controls.Add(btnCreateJob, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1235, 53);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgJobs
            // 
            dgJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJobs.Location = new Point(38, 192);
            dgJobs.Name = "dgJobs";
            dgJobs.RowTemplate.Height = 25;
            dgJobs.Size = new Size(240, 150);
            dgJobs.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(199, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(41, 39);
            btnRefresh.TabIndex = 9;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(38, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 39);
            panel1.TabIndex = 10;
            // 
            // frmJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 730);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dgJobs);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJobs";
            Load += frmJobs_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgJobs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCreateJob;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgJobs;
        private Button btnRefresh;
        private Panel panel1;
    }
}