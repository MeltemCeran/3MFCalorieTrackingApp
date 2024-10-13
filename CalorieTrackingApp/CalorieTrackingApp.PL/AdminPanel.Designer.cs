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
            btnwants = new Button();
            btnBeverage = new Button();
            btnfood = new Button();
            btnMeal = new Button();
            dgvMealFoodBeverage = new DataGridView();
            lblAdminName = new Label();
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
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(816, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnwants
            // 
            btnwants.FlatStyle = FlatStyle.Flat;
            btnwants.Location = new Point(24, 236);
            btnwants.Margin = new Padding(3, 2, 3, 2);
            btnwants.Name = "btnwants";
            btnwants.Size = new Size(199, 38);
            btnwants.TabIndex = 5;
            btnwants.Text = "Yemek İstekleri";
            btnwants.UseVisualStyleBackColor = true;
            // 
            // btnBeverage
            // 
            btnBeverage.FlatStyle = FlatStyle.Flat;
            btnBeverage.Location = new Point(24, 178);
            btnBeverage.Margin = new Padding(3, 2, 3, 2);
            btnBeverage.Name = "btnBeverage";
            btnBeverage.Size = new Size(199, 38);
            btnBeverage.TabIndex = 4;
            btnBeverage.Text = "İçecekler";
            btnBeverage.UseVisualStyleBackColor = true;
            btnBeverage.Click += btnBeverage_Click;
            // 
            // btnfood
            // 
            btnfood.FlatStyle = FlatStyle.Flat;
            btnfood.Location = new Point(24, 122);
            btnfood.Margin = new Padding(3, 2, 3, 2);
            btnfood.Name = "btnfood";
            btnfood.Size = new Size(199, 38);
            btnfood.TabIndex = 3;
            btnfood.Text = "Yemekler";
            btnfood.UseVisualStyleBackColor = true;
            btnfood.Click += btnfood_Click;
            // 
            // btnMeal
            // 
            btnMeal.FlatStyle = FlatStyle.Flat;
            btnMeal.Location = new Point(24, 67);
            btnMeal.Margin = new Padding(3, 2, 3, 2);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(199, 38);
            btnMeal.TabIndex = 2;
            btnMeal.Text = "Öğünler";
            btnMeal.UseVisualStyleBackColor = true;
            btnMeal.Click += btnMeal_Click;
            // 
            // dgvMealFoodBeverage
            // 
            dgvMealFoodBeverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealFoodBeverage.Location = new Point(245, 30);
            dgvMealFoodBeverage.Margin = new Padding(3, 2, 3, 2);
            dgvMealFoodBeverage.Name = "dgvMealFoodBeverage";
            dgvMealFoodBeverage.RowHeadersWidth = 51;
            dgvMealFoodBeverage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMealFoodBeverage.Size = new Size(551, 315);
            dgvMealFoodBeverage.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(5, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(60, 15);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba: ";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
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