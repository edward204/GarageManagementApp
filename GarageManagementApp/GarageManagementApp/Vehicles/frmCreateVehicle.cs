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
using System.Text.RegularExpressions;

namespace GarageManagementApp.Vehicles
{
    public partial class frmCreateVehicle : Form
    {
        private frmVehicles mainForm = null;
        public frmCreateVehicle(frmVehicles callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnCreatevehicle_Click(object sender, EventArgs e)
        {
            // regular expression to validate for proper UK number plates

            /*Regex regex = new Regex("^(?=.{ 1, 7 })(([a - zA - Z] ?){ 1,3} (\\d){ 1,3} ([a - zA - Z] ?){ 1,3})$");
            bool isValid = regex.IsMatch(txtboxRegplate.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter a valid reg plate");

                // return here, don't continue processing any more code in this code block
                return;
            } */

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

        private void frmCreateVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.RefreshGrid();
        }
    }
}
