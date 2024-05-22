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

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            Form frmCreateVehicle = new frmCreateVehicle();
            frmCreateVehicle.Show();

        }
    }
}
