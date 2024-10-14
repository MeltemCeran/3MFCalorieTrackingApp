using CalorieTrackingApp.BLL.Manager.Concrete;
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
        public BeveragePanel()
        {
            InitializeComponent();
        }

        private void BevereagesPanel_Load(object sender, EventArgs e)
        {
            GetBeverageList();
        }

        private void GetBeverageList()
        {
            BeverageManager beverageManager = new BeverageManager();
            dgvBeverage.DataSource = beverageManager.GetAll();


        }

        private void FormClear()
        {
            txtBeverageCalorie.Clear();
            txtBeverageName.Clear();
            txtBeveragePortion.Clear();
            txtBeverageCategory.Clear();
        }

        
        private void btnBeverageAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBeverageName.Text) && !string.IsNullOrWhiteSpace(txtBeverageCalorie.Text) &&
               !string.IsNullOrWhiteSpace(txtBeveragePortion.Text) && !string.IsNullOrWhiteSpace(txtBeverageCategory.Text) )
            {
                dgvBeverage.Rows.Add(txtBeverageName.Text, txtBeverageCalorie.Text, txtBeveragePortion.Text, txtBeverageCategory.Text);
                lblBeverageCategory.Text = "Durum: İçecek Eklendi";
                FormClear();
            }
            else
            {
                lblBeverageCategory.Text = "Durum: Lütfen tüm alanları doldurun.";
            }
        }

        
    }
}
