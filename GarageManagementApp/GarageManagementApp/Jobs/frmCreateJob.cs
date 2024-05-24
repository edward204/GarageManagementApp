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

namespace GarageManagementApp.Jobs
{
    public partial class frmCreateJob : Form
    {
        private frmJobs mainForm = null;
        public frmCreateJob(frmJobs callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnCreatejob_Click(object sender, EventArgs e)
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // setup the new object read for insertion
                var Job = new Job();
                Job.Job_type = txtboxJobtype.Text;

                // once the object is built insert it into the database
                context.Job.Add(Job);
                context.SaveChanges();

                // display a success message
                MessageBox.Show("Job added successfully");

                // clear the text boxes
                txtboxJobtype.Clear();
            }
        }

        private void frmCreateJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.RefreshGrid();
        }
    }
}
