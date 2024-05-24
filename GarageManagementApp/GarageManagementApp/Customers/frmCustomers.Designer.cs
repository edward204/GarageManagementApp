namespace GarageManagementApp
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            btnCreateCustomer = new Button();
            dgCustomers = new DataGridView();
            txtFilter = new TextBox();
            btnApplyFilter = new Button();
            btnRefresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEditCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateCustomer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCustomer.ForeColor = Color.White;
            btnCreateCustomer.Location = new Point(1072, 3);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(155, 47);
            btnCreateCustomer.TabIndex = 0;
            btnCreateCustomer.Text = "CREATE";
            btnCreateCustomer.UseVisualStyleBackColor = false;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // dgCustomers
            // 
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomers.Location = new Point(12, 129);
            dgCustomers.Name = "dgCustomers";
            dgCustomers.RowTemplate.Height = 25;
            dgCustomers.Size = new Size(740, 150);
            dgCustomers.TabIndex = 1;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.Location = new Point(12, 72);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(574, 39);
            txtFilter.TabIndex = 2;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplyFilter.Location = new Point(639, 72);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(113, 39);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "Filter Results";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(592, 72);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(41, 39);
            btnRefresh.TabIndex = 4;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
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
            tableLayoutPanel1.Controls.Add(btnCreateCustomer, 5, 0);
            tableLayoutPanel1.Controls.Add(btnEditCustomer, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1235, 53);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.BackColor = Color.FromArgb(64, 64, 64);
            btnEditCustomer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCustomer.ForeColor = Color.White;
            btnEditCustomer.Location = new Point(909, 3);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(155, 47);
            btnEditCustomer.TabIndex = 1;
            btnEditCustomer.Text = "UPDATE";
            btnEditCustomer.UseVisualStyleBackColor = false;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 730);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnApplyFilter);
            Controls.Add(txtFilter);
            Controls.Add(dgCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateCustomer;
        private DataGridView dgCustomers;
        private TextBox txtFilter;
        private Button btnApplyFilter;
        private Button btnRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEditCustomer;
    }
}