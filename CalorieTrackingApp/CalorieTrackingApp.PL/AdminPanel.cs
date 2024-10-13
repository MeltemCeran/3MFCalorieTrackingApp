using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.DAL.Enums;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            DailyUserRecords();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            MealPanel mealPanel = new MealPanel();
            mealPanel.ShowDialog();
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            FoodPanel foodPanel = new FoodPanel();
            foodPanel.ShowDialog();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            BeveragePanel beveragePanel = new BeveragePanel();
            beveragePanel.ShowDialog();
        }

        public void DailyUserRecords()
        {
            using (UserManager userManager = new UserManager())
            {
                dgvMealFoodBeverage.DataSource = userManager.GetAll();
            }
        }
    }
}
