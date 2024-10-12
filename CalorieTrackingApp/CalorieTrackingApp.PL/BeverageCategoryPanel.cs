using CalorieTrackingApp.BLL.Manager.Concrete;
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
    }
}
