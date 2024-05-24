using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagementApp.Vehicles
{
    public partial class frmEditVehicle : Form
    {
        public frmEditVehicle()
        {
            InitializeComponent();
        }

        private void frmEditVehicle_Load(object sender, EventArgs e)
        {
            // create an instance of the data context which will allow me to connect 
            DataContext context = new DataContext();

            // create a LINQ query which gets the details on the customer ID entered in the txtbox
            var vehicleResult = (context.Vehicle.Where(vehic => vehic.Vehicle_id == 1).FirstOrDefault());

            // populate the textbox with the vehicle make
            txtboxVehiclemake.Text = vehicleResult.Vehicle_make;
            txtboxVehiclemodel.Text = vehicleResult.Vehicle_model;
            txtboxRegplate.Text = vehicleResult.Reg_plate;
            txtboxVehiclecolour.Text = vehicleResult.Vehicle_colour;
        }

        private void btnCreatevehicle_Click(object sender, EventArgs e)
        {
            // update in CRUD
            DataContext context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // update an existing record where ID is 1
                var vehicleResult = context.Vehicle.First(vehic => vehic.Vehicle_id == 1);
                vehicleResult.Vehicle_make = txtboxVehiclemake.Text;
                vehicleResult.Vehicle_model = txtboxVehiclemodel.Text;
                vehicleResult.Reg_plate = txtboxRegplate.Text;
                vehicleResult.Vehicle_colour = txtboxVehiclecolour.Text;
                context.SaveChanges();

                MessageBox.Show("Changes Saved!");
            }
        }
    }
}
