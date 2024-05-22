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
                        Form frmMainMenu = new frmMainMenu();
                        frmMainMenu.Show();

                        // Clear the text boxes
                        txtboxUsername.Clear();
                        txtboxPassword.Clear();

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

        private void btnHidepassword_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.PasswordChar == '\0')
            {
                btnShowpassword.BringToFront();
                txtboxPassword.PasswordChar = '*';
            }
        }

        private void btnShowpassword_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.PasswordChar == '*')
            {
                btnHidepassword.BringToFront();
                txtboxPassword.PasswordChar = '\0';
            }
        }
    }
}