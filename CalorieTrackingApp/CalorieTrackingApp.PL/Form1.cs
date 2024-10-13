using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.DAL.Context;

namespace CalorieTrackingApp.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNextToSignIn_Click(object sender, EventArgs e)
        {
            gBoxStartScreen.Visible = false;
            gBoxLogin.Visible = true;

            gBoxLogin.Location = gBoxStartScreen.Location;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            gBoxLogin.Visible = false;
            gBoxSignIn.Visible = true;

            gBoxSignIn.Location = gBoxLogin.Location;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
           
        }
    }
}
