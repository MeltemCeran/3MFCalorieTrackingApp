namespace CalorieTrackingApp.PL
{
    partial class FoodCategoryPanel
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
            gBoxFoodCategory = new GroupBox();
            btnFoodCategoryUpdate = new Button();
            btnFoodCategoryDelete = new Button();
            btnFoodCategoryAdd = new Button();
            dgvFoodCategory = new DataGridView();
            lblAdminName = new Label();
            gBoxFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodCategory).BeginInit();
            SuspendLayout();
            // 
            // gBoxFoodCategory
            // 
            gBoxFoodCategory.Controls.Add(btnFoodCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvFoodCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(14, 16);
            gBoxFoodCategory.Margin = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Padding = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Size = new Size(764, 568);
            gBoxFoodCategory.TabIndex = 0;
            gBoxFoodCategory.TabStop = false;
            // 
            // btnFoodCategoryUpdate
            // 
            btnFoodCategoryUpdate.Location = new Point(586, 416);
            btnFoodCategoryUpdate.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryUpdate.Name = "btnFoodCategoryUpdate";
            btnFoodCategoryUpdate.Size = new Size(149, 53);
            btnFoodCategoryUpdate.TabIndex = 4;
            btnFoodCategoryUpdate.Text = "Yemek Kategori Güncelle";
            btnFoodCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFoodCategoryDelete
            // 
            btnFoodCategoryDelete.Location = new Point(418, 416);
            btnFoodCategoryDelete.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryDelete.Name = "btnFoodCategoryDelete";
            btnFoodCategoryDelete.Size = new Size(149, 53);
            btnFoodCategoryDelete.TabIndex = 3;
            btnFoodCategoryDelete.Text = "Yemek Kategori Sil";
            btnFoodCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.Location = new Point(247, 416);
            btnFoodCategoryAdd.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(149, 53);
            btnFoodCategoryAdd.TabIndex = 2;
            btnFoodCategoryAdd.Text = "Yemek Kategori Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // dgvFoodCategory
            // 
            dgvFoodCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodCategory.Location = new Point(247, 40);
            dgvFoodCategory.Margin = new Padding(3, 4, 3, 4);
            dgvFoodCategory.Name = "dgvFoodCategory";
            dgvFoodCategory.RowHeadersWidth = 51;
            dgvFoodCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodCategory.Size = new Size(488, 344);
            dgvFoodCategory.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(7, 13);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(71, 20);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba:";
            // 
            // FoodCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 600);
            Controls.Add(gBoxFoodCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FoodCategoryPanel";
            Text = "FoodCategoryPanel";
            Load += FoodCategoryPanel_Load;
            gBoxFoodCategory.ResumeLayout(false);
            gBoxFoodCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxFoodCategory;
        private Button btnFoodCategoryUpdate;
        private Button btnFoodCategoryDelete;
        private Button btnFoodCategoryAdd;
        private DataGridView dgvFoodCategory;
        private Label lblAdminName;
    }
}