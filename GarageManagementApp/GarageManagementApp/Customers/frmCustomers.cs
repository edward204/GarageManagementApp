using GarageManagementApp.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagementApp
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        public void RefreshGrid()
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // get the first 100 results
                var result = context.Customer.Take(100);
                var listResults = result.ToList();

                // set the datasource of the control
                dgCustomers.DataSource = listResults;
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            Form frmCreateCustomer = new frmCreateCustomer(this);
            frmCreateCustomer.Show(this);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            // create an instane of the DataContext
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                //query for results which match the entry in the textbox called txtFilter
                var qryFilterFirstname = from cstomer in context.Customer
                                         where cstomer.Customer_firstname == txtFilter.Text
                                         select cstomer;
                var fltrFirstnameResult = qryFilterFirstname.Take(100);
                var listResults = fltrFirstnameResult.ToList();

                // set the datasource of the control
                dgCustomers.DataSource = listResults;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validation - allow only letters to be entered to protect against SQL injection
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Form frmEditCustomer = new frmEditCustomer();
            frmEditCustomer.Show();
        }
    }
}
