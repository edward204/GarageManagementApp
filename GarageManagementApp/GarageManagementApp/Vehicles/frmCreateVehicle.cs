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

namespace GarageManagementApp.Vehicles
{
    public partial class frmCreateVehicle : Form
    {
        public frmCreateVehicle()
        {
            InitializeComponent();
        }

        private void btnCreatevehicle_Click(object sender, EventArgs e)
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // setup the new object read for insertion
                var Vehicle = new Vehicle();
                Vehicle.Vehicle_make = txtboxVehiclemake.Text;
                Vehicle.Vehicle_model = txtboxVehiclemodel.Text;
                Vehicle.Reg_plate = txtboxRegplate.Text;
                Vehicle.Vehicle_colour = txtboxVehiclecolour.Text;

                // once the object is built insert it into the database
                context.Vehicle.Add(Vehicle);
                context.SaveChanges();

                // display a success message
                MessageBox.Show("Vehicle added successfully!");

                // clear the text boxes
                txtboxVehiclemake.Clear();
                txtboxVehiclemodel.Clear();
                txtboxRegplate.Clear(); 
                txtboxVehiclecolour.Clear();
            }
        }
    }
}
