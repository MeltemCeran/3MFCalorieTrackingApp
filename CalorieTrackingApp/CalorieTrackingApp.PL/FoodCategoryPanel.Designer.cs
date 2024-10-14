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
            lblDurum = new Label();
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
            gBoxFoodCategory.Controls.Add(lblDurum);
            gBoxFoodCategory.Controls.Add(txtFoodCategoryName);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnFoodCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvFoodCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(10, 9);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Size = new Size(816, 396);
            gBoxFoodCategory.TabIndex = 0;
            gBoxFoodCategory.TabStop = false;
            // 
            // lblDurum
            // 
            lblDurum.FlatStyle = FlatStyle.Flat;
            lblDurum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.Location = new Point(19, 279);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(194, 114);
            lblDurum.TabIndex = 6;
            lblDurum.Text = "Durum:";
            // 
            // txtFoodCategoryName
            // 
            txtFoodCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtFoodCategoryName.Location = new Point(14, 101);
            txtFoodCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtFoodCategoryName.Name = "txtFoodCategoryName";
            txtFoodCategoryName.PlaceholderText = " Yemek Kategori Adı";
            txtFoodCategoryName.Size = new Size(199, 23);
            txtFoodCategoryName.TabIndex = 5;
            // 
            // btnFoodCategoryUpdate
            // 
            btnFoodCategoryUpdate.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryUpdate.Location = new Point(14, 220);
            btnFoodCategoryUpdate.Name = "btnFoodCategoryUpdate";
            btnFoodCategoryUpdate.Size = new Size(199, 38);
            btnFoodCategoryUpdate.TabIndex = 4;
            btnFoodCategoryUpdate.Text = "Yemek Kategori Güncelle";
            btnFoodCategoryUpdate.UseVisualStyleBackColor = true;
            btnFoodCategoryUpdate.Click += btnFoodCategoryUpdate_Click;
            // 
            // btnFoodCategoryDelete
            // 
            btnFoodCategoryDelete.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryDelete.Location = new Point(14, 176);
            btnFoodCategoryDelete.Name = "btnFoodCategoryDelete";
            btnFoodCategoryDelete.Size = new Size(199, 38);
            btnFoodCategoryDelete.TabIndex = 3;
            btnFoodCategoryDelete.Text = "Yemek Kategori Sil";
            btnFoodCategoryDelete.UseVisualStyleBackColor = true;
            btnFoodCategoryDelete.Click += btnFoodCategoryDelete_Click;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryAdd.Location = new Point(14, 133);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(199, 38);
            btnFoodCategoryAdd.TabIndex = 2;
            btnFoodCategoryAdd.Text = "Yemek Kategori Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            btnFoodCategoryAdd.Click += btnFoodCategoryAdd_Click;
            // 
            // dgvFoodCategory
            // 
            dgvFoodCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodCategory.Location = new Point(245, 30);
            dgvFoodCategory.Name = "dgvFoodCategory";
            dgvFoodCategory.RowHeadersWidth = 51;
            dgvFoodCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodCategory.Size = new Size(551, 315);
            dgvFoodCategory.TabIndex = 1;
            dgvFoodCategory.CellClick += dgvFoodCategory_CellClick;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(5, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(57, 15);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Merhaba:";
            // 
            // FoodCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(gBoxFoodCategory);
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
        private Label lblDurum;
    }
}