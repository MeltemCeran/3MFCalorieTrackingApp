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
        BeverageCategoryManager selectedCategory;
        public BeverageCategoryPanel()
        {
            InitializeComponent();

        }

        private void BevereagesCategoryPanel_Load(object sender, EventArgs e)
        {
            getBeverageCategoryList();
        }

        private void getBeverageCategoryList()
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
                    lblMessage.Text = "İçecek Kategorisi Eklendi.";
                    lblMessage.Visible = true;
                    getBeverageCategoryList();
                }
                else
                {
                    lblMessage.Text = "İçecek Kategorisi Oluşturulamadı!!";
                    lblMessage.BackColor = Color.Red;
                    lblMessage.Visible = true;
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
                //int id =


                // SOR:  BeverageCategoryModel beverageCategoryModel = beverageCategoryManager.GetById(id);

                //beverageCategoryModel = DateTime.Now;
                //toDoModel.IsDeleted = true;

                //beverageCategoryManager.Delete(selectedCategory);

                if (beverageCategoryManager.Save() > 0)
                {
                    lblMessage.Text = "Remove ToDo Success";
                    lblMessage.Visible = true;

                    getBeverageCategoryList();
                }
                else
                {
                    lblMessage.Text = "Remove ToDo Failed!!";
                    lblMessage.BackColor = Color.Red;
                    lblMessage.Visible = true;
                }

                FormClear();

            }
        }

        private void dgvBeveragesCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (BeverageCategoryManager)dgvBeveragesCategory.SelectedRows[0].DataBoundItem;
            txtBeverageCatogoryName.Text = selectedCategory.ToString();
        }
    }
}
