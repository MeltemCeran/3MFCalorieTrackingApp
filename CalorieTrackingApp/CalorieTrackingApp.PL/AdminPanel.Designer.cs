namespace CalorieTrackingApp.PL
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblAdminName = new Label();
            dgvMealFoodBeverage = new DataGridView();
            btnMeal = new Button();
            btnfood = new Button();
            btnBeverage = new Button();
            btnwants = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMealFoodBeverage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnwants);
            groupBox1.Controls.Add(btnBeverage);
            groupBox1.Controls.Add(btnfood);
            groupBox1.Controls.Add(btnMeal);
            groupBox1.Controls.Add(dgvMealFoodBeverage);
            groupBox1.Controls.Add(lblAdminName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 639);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(0, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(75, 20);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba: ";
            // 
            // dgvMealFoodBeverage
            // 
            dgvMealFoodBeverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealFoodBeverage.Location = new Point(6, 58);
            dgvMealFoodBeverage.Name = "dgvMealFoodBeverage";
            dgvMealFoodBeverage.RowHeadersWidth = 51;
            dgvMealFoodBeverage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMealFoodBeverage.Size = new Size(767, 376);
            dgvMealFoodBeverage.TabIndex = 1;
            // 
            // btnMeal
            // 
            btnMeal.Location = new Point(6, 450);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(167, 42);
            btnMeal.TabIndex = 2;
            btnMeal.Text = "Öğünler";
            btnMeal.UseVisualStyleBackColor = true;
            // 
            // btnfood
            // 
            btnfood.Location = new Point(309, 450);
            btnfood.Name = "btnfood";
            btnfood.Size = new Size(167, 42);
            btnfood.TabIndex = 3;
            btnfood.Text = "Yemekler";
            btnfood.UseVisualStyleBackColor = true;
            // 
            // btnBeverage
            // 
            btnBeverage.Location = new Point(606, 450);
            btnBeverage.Name = "btnBeverage";
            btnBeverage.Size = new Size(167, 42);
            btnBeverage.TabIndex = 4;
            btnBeverage.Text = "İçecekler";
            btnBeverage.UseVisualStyleBackColor = true;
            // 
            // btnwants
            // 
            btnwants.Location = new Point(796, 58);
            btnwants.Name = "btnwants";
            btnwants.Size = new Size(142, 52);
            btnwants.TabIndex = 5;
            btnwants.Text = "Yemek İstekleri";
            btnwants.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 663);
            Controls.Add(groupBox1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMealFoodBeverage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdminName;
        private DataGridView dgvMealFoodBeverage;
        private Button btnBeverage;
        private Button btnfood;
        private Button btnMeal;
        private Button btnwants;
    }
}