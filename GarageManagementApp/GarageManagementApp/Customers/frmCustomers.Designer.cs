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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCreateCustomer = new Button();
            dgCustomers = new DataGridView();
            txtFilter = new TextBox();
            btnApplyFilter = new Button();
            btnRefresh = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.906292F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.044713F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.044713F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.55629F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.72399F));
            tableLayoutPanel1.Controls.Add(btnCreateCustomer, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1235, 72);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateCustomer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCustomer.ForeColor = Color.White;
            btnCreateCustomer.Location = new Point(454, 19);
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
            dgCustomers.Location = new Point(35, 207);
            dgCustomers.Name = "dgCustomers";
            dgCustomers.RowTemplate.Height = 25;
            dgCustomers.Size = new Size(740, 150);
            dgCustomers.TabIndex = 1;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(35, 166);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(574, 23);
            txtFilter.TabIndex = 2;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplyFilter.Location = new Point(662, 150);
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
            btnRefresh.Location = new Point(615, 150);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(41, 39);
            btnRefresh.TabIndex = 4;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 730);
            ControlBox = false;
            Controls.Add(btnRefresh);
            Controls.Add(btnApplyFilter);
            Controls.Add(txtFilter);
            Controls.Add(dgCustomers);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Load += frmCustomers_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCreateCustomer;
        private DataGridView dgCustomers;
        private TextBox txtFilter;
        private Button btnApplyFilter;
        private Button btnRefresh;
    }
}