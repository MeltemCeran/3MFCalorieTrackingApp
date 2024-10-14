using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Manager.ReportManagers;
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
    public partial class UserPanel : Form
    {
        private int _userId;
        private DateTime secilenTarih;
        public UserPanel(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadFoodPortionData();
            LoadMealData();
            LoadFoodCategoryData();
            LoadFoodData();
            LoadBeverageCategoryData();
            LoadBeverageData();
            ReportManager reportManager = new ReportManager();
            dgvUserRecord.DataSource = reportManager.GetDailySummaryReports(_userId, secilenTarih);
        }
        public void LoadMealData()
        {
            List<string> meals;
            using (MealManager mealManager = new MealManager())
            {
                meals = mealManager.GetAll()
                                         .Select(m => m.MealName)
                                         .ToList();
                cmbMealAddUserPanel.DataSource = meals;
            }
        }
        public void LoadFoodCategoryData()
        {
            List<string> foodCategories;
            using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
            {
                foodCategories = foodCategoryManager.GetAll()
                                         .Select(fc =>
                                         fc.FoodCategoryName)
                                         .ToList();
                cmbFoodCategoryAddUserPanel.DataSource = foodCategories;
            }

        }
        public void LoadFoodData()
        {
            List<string> foods;
            using (FoodManager foodManager = new FoodManager())
            {
                foods = foodManager.GetAll()
                                         .Select(fc =>
                                         fc.FoodName)
                                         .ToList();
                cmbFoodAddUserPanel.DataSource = foods;
            }
        }
        public void LoadBeverageCategoryData()
        {
            List<string> beverageCategories;
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                beverageCategories = beverageCategoryManager.GetAll()
                                         .Select(bc =>
                                         bc.BeverageCategoryName)
                                         .ToList();
                cmbBeverageCategoryAddUserPanel.DataSource = beverageCategories;
            }

        }
        public void LoadBeverageData()
        {
            List<string> beverages;
            using (BeverageManager beverageManager = new BeverageManager())
            {
                beverages = beverageManager.GetAll()
                                         .Select(b =>
                                         b.BeverageName)
                                         .ToList();
                cmbBeverageAddUserPanel.DataSource = beverages;
            }
        }
        public void LoadFoodPortionData()
        {

            List<string> portions;
            using (PortionManager portionManager = new PortionManager())
            {
                portions = portionManager.GetAll()
                                         .Select(p => p.PortionType) // Sadece PortionType alınıyor
                                         .ToList();
                cmbFoodPortion.DataSource = portions;
                cmbBeveragePortion.DataSource = portions; // ComboBox'a data bağlanıyor
            }

            List<FoodModel> foods;
            using (FoodManager foodManager = new FoodManager())
            {
                foods = foodManager.GetAll().ToList();
            }

            using (PortionManager portionManager = new PortionManager())
            {
                foreach (FoodModel food in foods)
                {
                    int portionId = food.PortionId;
                    PortionModel portionModel = portionManager.GetById(portionId);
                    food.PortionName = portionModel.PortionType;
                }
            }

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var portionType = cmbFoodPortion.SelectedValue;
            var mealName = cmbMealAddUserPanel.SelectedValue;
            var foodCategory = cmbFoodCategoryUserPanel.SelectedValue;
            var food = cmbFoodAddUserPanel.SelectedValue;
            var beverageCategory = cmbBeverageCategoryAddUserPanel.SelectedValue;
            var beverage = cmbBeverageAddUserPanel.SelectedValue;

            using (DailyUserRecordManager dailyUserRecordManager = new DailyUserRecordManager())
            {
                DailyUserRecordModel dailyUserRecordModel = new DailyUserRecordModel();
            }
        }

        private void dtpUserPanel_ValueChanged(object sender, EventArgs e)
        {
            secilenTarih = dtpUserPanel.Value;
        }
    }
}
