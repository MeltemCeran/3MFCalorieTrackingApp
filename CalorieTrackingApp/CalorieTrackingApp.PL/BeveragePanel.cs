﻿using CalorieTrackingApp.BLL.Manager.Concrete;
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
    public partial class BeveragePanel : Form
    {
        BeverageModel selectedBeverage;

        public BeveragePanel()
        {
            InitializeComponent();
        }

        private void BeveragePanel_Load(object sender, EventArgs e)
        {
            GetBeverageList();
        }

        public void FormClear()
        {
            txtBeverageName.Clear();
            txtBeverageCalorie.Clear();
            txtBeveragePortionId.Clear();
            txtBeverageCategoryId.Clear();
        }

        public void GetBeverageList()
        {
            using (BeverageManager beverageManager = new BeverageManager())
            {
                dgvBeverage.DataSource = beverageManager.GetAll().ToList();
            }
        }

        private void dgvBeverage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBeverage = (BeverageModel)dgvBeverage.SelectedRows[0].DataBoundItem;
            txtBeverageName.Text = selectedBeverage.BeverageName;
        }

        private void btnBeverageAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBeverageName.Text))           //kalori porsiyon ve id kontrolü yaz!!!
            {
                MessageBox.Show("Lütfen 'İçecek Adı' kısmınızı doldurunuz.");
                return;
            }
            else
            {
                using (BeverageManager beverageManager = new BeverageManager())
                {
                    BeverageModel beverageModel = new BeverageModel();
                    beverageModel.BeverageName = txtBeverageName.Text;
                    beverageModel.BeverageCalorie = Convert.ToDecimal(txtBeverageCalorie.Text);
                    beverageModel.PortionId = Convert.ToInt32(txtBeveragePortionId.Text);
                    beverageModel.BeverageCategoryId = Convert.ToInt32(txtBeverageCategoryId.Text);
                    beverageModel.CreatedDate = DateTime.Now;
                    beverageModel.DataStatus = DataStatus.Inserted;
                    beverageManager.Create(beverageModel);

                    if (beverageManager.Save() > 0)
                    {
                        lblBeverage.Text = "İçecek Eklendi.";
                        lblBeverage.BackColor = Color.Green;
                        lblBeverage.ForeColor = Color.White;
                        lblBeverage.Visible = true;
                        GetBeverageList();
                    }
                    else
                    {
                        lblBeverage.Text = "İçecek Eklenemedi.";
                        lblBeverage.BackColor = Color.Red;
                        lblBeverage.ForeColor = Color.White;
                        lblBeverage.Visible = true;
                    }
                    FormClear();
                }
            }
        }

        private void btnBeverageDelete_Click(object sender, EventArgs e)
        {
            using (BeverageManager beverageManager = new BeverageManager())
            {

                beverageManager.Delete(selectedBeverage);

                if (beverageManager.Save() > 0)
                {
                    lblBeverage.Text = "İçecek Silindi.";
                    lblBeverage.BackColor = Color.Green;
                    lblBeverage.ForeColor = Color.White;
                    selectedBeverage = null;
                    lblBeverage.Visible = true;

                    GetBeverageList();
                }
                else
                {
                    lblBeverage.Text = "İçecek Silinemedi.";
                    lblBeverage.BackColor = Color.Red;
                    lblBeverage.ForeColor = Color.White;
                    lblBeverage.Visible = true;
                }

                FormClear();

            }
        }

        private void btnBeverageUpdate_Click(object sender, EventArgs e)
        {
            using (BeverageManager beverageManager = new BeverageManager())
            {
                string newBeverageName = txtBeverageName.Text;

                if (dgvBeverage.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(newBeverageName))
                {
                    selectedBeverage.BeverageName = newBeverageName;

                    // Güncelleme işlemini gerçekleştir
                    beverageManager.Update(selectedBeverage);

                    if (beverageManager.Save() > 0)
                    {
                        GetBeverageList(); // Listeyi yenile
                        lblBeverage.Text = "İçecek Güncellendi";
                        lblBeverage.BackColor = Color.Green; // Başarılı güncelleme için yeşil arka plan
                        lblBeverage.ForeColor = Color.White;
                    }
                    else
                    {
                        lblBeverage.Text = "Güncelleme sırasında bir hata oluştu.";
                        lblBeverage.BackColor = Color.Red; // Hata durumu için kırmızı arka plan
                        lblBeverage.ForeColor = Color.White;
                    }
                }
                else
                {
                    lblBeverage.Text = "Güncellemek için lütfen bir İçecek seçiniz.";
                    lblBeverage.BackColor = Color.Red;
                    lblBeverage.ForeColor = Color.White;
                }

                lblBeverage.Visible = true;
                FormClear(); // Formu temizle
            }
        }

        private void btnBeverageCategoryAdd_Click(object sender, EventArgs e)
        {
            BeverageCategoryPanel beverageCategoryPanel = new BeverageCategoryPanel();
            beverageCategoryPanel.ShowDialog();
        }
    }
}
