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
            lblBeverageMessage = new Label();
            txtBeverageCatogoryName = new TextBox();
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
            gBoxFoodCategory.Controls.Add(lblBeverageMessage);
            gBoxFoodCategory.Controls.Add(txtBeverageCatogoryName);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryUpdate);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryDelete);
            gBoxFoodCategory.Controls.Add(btnBeveragesCategoryAdd);
            gBoxFoodCategory.Controls.Add(dgvBeveragesCategory);
            gBoxFoodCategory.Controls.Add(lblAdminName);
            gBoxFoodCategory.Location = new Point(10, 9);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Size = new Size(816, 396);
            gBoxFoodCategory.TabIndex = 1;
            gBoxFoodCategory.TabStop = false;
            // 
            // lblBeverageMessage
            // 
            lblBeverageMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBeverageMessage.Location = new Point(14, 269);
            lblBeverageMessage.Name = "lblBeverageMessage";
            lblBeverageMessage.Size = new Size(133, 52);
            lblBeverageMessage.TabIndex = 6;
            lblBeverageMessage.Text = "Durum:";
            lblBeverageMessage.Visible = false;
            // 
            // txtBeverageCatogoryName
            // 
            txtBeverageCatogoryName.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageCatogoryName.Location = new Point(14, 101);
            txtBeverageCatogoryName.Margin = new Padding(3, 2, 3, 2);
            txtBeverageCatogoryName.Name = "txtBeverageCatogoryName";
            txtBeverageCatogoryName.PlaceholderText = " İçecek Kategori Adı";
            txtBeverageCatogoryName.Size = new Size(199, 23);
            txtBeverageCatogoryName.TabIndex = 5;
            // 
            // btnBeveragesCategoryUpdate
            // 
            btnBeveragesCategoryUpdate.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryUpdate.Location = new Point(14, 223);
            btnBeveragesCategoryUpdate.Name = "btnBeveragesCategoryUpdate";
            btnBeveragesCategoryUpdate.Size = new Size(199, 38);
            btnBeveragesCategoryUpdate.TabIndex = 4;
            btnBeveragesCategoryUpdate.Text = "İçecek Kategori Güncelle";
            btnBeveragesCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBeveragesCategoryDelete
            // 
            btnBeveragesCategoryDelete.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryDelete.Location = new Point(14, 179);
            btnBeveragesCategoryDelete.Name = "btnBeveragesCategoryDelete";
            btnBeveragesCategoryDelete.Size = new Size(199, 38);
            btnBeveragesCategoryDelete.TabIndex = 3;
            btnBeveragesCategoryDelete.Text = "İçecek Kategori Sil";
            btnBeveragesCategoryDelete.UseVisualStyleBackColor = true;
            btnBeveragesCategoryDelete.Click += btnBeveragesCategoryDelete_Click;
            // 
            // btnBeveragesCategoryAdd
            // 
            btnBeveragesCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnBeveragesCategoryAdd.Location = new Point(14, 136);
            btnBeveragesCategoryAdd.Name = "btnBeveragesCategoryAdd";
            btnBeveragesCategoryAdd.Size = new Size(199, 38);
            btnBeveragesCategoryAdd.TabIndex = 2;
            btnBeveragesCategoryAdd.Text = "İçecek Kategori Ekle";
            btnBeveragesCategoryAdd.UseVisualStyleBackColor = true;
            btnBeveragesCategoryAdd.Click += btnBeveragesCategoryAdd_Click;
            // 
            // dgvBeveragesCategory
            // 
            dgvBeveragesCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeveragesCategory.Location = new Point(245, 30);
            dgvBeveragesCategory.Name = "dgvBeveragesCategory";
            dgvBeveragesCategory.RowHeadersWidth = 51;
            dgvBeveragesCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeveragesCategory.Size = new Size(551, 315);
            dgvBeveragesCategory.TabIndex = 1;
            dgvBeveragesCategory.CellClick += dgvBeveragesCategory_CellClick;
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
            // BeverageCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(gBoxFoodCategory);
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
        private TextBox txtBeverageCatogoryName;
        private Label lblBeverageMessage;
    }
}