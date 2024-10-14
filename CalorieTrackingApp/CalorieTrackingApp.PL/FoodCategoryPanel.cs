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
        FoodCategoryModel selectedFoodCategory;

        public FoodCategoryPanel()
        {
            InitializeComponent();
        }

        private void FoodCategoryPanel_Load(object sender, EventArgs e)
        {
            GetFoodCategoryList();
        }

        public void FormClear()
        {
            txtFoodCategoryName.Clear();
        }

        public void GetFoodCategoryList()
        {
            using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
            {
                dgvFoodCategory.DataSource = foodCategoryManager.GetAll();
            }
        }

        private void dgvFoodCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFoodCategory = (FoodCategoryModel)dgvFoodCategory.SelectedRows[0].DataBoundItem;
            txtFoodCategoryName.Text = selectedFoodCategory.FoodCategoryName;
        }

        private void btnFoodCategoryAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodCategoryName.Text))
            {
                MessageBox.Show("Lütfen 'Yemek Kategori Adı' kısmınızı doldurunuz.");
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
                        lblFoodCategory.Text = "Yemek Kategorisi Eklendi.";
                        lblFoodCategory.BackColor = Color.Green;
                        lblFoodCategory.ForeColor = Color.White;
                        lblFoodCategory.Visible = true;
                        GetFoodCategoryList();
                    }
                    else
                    {
                        lblFoodCategory.Text = "Yemek Kategorisi Eklenemedi.";
                        lblFoodCategory.BackColor = Color.Red;
                        lblFoodCategory.ForeColor= Color.White;
                        lblFoodCategory.Visible = true;
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
                    lblFoodCategory.Text = "Yemek Kategorisi Silindi.";
                    lblFoodCategory.BackColor = Color.Green;
                    lblFoodCategory.ForeColor = Color.White;
                    selectedFoodCategory = null;
                    lblFoodCategory.Visible = true;

                    
                }
                else
                {
                    lblFoodCategory.Text = "Yemek Kategorisi Silinemedi.";
                    lblFoodCategory.BackColor = Color.Red;
                    lblFoodCategory.ForeColor = Color.White;
                    lblFoodCategory.Visible = true;
                }

                FormClear();

            }
        }

        private void btnFoodCategoryUpdate_Click(object sender, EventArgs e)
        {
            using (FoodCategoryManager foodCategoryManager = new FoodCategoryManager())
            {
                // Kullanıcıdan alınan yeni kategori adı
                string newFoodCategoryName = txtFoodCategoryName.Text;

                if (dgvFoodCategory.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newFoodCategoryName))
                {
                    // Seçilen kategori üzerinde güncellemeler yapılıyor
                    selectedFoodCategory.FoodCategoryName = newFoodCategoryName; // Var olan kategori nesnesini güncelle

                    // Güncelleme işlemini gerçekleştir
                    foodCategoryManager.Update(selectedFoodCategory);

                    if (foodCategoryManager.Save() > 0)
                    {
                        GetFoodCategoryList(); // Listeyi yenile
                        lblFoodCategory.Text = "Yemek Kategorisi Güncellendi";
                        lblFoodCategory.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                        lblFoodCategory.ForeColor = Color.White;
                    }
                    else
                    {
                        lblFoodCategory.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblFoodCategory.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                        lblFoodCategory.ForeColor = Color.White;
                    }
                }
                else
                {
                    lblFoodCategory.Text = "Güncellemek için bir Yemek Kategorisi seçin.";
                    lblFoodCategory.BackColor = Color.Red;
                    lblFoodCategory.ForeColor = Color.White;
                }

                lblFoodCategory.Visible = true;
                FormClear(); // Formu temizle
            }
        }
    }
}
