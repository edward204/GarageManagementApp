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

namespace GarageManagementApp
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnCreateuser_Click(object sender, EventArgs e)
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
                if(txtboxCreatepassword.Text == txtboxConfirmpassword.Text && txtboxConfirmpassword.Text != "")
                {
                    // setup the new object read for insertion
                    var Login = new Login();
                    Login.Login_username = txtboxCreateusername.Text;
                    Login.Login_password = BCrypt.Net.BCrypt.HashPassword(txtboxCreatepassword.Text);
                    Login.Login_firstname = txtboxFirstname.Text;
                    Login.Login_surname = txtboxSurname.Text;
                    Login.Login_job_role = txtboxJobRole.Text;

                    // once the object is built insert it into the database
                    context.Login.Add(Login);
                    context.SaveChanges();

                    // display a success message
                    MessageBox.Show("User added successfully!");

                    // clear the textboxes so that they're ready to use again
                    txtboxCreateusername.Clear();
                    txtboxCreatepassword.Clear();
                    txtboxConfirmpassword.Clear();
                    txtboxFirstname.Clear();
                    txtboxSurname.Clear();
                    txtboxJobRole.Clear();
                }
                else
                {
                    MessageBox.Show("Your passwords don't match!");
                }
        }
    }
}
