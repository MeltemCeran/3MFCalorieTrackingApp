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
            txtFoodCategoryName = new TextBox();
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
            gBoxFoodCategory.Controls.Add(txtFoodCategoryName);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvFoodCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(12, 12);
            gBoxFoodCategory.Margin = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Padding = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Size = new Size(932, 528);
            gBoxFoodCategory.TabIndex = 0;
            gBoxFoodCategory.TabStop = false;
            // 
            // txtFoodCategoryName
            // 
            txtFoodCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtFoodCategoryName.Location = new Point(16, 135);
            txtFoodCategoryName.Name = "txtFoodCategoryName";
            txtFoodCategoryName.PlaceholderText = " Yemek Kategori Adı";
            txtFoodCategoryName.Size = new Size(227, 27);
            txtFoodCategoryName.TabIndex = 5;
            // 
            // btnFoodCategoryUpdate
            // 
            btnFoodCategoryUpdate.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryUpdate.Location = new Point(16, 293);
            btnFoodCategoryUpdate.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryUpdate.Name = "btnFoodCategoryUpdate";
            btnFoodCategoryUpdate.Size = new Size(227, 50);
            btnFoodCategoryUpdate.TabIndex = 4;
            btnFoodCategoryUpdate.Text = "Yemek Kategori Güncelle";
            btnFoodCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFoodCategoryDelete
            // 
            btnFoodCategoryDelete.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryDelete.Location = new Point(16, 235);
            btnFoodCategoryDelete.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryDelete.Name = "btnFoodCategoryDelete";
            btnFoodCategoryDelete.Size = new Size(227, 50);
            btnFoodCategoryDelete.TabIndex = 3;
            btnFoodCategoryDelete.Text = "Yemek Kategori Sil";
            btnFoodCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryAdd.Location = new Point(16, 177);
            btnFoodCategoryAdd.Margin = new Padding(3, 4, 3, 4);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(227, 50);
            btnFoodCategoryAdd.TabIndex = 2;
            btnFoodCategoryAdd.Text = "Yemek Kategori Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // dgvFoodCategory
            // 
            dgvFoodCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodCategory.Location = new Point(280, 40);
            dgvFoodCategory.Margin = new Padding(3, 4, 3, 4);
            dgvFoodCategory.Name = "dgvFoodCategory";
            dgvFoodCategory.RowHeadersWidth = 51;
            dgvFoodCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodCategory.Size = new Size(630, 420);
            dgvFoodCategory.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(6, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(71, 20);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba:";
            // 
            // FoodCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
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
        private TextBox txtFoodCategoryName;
    }
}