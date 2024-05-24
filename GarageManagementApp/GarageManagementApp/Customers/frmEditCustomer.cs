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
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            // create an instance of the data context which will allow me to connect
            DataContext context = new DataContext();

            // create a LINQ query which gets the details on the customer ID entered in the txtbox
            var customerResult = (context.Customer.Where(cust => cust.Customer_Id == 1).FirstOrDefault());

            // populate the textbox with the first name
            txtboxFirstname.Text = customerResult.Customer_firstname;
            txtboxLastname.Text = customerResult.Customer_surname;
            txtboxAddress.Text = customerResult.Customer_address;
            txtboxCity.Text = customerResult.Customer_city;
            txtboxPhone.Text = customerResult.Customer_phone;
            txtboxEmail.Text = customerResult.Customer_email;
        }

        private void btnEditcustomer_Click(object sender, EventArgs e)
        {
            // update in CRUD
            DataContext context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // update an existing record where ID is 1
                var customerResult = context.Customer.First(cust => cust.Customer_Id == 1);
                customerResult.Customer_firstname = txtboxFirstname.Text;
                customerResult.Customer_surname = txtboxLastname.Text;
                customerResult.Customer_address = txtboxAddress.Text;
                customerResult.Customer_city = txtboxCity.Text;
                customerResult.Customer_phone = txtboxPhone.Text;
                customerResult.Customer_email = txtboxEmail.Text;
                context.SaveChanges();

                MessageBox.Show("Changes Saved!");
            }
        }
    }
}
