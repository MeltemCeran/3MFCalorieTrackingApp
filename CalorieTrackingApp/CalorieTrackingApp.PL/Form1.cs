using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Context;
using System.Xml.Linq;

namespace CalorieTrackingApp.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 360;
            this.Height = 490;
        }

        private void btnNextToSignIn_Click(object sender, EventArgs e)
        {
            gBoxStartScreen.Visible = false;
            this.Width = 330;
            this.Height = 400;
            gBoxLogin.Visible = true;

            gBoxLogin.Location = gBoxStartScreen.Location;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            gBoxLogin.Visible = false;
            this.Width = 330;
            this.Height = 400;
            gBoxSignIn.Visible = true;

            gBoxSignIn.Location = gBoxLogin.Location;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();

        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            using (UserManager userManager = new UserManager())
            {

                string name = txtUserName.Text;
                string surname = txtUserSurname.Text;
                string email = txtUserEmail.Text;
                string username = txtUserEmail.Text;
                string password = txtUserPasswordAgain.Text;
                string passwordAgain = txtUserPassword.Text;

                bool isValid = true;

                if (isValid)
                {
                    UserModel userModel = new UserModel();
                    userModel.Name = name;
                    userModel.Surname = surname;
                    userModel.Email = email;
                    userModel.Password = password;
                    userModel.UserName = email;
                    userModel.CreatedDate = DateTime.Now;

                    userManager.Create(userModel);
                    userManager.Save();

                    MessageBox.Show("Kayýt Yapýlmýþtýr");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hata var.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (UserManager usermanager = new UserManager())
            {
                var userModels = usermanager.GetAll().ToList();

                foreach (var userModel in userModels)
                {
                    if (userModel.Email == email && userModel.Password == password)
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.ShowDialog();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
