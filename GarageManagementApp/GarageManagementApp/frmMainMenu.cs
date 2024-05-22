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
    public partial class frmMainMenu : Form
    {
        frmHome home1;
        frmCustomers customers;
        frmVehicles vehicles;
        frmJobs jobs;
        public frmMainMenu()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        // Go to Home when you click this button
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (home1 == null)
            {
                home1 = new frmHome();
                home1.FormClosed += Home1_FormClosed;
                home1.MdiParent = this;
                home1.Dock = DockStyle.Fill;
                home1.Show();
            }
            else
            {
                home1.Activate();
            }
        }

        private void Home1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            home1 = null;
        }

        // Go to Customers when you click this button
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (customers == null)
            {
                customers = new frmCustomers();
                customers.FormClosed += Customers_FormClosed;
                customers.MdiParent = this;
                customers.Dock = DockStyle.Fill;
                customers.Show();
            }
            else
            {
                customers.Activate();
            }
        }

        private void Customers_FormClosed(object? sender, FormClosedEventArgs e)
        {
            customers = null;
        }

        // go to Vehicles when you click this button
        private void btnVehicles_Click(object sender, EventArgs e)
        {
            if (vehicles == null)
            {
                vehicles = new frmVehicles();
                vehicles.FormClosed += Vehicles_FormClosed;
                vehicles.MdiParent = this;
                vehicles.Dock = DockStyle.Fill;
                vehicles.Show();
            }
            else
            {
                vehicles.Activate();
            }
        }

        private void Vehicles_FormClosed(object? sender, FormClosedEventArgs e)
        {
            vehicles = null;
        }

        // go to Jobs when you click this button
        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (jobs == null)
            {
                jobs = new frmJobs();
                jobs.FormClosed += Jobs_FormClosed;
                jobs.MdiParent = this;
                jobs.Dock = DockStyle.Fill;
                jobs.Show();
            }
            else
            {
                jobs.Activate();
            }
        }

        private void Jobs_FormClosed(object? sender, FormClosedEventArgs e)
        {
            jobs = null;
        }


        // Log out button 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
