namespace GarageManagementApp
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            btnCreateVehicle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEditVehicle = new Button();
            btnRefresh = new Button();
            btnApplyFilter = new Button();
            txtFilter = new TextBox();
            dgVehicles = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicles).BeginInit();
            SuspendLayout();
            // 
            // btnCreateVehicle
            // 
            btnCreateVehicle.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateVehicle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateVehicle.ForeColor = Color.White;
            btnCreateVehicle.Location = new Point(1072, 3);
            btnCreateVehicle.Name = "btnCreateVehicle";
            btnCreateVehicle.Size = new Size(155, 47);
            btnCreateVehicle.TabIndex = 0;
            btnCreateVehicle.Text = "CREATE";
            btnCreateVehicle.UseVisualStyleBackColor = false;
            btnCreateVehicle.Click += btnCreateVehicle_Click;
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
            tableLayoutPanel1.Controls.Add(btnEditVehicle, 4, 0);
            tableLayoutPanel1.Controls.Add(btnCreateVehicle, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1235, 53);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnEditVehicle
            // 
            btnEditVehicle.BackColor = Color.FromArgb(64, 64, 64);
            btnEditVehicle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditVehicle.ForeColor = Color.White;
            btnEditVehicle.Location = new Point(909, 3);
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.Size = new Size(155, 47);
            btnEditVehicle.TabIndex = 9;
            btnEditVehicle.Text = "UPDATE";
            btnEditVehicle.UseVisualStyleBackColor = false;
            btnEditVehicle.Click += btnEditVehicle_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(592, 72);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(41, 39);
            btnRefresh.TabIndex = 8;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplyFilter.Location = new Point(639, 72);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(113, 39);
            btnApplyFilter.TabIndex = 7;
            btnApplyFilter.Text = "Filter Results";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.Location = new Point(12, 72);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(574, 39);
            txtFilter.TabIndex = 6;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // dgVehicles
            // 
            dgVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehicles.Location = new Point(12, 129);
            dgVehicles.Name = "dgVehicles";
            dgVehicles.RowTemplate.Height = 25;
            dgVehicles.Size = new Size(740, 150);
            dgVehicles.TabIndex = 5;
            // 
            // frmVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1235, 730);
            ControlBox = false;
            Controls.Add(btnRefresh);
            Controls.Add(btnApplyFilter);
            Controls.Add(txtFilter);
            Controls.Add(dgVehicles);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVehicles";
            Load += frmVehicles_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateVehicle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRefresh;
        private Button btnApplyFilter;
        private TextBox txtFilter;
        private DataGridView dgVehicles;
        private Button btnEditVehicle;
    }
}