using GarageManagementApp.Jobs;
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
    public partial class frmJobs : Form
    {
        public frmJobs()
        {
            InitializeComponent();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            Form frmCreateJob = new frmCreateJob(this);
            frmCreateJob.Show(this);
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {
                // get the first 100 results
                var result = context.Job.Take(100);
                var listResults = result.ToList();

                // set the datasource of the control
                dgJobs.DataSource = listResults;

            }
        }
    }
}
