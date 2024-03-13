using GarageManagementApp.Data;

namespace GarageManagementApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check that we have a username and password
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                // alert the user providing feedback on the issue
                MessageBox.Show("Please enter a Username & Password!");

                // return here, don't continue processing any more code in this code block
                return;
            }

            // get the database context
            var context = new DataContext();

            // if the connection to the database is successful
            if (context.Database.CanConnect()) 
            {
                // grab only the record which matches the username
                Login loginObj =
                     context.Login
                     .Where(x => x.Login_username == txtboxUsername.Text)
                     .FirstOrDefault();

                // check the outcome
                if (loginObj != null)
                {
                    // confirm the password is a match
                    if (BCrypt.Net.BCrypt.Verify(txtboxPassword.Text, loginObj.Login_password))
                    {
                        // login successful
                        MessageBox.Show("Login Successful");

                        // go to main menu
                        

                    }
                    else
                    {
                        // we hit this point if the password is incorrect
                        IncorrectDetails();
                    }

                    return;
                }

                // we hit this point if the database doesn't return a valid username
                IncorrectDetails();
            }
        }

        private void IncorrectDetails()
        {
            // clear the inputs so that they can try again?

            // alert the user that the details they provided are incorrect
            MessageBox.Show("Invalid Credentials Supplied!");
        }
    }
}