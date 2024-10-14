using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Context;
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

    public partial class BeverageCategoryPanel : Form
    {
        BeverageCategoryModel selectedCategory;

        public BeverageCategoryPanel()
        {
            InitializeComponent();

        }

        private void BevereagesCategoryPanel_Load(object sender, EventArgs e)
        {
            GetBeverageCategoryList();
        }

        public void FormClear()
        {
            txtBeverageCategoryName.Clear();
        }

        public void GetBeverageCategoryList()
        {         
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                dgvBeveragesCategory.DataSource = beverageCategoryManager.GetAll();
            }

        }
        private void dgvBeveragesCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (BeverageCategoryModel)dgvBeveragesCategory.SelectedRows[0].DataBoundItem;
            txtBeverageCategoryName.Text = selectedCategory.BeverageCategoryName;
        }
        private void btnBeveragesCategoryAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBeverageCategoryName.Text))
            {
                MessageBox.Show("Lütfen 'İçecek Kategori Adı' kısmınızı doldurunuz.");
                return;
            }
            else
            {
                using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
                {
                    BeverageCategoryModel beverageCategoryModel = new BeverageCategoryModel();
                    beverageCategoryModel.BeverageCategoryName = txtBeverageCategoryName.Text;
                    beverageCategoryModel.CreatedDate = DateTime.Now;
                    beverageCategoryModel.DataStatus = DataStatus.Inserted;
                    beverageCategoryManager.Create(beverageCategoryModel);

                    if (beverageCategoryManager.Save() > 0)
                    {
                        lblBeverageCategory.Text = "İçecek Kategorisi Eklendi.";
                        lblBeverageCategory.BackColor = Color.Green;
                        lblBeverageCategory.ForeColor = Color.White;
                        lblBeverageCategory.Visible = true;
                        GetBeverageCategoryList();
                    }
                    else
                    {
                        lblBeverageCategory.Text = "İçecek Kategorisi Eklenemedi.";
                        lblBeverageCategory.BackColor = Color.Red;
                        lblBeverageCategory.ForeColor= Color.White;
                        lblBeverageCategory.Visible = true;
                    }
                    FormClear();
                }
            }
            
        }

        private void btnBeveragesCategoryDelete_Click(object sender, EventArgs e)
        {
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {

                beverageCategoryManager.Delete(selectedCategory);

                if (beverageCategoryManager.Save() > 0)
                {
                    lblBeverageCategory.Text = "İçecek Kategorisi Silindi.";
                    lblBeverageCategory.BackColor = Color.Green;
                    lblBeverageCategory.ForeColor = Color.White;
                    selectedCategory = null;
                    lblBeverageCategory.Visible = true;

                    GetBeverageCategoryList();
                }
                else
                {
                    lblBeverageCategory.Text = "İçecek Kategorisi Silinemedi.";
                    lblBeverageCategory.BackColor = Color.Red;
                    lblBeverageCategory.ForeColor = Color.White;
                    lblBeverageCategory.Visible = true;
                }

                FormClear();

            }
        }

        private void btnBeveragesCategoryUpdate_Click(object sender, EventArgs e)
        {
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                // Kullanıcıdan alınan yeni kategori adı
                string newBeverageCategoryName = txtBeverageCategoryName.Text;

                if (dgvBeveragesCategory.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newBeverageCategoryName))
                {
                    // Seçilen kategori üzerinde güncellemeler yapılıyor
                    selectedCategory.BeverageCategoryName = newBeverageCategoryName; // Var olan kategori nesnesini güncelle

                    // Güncelleme işlemini gerçekleştir
                    beverageCategoryManager.Update(selectedCategory);

                    if (beverageCategoryManager.Save() > 0)
                    {
                        GetBeverageCategoryList(); // Listeyi yenile
                        lblBeverageCategory.Text = "İçecek Kategorisi Güncellendi";
                        lblBeverageCategory.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                        lblBeverageCategory.ForeColor = Color.White;
                    }
                    else
                    {
                        lblBeverageCategory.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblBeverageCategory.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                        lblBeverageCategory.ForeColor = Color.White;
                    }
                }
                else
                {
                    lblBeverageCategory.Text = "Güncellemek için bir İçecek Kategorisi seçiniz.";
                    lblBeverageCategory.BackColor = Color.Red;
                }

                lblBeverageCategory.Visible = true;
                FormClear(); // Formu temizle
            }
        }
    }
}
