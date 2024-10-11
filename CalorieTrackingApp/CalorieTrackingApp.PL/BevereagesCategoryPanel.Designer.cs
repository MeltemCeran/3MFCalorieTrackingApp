namespace CalorieTrackingApp.PL
{
    partial class BevereagesCategoryPanel
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
            btnBeveragesCategoryUpdate = new Button();
            btnBeveragesCategoryDelete = new Button();
            btnBeveragesCategoryAdd = new Button();
            dgvBeveragesCategory = new DataGridView();
            lblAdminName = new Label();
            gBoxFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeveragesCategory).BeginInit();
            SuspendLayout();
            // 
            // gBoxFoodCategory
            // 
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvBeveragesCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(12, 12);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Size = new Size(481, 426);
            gBoxFoodCategory.TabIndex = 1;
            gBoxFoodCategory.TabStop = false;
            // 
            // btnBeveragesCategoryUpdate
            // 
            btnBeveragesCategoryUpdate.Location = new Point(322, 317);
            btnBeveragesCategoryUpdate.Name = "btnBeveragesCategoryUpdate";
            btnBeveragesCategoryUpdate.Size = new Size(130, 40);
            btnBeveragesCategoryUpdate.TabIndex = 4;
            btnBeveragesCategoryUpdate.Text = "İçecek Kategori Güncelle";
            btnBeveragesCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBeveragesCategoryDelete
            // 
            btnBeveragesCategoryDelete.Location = new Point(175, 317);
            btnBeveragesCategoryDelete.Name = "btnBeveragesCategoryDelete";
            btnBeveragesCategoryDelete.Size = new Size(130, 40);
            btnBeveragesCategoryDelete.TabIndex = 3;
            btnBeveragesCategoryDelete.Text = "İçecek Kategori Sil";
            btnBeveragesCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnBeveragesCategoryAdd
            // 
            btnBeveragesCategoryAdd.Location = new Point(25, 317);
            btnBeveragesCategoryAdd.Name = "btnBeveragesCategoryAdd";
            btnBeveragesCategoryAdd.Size = new Size(130, 40);
            btnBeveragesCategoryAdd.TabIndex = 2;
            btnBeveragesCategoryAdd.Text = "İçecek Kategori Ekle";
            btnBeveragesCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // dgvBeveragesCategory
            // 
            dgvBeveragesCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeveragesCategory.Location = new Point(25, 40);
            dgvBeveragesCategory.Name = "dgvBeveragesCategory";
            dgvBeveragesCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeveragesCategory.Size = new Size(427, 258);
            dgvBeveragesCategory.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(6, 10);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(57, 15);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba:";
            // 
            // BevereagesCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(gBoxFoodCategory);
            Name = "BevereagesCategoryPanel";
            Text = "BevereagesCategoryPanel";
            gBoxFoodCategory.ResumeLayout(false);
            gBoxFoodCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeveragesCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxFoodCategory;
        private Button btnBeveragesCategoryUpdate;
        private Button btnBeveragesCategoryDelete;
        private Button btnBeveragesCategoryAdd;
        private DataGridView dgvBeveragesCategory;
        private Label lblAdminName;
    }
}