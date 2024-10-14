namespace CalorieTrackingApp.PL
{
    partial class BeverageCategoryPanel
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
            lblBeverageCategory = new Label();
            txtBeverageCategoryName = new TextBox();
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
            gBoxFoodCategory.Controls.Add(lblBeverageCategory);
            gBoxFoodCategory.Controls.Add(txtBeverageCategoryName);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvBeveragesCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(11, 12);
            gBoxFoodCategory.Margin = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Padding = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Size = new Size(933, 528);
            gBoxFoodCategory.TabIndex = 1;
            gBoxFoodCategory.TabStop = false;
            // 
            // lblBeverageCategory
            // 
            lblBeverageCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBeverageCategory.Location = new Point(16, 359);
            lblBeverageCategory.Name = "lblBeverageCategory";
            lblBeverageCategory.Size = new Size(152, 69);
            lblBeverageCategory.TabIndex = 6;
            lblBeverageCategory.Text = "Durum:";
            lblBeverageCategory.Visible = false;
            // 
            // txtBeverageCategoryName
            // 
            txtBeverageCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageCategoryName.Location = new Point(16, 135);
            txtBeverageCategoryName.Name = "txtBeverageCategoryName";
            txtBeverageCategoryName.PlaceholderText = " İçecek Kategori Adı";
            txtBeverageCategoryName.Size = new Size(227, 27);
            txtBeverageCategoryName.TabIndex = 5;
            // 
            // btnBeveragesCategoryUpdate
            // 
            btnBeveragesCategoryUpdate.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryUpdate.Location = new Point(16, 297);
            btnBeveragesCategoryUpdate.Margin = new Padding(3, 4, 3, 4);
            btnBeveragesCategoryUpdate.Name = "btnBeveragesCategoryUpdate";
            btnBeveragesCategoryUpdate.Size = new Size(227, 51);
            btnBeveragesCategoryUpdate.TabIndex = 4;
            btnBeveragesCategoryUpdate.Text = "İçecek Kategori Güncelle";
            btnBeveragesCategoryUpdate.UseVisualStyleBackColor = true;
            btnBeveragesCategoryUpdate.Click += btnBeveragesCategoryUpdate_Click;
            // 
            // btnBeveragesCategoryDelete
            // 
            btnBeveragesCategoryDelete.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryDelete.Location = new Point(16, 239);
            btnBeveragesCategoryDelete.Margin = new Padding(3, 4, 3, 4);
            btnBeveragesCategoryDelete.Name = "btnBeveragesCategoryDelete";
            btnBeveragesCategoryDelete.Size = new Size(227, 51);
            btnBeveragesCategoryDelete.TabIndex = 3;
            btnBeveragesCategoryDelete.Text = "İçecek Kategori Sil";
            btnBeveragesCategoryDelete.UseVisualStyleBackColor = true;
            btnBeveragesCategoryDelete.Click += btnBeveragesCategoryDelete_Click;
            // 
            // btnBeveragesCategoryAdd
            // 
            btnBeveragesCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryAdd.Location = new Point(16, 181);
            btnBeveragesCategoryAdd.Margin = new Padding(3, 4, 3, 4);
            btnBeveragesCategoryAdd.Name = "btnBeveragesCategoryAdd";
            btnBeveragesCategoryAdd.Size = new Size(227, 51);
            btnBeveragesCategoryAdd.TabIndex = 2;
            btnBeveragesCategoryAdd.Text = "İçecek Kategori Ekle";
            btnBeveragesCategoryAdd.UseVisualStyleBackColor = true;
            btnBeveragesCategoryAdd.Click += btnBeveragesCategoryAdd_Click;
            // 
            // dgvBeveragesCategory
            // 
            dgvBeveragesCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeveragesCategory.Location = new Point(280, 40);
            dgvBeveragesCategory.Margin = new Padding(3, 4, 3, 4);
            dgvBeveragesCategory.Name = "dgvBeveragesCategory";
            dgvBeveragesCategory.RowHeadersWidth = 51;
            dgvBeveragesCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeveragesCategory.Size = new Size(630, 420);
            dgvBeveragesCategory.TabIndex = 1;
            dgvBeveragesCategory.CellClick += dgvBeveragesCategory_CellClick;
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
            // BeverageCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(gBoxFoodCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BeverageCategoryPanel";
            Text = "BevereagesCategoryPanel";
            Load += BevereagesCategoryPanel_Load;
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
        private TextBox txtBeverageCategoryName;
        private Label lblBeverageCategory;
    }
}