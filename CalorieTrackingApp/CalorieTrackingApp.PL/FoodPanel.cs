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
            txtFoodPortionId.Clear();
            txtFoodCategoryId.Clear();
        }

        public void GetFoodList()
        {
            using (FoodManager foodManager = new FoodManager())
            {
                dgvFood.DataSource = foodManager.GetAll();
            }
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFood = (FoodModel)dgvFood.SelectedRows[0].DataBoundItem;
            txtFoodName.Text = selectedFood.FoodName;
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))           //kalori porsiyon ve id kontrolü yaz!!!
            {
                MessageBox.Show("Lütfen 'Yemek Adı' kısmınızı doldurunuz.");
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
                        lblFood.Text = "Yemek Eklendi.";
                        lblFood.BackColor = Color.Green;
                        lblFood.ForeColor = Color.White;
                        lblFood.Visible = true;
                        GetFoodList();
                    }
                    else
                    {
                        lblFood.Text = "Yemek Eklenemedi.";
                        lblFood.BackColor = Color.Red;
                        lblFood.ForeColor= Color.White;
                        lblFood.Visible = true;
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
                    lblFood.Text = "Yemek Silindi.";
                    lblFood.BackColor = Color.Green;
                    lblFood.ForeColor = Color.White;
                    selectedFood = null;
                    lblFood.Visible = true;

                    GetFoodList();
                }
                else
                {
                    lblFood.Text = "Yemek Silinemedi.";
                    lblFood.BackColor = Color.Red;
                    lblFood.ForeColor = Color.White;
                    lblFood.Visible = true;
                }

                FormClear();

            }
        }
        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            using (FoodManager foodManager = new FoodManager())
            {
                string newFoodName = txtFoodName.Text;

                if (dgvFood.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newFoodName))
                {
                    selectedFood.FoodName = newFoodName;

                    foodManager.Update(selectedFood);

                    if (foodManager.Save() > 0)
                    {
                        GetFoodList(); // Listeyi yenile
                        lblFood.Text = "İçecek Kategorisi Güncellendi";
                        lblFood.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                        lblFood.ForeColor = Color.White;
                    }
                    else
                    {
                        lblFood.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblFood.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                        lblFood.ForeColor = Color.White;
                    }
                }
                else
                {
                    lblFood.Text = "Güncellemek için bir İçecek Kategorisi seçiniz.";
                    lblFood.BackColor = Color.Red;
                    lblFood.ForeColor = Color.White;
                }

                lblFood.Visible = true;
                FormClear(); // Formu temizle
            }
        }

        private void btnFoodCategoryAdd_Click(object sender, EventArgs e)
        {
            FoodCategoryPanel foodCategoryPanel = new FoodCategoryPanel();
            foodCategoryPanel.ShowDialog();
        }

        
    }
}
