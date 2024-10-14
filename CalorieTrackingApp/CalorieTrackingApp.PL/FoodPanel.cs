using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
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
    public partial class FoodPanel : Form
    {
        FoodModel selectedFood;

        public FoodPanel()
        {
            InitializeComponent();
        }


        private void FoodPanel_Load(object sender, EventArgs e)
        {
            GetFoodList();
        }

        public void FormClear()
        {
            txtFoodName.Clear();
            txtFoodCalorie.Clear();
            txtFoodPortion.Clear();
            txtCategoryId.Clear();
        }

        public void GetFoodList()
        {
            using (FoodManager foodManager = new FoodManager())
            {
                dgvFood.DataSource = foodManager.GetAll();
            }
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Lütfen 'Öğün Adı' kısmınızı doldurunuz.");
                return;
            }
            else
            {
                using (FoodManager foodManager = new FoodManager())
                {
                    FoodModel foodModel = new FoodModel();
                    foodModel.FoodName = txtFoodName.Text;
                    foodModel.CreatedDate = DateTime.Now;
                    foodModel.DataStatus = DataStatus.Inserted;
                    foodManager.Create(foodModel);

                    if (foodManager.Save() > 0)
                    {
                        lblSelectedFood.Text = "Öğün Kategorisi Eklendi.";
                        lblSelectedFood.Visible = true;
                        GetFoodList();
                    }
                    else
                    {
                        lblSelectedFood.Text = "Öğün Kategorisi Oluşturulamadı!!";
                        lblSelectedFood.BackColor = Color.Red;
                        lblSelectedFood.Visible = true;
                    }
                    FormClear();
                }
            }
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            using (FoodManager foodManager = new FoodManager())
            {

                foodManager.Delete(selectedFood);

                if (foodManager.Save() > 0)
                {
                    lblSelectedFood.Text = "İçecek Kategorisi Eklendi";
                    selectedFood = null;
                    lblSelectedFood.Visible = true;

                    GetFoodList();
                }
                else
                {
                    lblSelectedFood.Text = "İçecek Kategorisi Olmadı:(!!";
                    lblSelectedFood.BackColor = Color.Red;
                    lblSelectedFood.Visible = true;
                }

                FormClear();

            }
        }
        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodCategoryAdd_Click(object sender, EventArgs e)
        {
            FoodCategoryPanel foodCategoryPanel = new FoodCategoryPanel();
            foodCategoryPanel.ShowDialog();
        }
    }
}
