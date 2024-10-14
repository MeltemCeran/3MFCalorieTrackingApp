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
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Lütfen 'Yemek Adı' kısmınızı doldurunuz.");
                return;
            }

            if (!decimal.TryParse(txtFoodCalorie.Text, out decimal foodCalorie))
            {
                MessageBox.Show("Lütfen geçerli bir 'Kalori' değeri giriniz.");
                return;
            }

            if (!int.TryParse(txtFoodPortionId.Text, out int portionId))
            {
                MessageBox.Show("Lütfen geçerli bir 'Porsiyon ID' değeri giriniz.");
                return;
            }

            if (!int.TryParse(txtFoodCategoryId.Text, out int categoryId))
            {
                MessageBox.Show("Lütfen geçerli bir 'Kategori ID' değeri giriniz.");
                return;
            }

            using (FoodManager foodManager = new FoodManager())
            {
                FoodModel foodModel = new FoodModel();
                foodModel.FoodName = txtFoodName.Text;
                foodModel.FoodCalorie = Convert.ToDecimal(txtFoodCalorie.Text);
                foodModel.PortionId = Convert.ToInt32(txtFoodPortionId.Text);
                foodModel.FoodCategoryId = Convert.ToInt32(txtFoodCategoryId.Text);
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
                    lblFood.ForeColor = Color.White;
                    lblFood.Visible = true;
                }
                FormClear();
            }

        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            using (FoodManager foodManager = new FoodManager())
            {
                if (selectedFood != null)
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
                }
                else
                {
                    lblFood.Text = "Silmek için bir Yemek seçiniz.";
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
                if (selectedFood != null)
                {
                    string newFoodName = txtFoodName.Text;
                    
                    if (string.IsNullOrWhiteSpace(newFoodName))
                    {
                        lblFood.Text = "Lütfen 'Yemek Adı' kısmını doldurunuz.";
                        lblFood.BackColor = Color.Red;
                        lblFood.ForeColor = Color.White;
                        lblFood.Visible = true;
                        return;
                    }

                    if (!decimal.TryParse(txtFoodCalorie.Text, out decimal newFoodCalorie))
                    {
                        lblFood.Text = "Lütfen geçerli bir 'Kalori' değeri giriniz.";
                        lblFood.BackColor = Color.Red;
                        lblFood.ForeColor = Color.White;
                        lblFood.Visible = true;
                        return;
                    }

                    if (!int.TryParse(txtFoodPortionId.Text, out int newFoodPortionId))
                    {
                        lblFood.Text = "Lütfen geçerli bir 'Porsiyon ID' değeri giriniz.";
                        lblFood.BackColor = Color.Red;
                        lblFood.ForeColor = Color.White;
                        lblFood.Visible = true;
                        return;
                    }

                    if (!int.TryParse(txtFoodCategoryId.Text, out int newFoodCategoryId))
                    {
                        lblFood.Text = "Lütfen geçerli bir 'Kategori ID' değeri giriniz.";
                        lblFood.BackColor = Color.Red;
                        lblFood.ForeColor = Color.White;
                        lblFood.Visible = true;
                        return;
                    }

                    selectedFood.FoodName = newFoodName;
                    selectedFood.FoodCalorie = newFoodCalorie;
                    selectedFood.PortionId = newFoodPortionId;
                    selectedFood.FoodCategoryId = newFoodCategoryId;

                    foodManager.Update(selectedFood);

                    if (foodManager.Save() > 0)
                    {
                        GetFoodList(); // Listeyi yenile
                        lblFood.Text = "Yemek Güncellendi";
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
                    lblFood.Text = "Güncellemek için bir Yemek seçiniz.";
                    lblFood.BackColor = Color.Red;
                    lblFood.ForeColor = Color.White;
                    lblFood.Visible = true;
                    return;
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
