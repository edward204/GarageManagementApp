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
    }
}