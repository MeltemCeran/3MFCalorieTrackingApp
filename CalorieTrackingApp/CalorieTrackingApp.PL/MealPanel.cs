using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Entities.Concrete;
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
using System.Xml.Linq;

namespace CalorieTrackingApp.PL
{
    public partial class MealPanel : Form
    {
        MealModel selectedMeal;

        public MealPanel()
        {
            InitializeComponent();
        }

        private void MealPanel_Load(object sender, EventArgs e)
        {
            GetMealList();
        }

        public void FormClear()
        {
            txtMealName.Clear();
        }

        public void GetMealList()
        {
            using (MealManager mealManager = new MealManager())
            {
                dgvMeal.DataSource = mealManager.GetAll();
            }
        }
        
        private void dgvMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMeal = (MealModel)dgvMeal.SelectedRows[0].DataBoundItem;
            txtMealName.Text = selectedMeal.MealName;
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMealName.Text))
            {
                MessageBox.Show("Lütfen 'Öğün Adı' kısmınızı doldurunuz.");
                return;
            }
            else
            {
                using (MealManager mealManager = new MealManager())
                {
                    MealModel mealModel = new MealModel();
                    mealModel.MealName = txtMealName.Text;
                    mealModel.CreatedDate = DateTime.Now;
                    mealModel.DataStatus = DAL.Enums.DataStatus.Inserted;
                    mealManager.Create(mealModel);

                    if (mealManager.Save() > 0)
                    {
                        lblMeal.Text = "Öğün Eklendi.";
                        lblMeal.BackColor = Color.Green;
                        lblMeal.ForeColor = Color.White;
                        lblMeal.Visible = true;
                        GetMealList();
                    }
                    else
                    {
                        lblMeal.Text = "Öğün Eklenemedi.";
                        lblMeal.BackColor = Color.Red;
                        lblMeal.ForeColor = Color.White;
                        lblMeal.Visible = true;
                    }
                    FormClear();
                }
            }
        }
        
        private void btnMealDelete_Click(object sender, EventArgs e)
        {
            using (MealManager mealManager = new MealManager())
            {
                mealManager.Delete(selectedMeal);

                if (mealManager.Save() > 0)
                {
                    lblMeal.Text = "Öğün Silindi.";
                    lblMeal.BackColor = Color.Green;
                    lblMeal.ForeColor = Color.White;
                    lblMeal.Visible = true;

                    GetMealList();
                }
                else
                {
                    lblMeal.Text = "Öğün Silinemedi.";
                    lblMeal.BackColor = Color.Red;
                    lblMeal.ForeColor = Color.White;
                    lblMeal.Visible = true;
                }

                FormClear();
            }
        }

        private void btnMealUpdate_Click(object sender, EventArgs e)
        {
            using (MealManager mealManager = new MealManager())
            {
                string newMealName = txtMealName.Text;

                if (dgvMeal.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newMealName))
                {
                    selectedMeal.MealName = newMealName;

                    // Güncelleme işlemini gerçekleştir
                    mealManager.Update(selectedMeal);

                    if (mealManager.Save() > 0)
                    {
                        GetMealList(); // Listeyi yenile
                        lblMeal.Text = "Öğün Güncellendi.";
                        lblMeal.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                        lblMeal.ForeColor = Color.White;
                    }
                    else
                    {
                        lblMeal.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblMeal.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                        lblMeal.ForeColor = Color.White;
                    }
                }
                else
                {
                    lblMeal.Text = "Güncellemek için lütfen bir öğün seçiniz.";
                    lblMeal.BackColor = Color.Red;
                    lblMeal.ForeColor = Color.White;
                }

                lblMeal.Visible = true;
                FormClear(); // Formu temizle
            }
        }
    }
}
