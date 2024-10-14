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
        BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager();
        BeverageCategoryModel selectedCategory;
        public BeverageCategoryPanel()
        {
            InitializeComponent();

        }

        private void BevereagesCategoryPanel_Load(object sender, EventArgs e)
        {
            GetBeverageCategoryList();
        }

        public void GetBeverageCategoryList()
        {         
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                dgvBeveragesCategory.DataSource = beverageCategoryManager.GetAll();
            }

        }

        private void btnBeveragesCategoryAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBeverageCategoryName.Text))
            {
                MessageBox.Show("Lütfen 'Öğün Adı' kısmınızı doldurunuz.");
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
                        lblBeverageMessage.Text = "Öğün Kategorisi Eklendi.";
                        lblBeverageMessage.Visible = true;
                        GetBeverageCategoryList();
                    }
                    else
                    {
                        lblBeverageMessage.Text = "Öğün Kategorisi Oluşturulamadı!!";
                        lblBeverageMessage.BackColor = Color.Red;
                        lblBeverageMessage.Visible = true;
                    }
                    FormClear();
                }
            }
            
        }

        public void FormClear()
        {
            txtBeverageCategoryName.Clear();
        }

        private void btnBeveragesCategoryDelete_Click(object sender, EventArgs e)
        {
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {

                beverageCategoryManager.Delete(selectedCategory);

                if (beverageCategoryManager.Save() > 0)
                {
                    lblBeverageMessage.Text = "İçecek Kategorisi Eklendi";
                    selectedCategory = null;
                    lblBeverageMessage.Visible = true;

                    GetBeverageCategoryList();
                }
                else
                {
                    lblBeverageMessage.Text = "İçecek Kategorisi Olmadı:(!!";
                    lblBeverageMessage.BackColor = Color.Red;
                    lblBeverageMessage.Visible = true;
                }

                FormClear();

            }
        }

        private void dgvBeveragesCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (BeverageCategoryModel)dgvBeveragesCategory.SelectedRows[0].DataBoundItem;
            lblBeverageMessage.Text =selectedCategory.BeverageCategoryName;
            txtBeverageCategoryName.Text = selectedCategory.BeverageCategoryName;
        }

       
        private void btnBeveragesCategoryUpdate_Click(object sender, EventArgs e)
        {
            
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                

                BeverageCategoryModel beverageCategoryModel = new BeverageCategoryModel();
                beverageCategoryModel.BeverageCategoryName = txtBeverageCategoryName.Text;
                beverageCategoryManager.Update(selectedCategory);

                if (dgvBeveragesCategory.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(txtBeverageCategoryName.Text))
                {

                    //dgvBeveragesCategory.SelectedRows[0].Cells[0].Value = txtBeverageCategoryName.Text;

                   
                    if (beverageCategoryManager.Save() > 0)
                    {
                        GetBeverageCategoryList(); // Listeyi yenile
                        lblBeverageMessage.Text = "İçecek Kategorisi Güncellendi";
                        selectedCategory = null;
                        lblBeverageMessage.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                    }
                    else
                    {
                        lblBeverageMessage.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblBeverageMessage.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                    }
                }
                else
                {
                    lblBeverageMessage.Text = " Güncellemek için bir İçecek Kategorisi seçin ve yeni İçecek Kategorisi adı girin.";
                    lblBeverageMessage.BackColor = Color.Red;
                    lblBeverageMessage.Visible = true;
                }

                FormClear();
            }

            //using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            //{
            //    // Kullanıcıdan alınan yeni kategori adı
            //    string newCategoryName = txtBeverageCategoryName.Text;

            //    if (dgvBeveragesCategory.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newCategoryName))
            //    {
            //        // Seçilen kategori üzerinde güncellemeler yapılıyor
            //        selectedCategory.BeverageCategoryName = newCategoryName; // Var olan kategori nesnesini güncelle

            //        // Güncelleme işlemini gerçekleştir
            //        beverageCategoryManager.Update(selectedCategory);

            //        if (beverageCategoryManager.Save() > 0)
            //        {
            //            GetBeverageCategoryList(); // Listeyi yenile
            //            lblBeverageMessage.Text = "İçecek Kategorisi Güncellendi";
            //            lblBeverageMessage.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
            //        }
            //        else
            //        {
            //            lblBeverageMessage.Text = "Güncelleme sırasında bir hata oluştu.";
            //            lblBeverageMessage.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
            //        }
            //    }
            //    else
            //    {
            //        lblBeverageMessage.Text = "Güncellemek için bir İçecek Kategorisi seçin ve yeni İçecek Kategorisi adı girin.";
            //        lblBeverageMessage.BackColor = Color.Red;
            //    }

            //    lblBeverageMessage.Visible = true;
            //    FormClear(); // Formu temizle
            //}
        }
    }
}
