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
    public partial class MealPanel : Form
    {
        public MealPanel()
        {
            InitializeComponent();
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {

        }

        private void MealPanel_Load(object sender, EventArgs e)
        {
            dgvGetData();
        }

        private void dgvGetData()
        {
            
        }
    }
}
