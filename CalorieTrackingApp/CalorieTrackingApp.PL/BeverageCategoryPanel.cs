using CalorieTrackingApp.BLL.Manager.Concrete;
using CalorieTrackingApp.BLL.Models.Concrete;
using CalorieTrackingApp.DAL.Context;
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

        private void GetBeverageCategoryList()
        {
            BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager();
            dgvBeveragesCategory.DataSource = beverageCategoryManager.GetAll();


        }

        private void btnBeveragesCategoryAdd_Click(object sender, EventArgs e)
        {
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {
                BeverageCategoryModel beverageCategoryModel = new BeverageCategoryModel();
                beverageCategoryModel.BeverageCategoryName = txtBeverageCatogoryName.Text;
                beverageCategoryModel.DataStatus = DAL.Enums.DataStatus.Inserted;
                beverageCategoryManager.Create(beverageCategoryModel);

                if (beverageCategoryManager.Save() > 0)
                {
                    lblBeverageMessage.Text = "İçecek Kategorisi Eklendi.";
                    lblBeverageMessage.Visible = true;
                    GetBeverageCategoryList();
                }
                else
                {
                    lblBeverageMessage.Text = "İçecek Kategorisi Oluşturulamadı!!";
                    lblBeverageMessage.BackColor = Color.Red;
                    lblBeverageMessage.Visible = true;
                }
                FormClear();
            }
        }

        private void FormClear()
        {
            txtBeverageCatogoryName.Text = string.Empty;
        }

        private void btnBeveragesCategoryDelete_Click(object sender, EventArgs e)
        {
            using (BeverageCategoryManager beverageCategoryManager = new BeverageCategoryManager())
            {

                beverageCategoryManager.Delete(selectedCategory);

                if (beverageCategoryManager.Save() > 0)
                {
                    lblBeverageMessage.Text = "Eklendi";
                    lblBeverageMessage.Visible = true;

                    GetBeverageCategoryList();
                }
                else
                {
                    lblBeverageMessage.Text = "Olmadı:(!!";
                    lblBeverageMessage.BackColor = Color.Red;
                    lblBeverageMessage.Visible = true;
                }

                FormClear();

            }
        }

        private void dgvBeveragesCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (BeverageCategoryModel)dgvBeveragesCategory.SelectedRows[0].DataBoundItem;
            txtBeverageCatogoryName.Text = selectedCategory.ToString();
        }
    }
}
