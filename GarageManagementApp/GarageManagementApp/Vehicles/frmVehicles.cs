using GarageManagementApp.Vehicles;
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
    public partial class frmVehicles : Form
    {
        public frmVehicles()
        {
            InitializeComponent();
        }

        public void RefreshGrid()
        {
            var context = new DataContext();

            // if the connnection to the database is successfu;
            if (context.Database.CanConnect())
            {
                var result = context.Vehicle.Take(100);
                var listResults = result.ToList();

                // set the datasource of the control
                dgVehicles.DataSource = listResults;
            }
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            Form frmCreateVehicle = new frmCreateVehicle(this);
            frmCreateVehicle.Show(this);

        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            // create an instance of the DataContext
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // query for results which match the entry in the textbox called
                // txtFilter
                var qryFilterMake = from vhcle in context.Vehicle
                                    where vhcle.Vehicle_make == txtFilter.Text
                                    select vhcle;

                var result = qryFilterMake.Take(100);
                var listResults = result.ToList();

                // set the datasource of the control
                dgVehicles.DataSource = listResults;

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

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            Form frmEditVehicle = new frmEditVehicle();
            frmEditVehicle.Show(this);

        }
    }
}
