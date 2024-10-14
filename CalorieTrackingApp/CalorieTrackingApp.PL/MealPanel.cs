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
                        lblMealMessage.Text = "Öğün Kategorisi Eklendi.";
                        lblMealMessage.Visible = true;
                        GetMealList();
                    }
                    else
                    {
                        lblMealMessage.Text = "Öğün Kategorisi Oluşturulamadı!!";
                        lblMealMessage.BackColor = Color.Red;
                        lblMealMessage.Visible = true;
                    }
                    FormClear();
                }
            }
        }
        private void FormClear()
        {
            txtMealName.Clear();
        }

        private void MealPanel_Load(object sender, EventArgs e)
        {
            GetMealList();
        }

        private void GetMealList()
        {
            using (MealManager mealManager = new MealManager())
            {
                dgvMeal.DataSource = mealManager.GetAll();
            }
        }
        private void dgvMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMeal = (MealModel)dgvMeal.SelectedRows[0].DataBoundItem;
            lblMealMessage.Text = selectedMeal.MealName;
            txtMealName.Text = selectedMeal.MealName;
        }
        private void btnMealDelete_Click(object sender, EventArgs e)
        {
            using (MealManager mealManager = new MealManager())
            {
                mealManager.Delete(selectedMeal);

                if (mealManager.Save() > 0)
                {
                    lblMealMessage.Text = "Eklendi";
                    lblMealMessage.Visible = true;

                    GetMealList();
                }
                else
                {
                    lblMealMessage.Text = "Olmadı:(!!";
                    lblMealMessage.BackColor = Color.Red;
                    lblMealMessage.Visible = true;
                }

                FormClear();
            }
        }
         //Update çalışmıyor!!!!!
        private void btnMealUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMeal.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(txtMealName.Text))
            {
                dgvMeal.SelectedRows[0].Cells[0].Value = txtMealName.Text;  // Seçilen satırın verisini günceller
                lblMealMessage.Text = "Durum: Öğün Güncellendi";
                txtMealName.Clear();
            }
            else
            {
                lblMealMessage.Text = "Durum: Güncellemek için bir öğün seçin ve yeni öğün adı girin.";
            }
        }
    }
}
