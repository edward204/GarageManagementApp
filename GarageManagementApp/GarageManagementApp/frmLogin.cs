namespace GarageManagementApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lnklblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmRegistration = new frmRegistration();
            frmRegistration.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect())
            {

                // clear the list
                lstTest.Items.Clear();

                // get the first 100 results
                var result = context.Login.Take(100);

                // loop the results from the database
                foreach (var item in result)
                {
                    // add the firstname to the listbox
                    lstTest.Items.Add(item.Login_firstname);

                }

                // alert the user that all is well
                MessageBox.Show("Items Loaded Successfully!");

            }
        }
    }
}