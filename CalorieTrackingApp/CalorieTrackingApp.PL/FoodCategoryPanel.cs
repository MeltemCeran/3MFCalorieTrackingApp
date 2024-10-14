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
    public partial class FoodCategoryPanel : Form
    {
        FoodCategoryManager beverageCategoryManager = new FoodCategoryManager();
        FoodCategoryModel selectedFoodCategory;
        public FoodCategoryPanel()
        {
            InitializeComponent();
        }

        private void FoodCategoryPanel_Load(object sender, EventArgs e)
        {
            GetFoodCategoryList();
        }

        private void GetFoodCategoryList()
        {
            using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
            {
                dgvFoodCategory.DataSource = foodCategoryManager.GetAll();
            }


        }

        private void FormClear()
        {
            txtFoodCategoryName.Clear();
        }

        private void dgvFoodCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFoodCategory = (FoodCategoryModel)dgvFoodCategory.SelectedRows[0].DataBoundItem;
            lblDurum.Text = selectedFoodCategory.FoodCategoryName;
            txtFoodCategoryName.Text = selectedFoodCategory.FoodCategoryName;
        }
        private void btnFoodCategoryAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodCategoryName.Text))
            {
                MessageBox.Show("Lütfen 'Yemek Kategorisi Adı' kısmınızı doldurunuz.");
                return;
            }
            else
            {
                using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
                {
                    FoodCategoryModel foodCategoryModel = new FoodCategoryModel();
                    foodCategoryModel.FoodCategoryName = txtFoodCategoryName.Text;
                    foodCategoryModel.CreatedDate = DateTime.Now;
                    foodCategoryModel.DataStatus =DataStatus.Inserted;
                    foodCategoryManager.Create(foodCategoryModel);

                    if (foodCategoryManager.Save() > 0)
                    {
                        lblDurum.Text = "Yemek Kategorisi Eklendi.";
                        lblDurum.Visible = true;
                        GetFoodCategoryList();
                    }
                    else
                    {
                        lblDurum.Text = "Yemek Kategorisi Oluşturulamadı!!";
                        lblDurum.BackColor = Color.Red;
                        lblDurum.Visible = true;
                    }
                    FormClear();
                }
            }
        }

        private void btnFoodCategoryDelete_Click(object sender, EventArgs e)
        {
            using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
            {

                foodCategoryManager.Delete(selectedFoodCategory);

                if (foodCategoryManager.Save() > 0)
                {
                    GetFoodCategoryList();
                    lblDurum.Text = "İçecek Kategorisi Eklendi";
                    selectedFoodCategory = null;
                    lblDurum.Visible = true;

                    
                }
                else
                {
                    lblDurum.Text = "İçecek Kategorisi Olmadı:(!!";
                    lblDurum.BackColor = Color.Red;
                    lblDurum.Visible = true;
                }

                FormClear();

            }
        }

        private void btnFoodCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFoodCategory.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(txtFoodCategoryName.Text))
            {
                dgvFoodCategory.SelectedRows[0].Cells[0].Value = txtFoodCategoryName.Text;  // Seçilen satırın verisini günceller
                lblDurum.Text = "Durum: Öğün Güncellendi";
                txtFoodCategoryName.Clear();
            }
            else
            {
                lblDurum.Text = "Durum: Güncellemek için bir öğün seçin ve yeni öğün adı girin.";
            }
        }
    }
}
