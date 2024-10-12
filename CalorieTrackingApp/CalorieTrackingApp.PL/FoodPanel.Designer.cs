namespace CalorieTrackingApp.PL
{
    partial class FoodPanel
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
            grpbFood = new GroupBox();
            cmbFoodCategory = new ComboBox();
            txtFoodPortion = new TextBox();
            txtFoodCalorie = new TextBox();
            txtFoodName = new TextBox();
            btnFoodCategoryAdd = new Button();
            btnFoodUpdate = new Button();
            btnFoodDelete = new Button();
            btnFoodAdd = new Button();
            lblAdminName = new Label();
            dgvFood = new DataGridView();
            grpbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // grpbFood
            // 
            grpbFood.Controls.Add(cmbFoodCategory);
            grpbFood.Controls.Add(txtFoodPortion);
            grpbFood.Controls.Add(txtFoodCalorie);
            grpbFood.Controls.Add(txtFoodName);
            grpbFood.Controls.Add(btnFoodCategoryAdd);
            grpbFood.Controls.Add(btnFoodUpdate);
            grpbFood.Controls.Add(btnFoodDelete);
            grpbFood.Controls.Add(btnFoodAdd);
            grpbFood.Controls.Add(lblAdminName);
            grpbFood.Controls.Add(dgvFood);
            grpbFood.Location = new Point(12, 12);
            grpbFood.Name = "grpbFood";
            grpbFood.Size = new Size(932, 528);
            grpbFood.TabIndex = 2;
            grpbFood.TabStop = false;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(22, 220);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(227, 28);
            cmbFoodCategory.TabIndex = 9;
            // 
            // txtFoodPortion
            // 
            txtFoodPortion.BorderStyle = BorderStyle.FixedSingle;
            txtFoodPortion.Location = new Point(22, 172);
            txtFoodPortion.Name = "txtFoodPortion";
            txtFoodPortion.PlaceholderText = " Yemek Porsiyon";
            txtFoodPortion.Size = new Size(227, 27);
            txtFoodPortion.TabIndex = 8;
            // 
            // txtFoodCalorie
            // 
            txtFoodCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtFoodCalorie.Location = new Point(22, 124);
            txtFoodCalorie.Name = "txtFoodCalorie";
            txtFoodCalorie.PlaceholderText = " Yemek Kalori";
            txtFoodCalorie.Size = new Size(227, 27);
            txtFoodCalorie.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.BorderStyle = BorderStyle.FixedSingle;
            txtFoodName.Location = new Point(22, 76);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = " Yemek Adı";
            txtFoodName.Size = new Size(227, 27);
            txtFoodName.TabIndex = 6;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryAdd.Location = new Point(22, 366);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(227, 50);
            btnFoodCategoryAdd.TabIndex = 5;
            btnFoodCategoryAdd.Text = "Yemek Kategorisi Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // btnFoodUpdate
            // 
            btnFoodUpdate.FlatStyle = FlatStyle.Flat;
            btnFoodUpdate.Location = new Point(22, 308);
            btnFoodUpdate.Name = "btnFoodUpdate";
            btnFoodUpdate.Size = new Size(227, 50);
            btnFoodUpdate.TabIndex = 4;
            btnFoodUpdate.Text = "Yemek Güncelle";
            btnFoodUpdate.UseVisualStyleBackColor = true;
            btnFoodUpdate.Click += btnFoodUpdate_Click;
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.FlatStyle = FlatStyle.Flat;
            btnFoodDelete.Location = new Point(144, 254);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(105, 50);
            btnFoodDelete.TabIndex = 3;
            btnFoodDelete.Text = "Yemek Sil";
            btnFoodDelete.UseVisualStyleBackColor = true;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.FlatStyle = FlatStyle.Flat;
            btnFoodAdd.Location = new Point(22, 254);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(105, 50);
            btnFoodAdd.TabIndex = 2;
            btnFoodAdd.Text = "Yemek Ekle";
            btnFoodAdd.UseVisualStyleBackColor = true;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(6, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(75, 20);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "Merhaba: ";
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(280, 40);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new Size(630, 420);
            dgvFood.TabIndex = 0;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpbFood);
            Name = "FoodPanel";
            Text = "FoodPanel";
            grpbFood.ResumeLayout(false);
            grpbFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbFood;
        private Button btnFoodUpdate;
        private Button btnFoodDelete;
        private Button btnFoodAdd;
        private Label lblAdminName;
        private DataGridView dgvFood;
        private Button btnFoodCategoryAdd;
        private TextBox txtFoodCalorie;
        private TextBox txtFoodName;
        private TextBox txtFoodPortion;
        private ComboBox cmbFoodCategory;
    }
}