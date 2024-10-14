using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.PL
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminName = txtAdminName.Text;
            string adminPassword = txtAdminPassword.Text;

            using (AdminManager adminManager = new AdminManager())
            {
                var adminModels = adminManager.GetAll().ToList();

                foreach (var adminModel in adminModels)
                {
                    if (adminModel.AdminName == adminName && adminModel.Password == adminPassword)
                    {
                       AdminPanel adminPanel = new AdminPanel();
                       adminPanel.ShowDialog();
                    }
                }
            }
        }
    }
}
