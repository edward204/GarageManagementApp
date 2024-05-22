using GarageManagementApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagementApp.Customers
{
    public partial class frmCreateCustomer : Form
    {
        private frmCustomers mainForm = null;
        public frmCreateCustomer(frmCustomers callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnCreatecustomer_Click(object sender, EventArgs e)
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                //setup the new object read for insertion
                var Customer = new Customer();
                Customer.Customer_firstname = txtboxFirstname.Text;
                Customer.Customer_surname = txtboxLastname.Text;
                Customer.Customer_address = txtboxAddress.Text;
                Customer.Customer_city = txtboxCity.Text;
                Customer.Customer_phone = txtboxPhone.Text;
                Customer.Customer_email = txtboxEmail.Text;

                // once the object is built insert it into the database
                context.Customer.Add(Customer);
                context.SaveChanges();

                // display a success message
                MessageBox.Show("Customer added successfully!");

                // clear the text boxes
                txtboxFirstname.Clear();
                txtboxLastname.Clear();
                txtboxAddress.Clear();
                txtboxCity.Clear();
                txtboxPhone.Clear();
                txtboxEmail.Clear();
            }
        }

        private void frmCreateCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.RefreshGrid();
        }
    }
}
