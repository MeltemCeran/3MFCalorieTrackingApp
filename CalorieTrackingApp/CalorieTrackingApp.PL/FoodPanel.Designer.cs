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
            txtFoodCategoryId = new TextBox();
            lblFood = new Label();
            txtFoodPortionId = new TextBox();
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
            grpbFood.Controls.Add(txtFoodCategoryId);
            grpbFood.Controls.Add(lblFood);
            grpbFood.Controls.Add(txtFoodPortionId);
            grpbFood.Controls.Add(txtFoodCalorie);
            grpbFood.Controls.Add(txtFoodName);
            grpbFood.Controls.Add(btnFoodCategoryAdd);
            grpbFood.Controls.Add(btnFoodUpdate);
            grpbFood.Controls.Add(btnFoodDelete);
            grpbFood.Controls.Add(btnFoodAdd);
            grpbFood.Controls.Add(lblAdminName);
            grpbFood.Controls.Add(dgvFood);
            grpbFood.Location = new Point(11, 12);
            grpbFood.Name = "grpbFood";
            grpbFood.Size = new Size(933, 528);
            grpbFood.TabIndex = 2;
            grpbFood.TabStop = false;
            // 
            // txtFoodCategoryId
            // 
            txtFoodCategoryId.Location = new Point(21, 216);
            txtFoodCategoryId.Margin = new Padding(3, 4, 3, 4);
            txtFoodCategoryId.Name = "txtFoodCategoryId";
            txtFoodCategoryId.PlaceholderText = "Yemek Kategori Id";
            txtFoodCategoryId.Size = new Size(228, 27);
            txtFoodCategoryId.TabIndex = 10;
            // 
            // lblFood
            // 
            lblFood.FlatStyle = FlatStyle.Flat;
            lblFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFood.Location = new Point(22, 479);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(888, 31);
            lblFood.TabIndex = 9;
            lblFood.Text = "Durum:";
            lblFood.Visible = false;
            // 
            // txtFoodPortionId
            // 
            txtFoodPortionId.BorderStyle = BorderStyle.FixedSingle;
            txtFoodPortionId.Location = new Point(22, 172);
            txtFoodPortionId.Name = "txtFoodPortionId";
            txtFoodPortionId.PlaceholderText = " Yemek Porsiyon Id";
            txtFoodPortionId.Size = new Size(227, 27);
            txtFoodPortionId.TabIndex = 8;
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
            btnFoodCategoryAdd.Location = new Point(22, 365);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(227, 51);
            btnFoodCategoryAdd.TabIndex = 5;
            btnFoodCategoryAdd.Text = "Yemek Kategorisi Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            btnFoodCategoryAdd.Click += btnFoodCategoryAdd_Click;
            // 
            // btnFoodUpdate
            // 
            btnFoodUpdate.FlatStyle = FlatStyle.Flat;
            btnFoodUpdate.Location = new Point(22, 308);
            btnFoodUpdate.Name = "btnFoodUpdate";
            btnFoodUpdate.Size = new Size(227, 51);
            btnFoodUpdate.TabIndex = 4;
            btnFoodUpdate.Text = "Yemek Güncelle";
            btnFoodUpdate.UseVisualStyleBackColor = true;
            btnFoodUpdate.Click += btnFoodUpdate_Click;
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.FlatStyle = FlatStyle.Flat;
            btnFoodDelete.Location = new Point(144, 253);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(105, 51);
            btnFoodDelete.TabIndex = 3;
            btnFoodDelete.Text = "Yemek Sil";
            btnFoodDelete.UseVisualStyleBackColor = true;
            btnFoodDelete.Click += btnFoodDelete_Click;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.FlatStyle = FlatStyle.Flat;
            btnFoodAdd.Location = new Point(22, 253);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(105, 51);
            btnFoodAdd.TabIndex = 2;
            btnFoodAdd.Text = "Yemek Ekle";
            btnFoodAdd.UseVisualStyleBackColor = true;
            btnFoodAdd.Click += btnFoodAdd_Click;
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
            dgvFood.CellClick += dgvFood_CellClick;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpbFood);
            Name = "FoodPanel";
            Text = "FoodPanel";
            Load += FoodPanel_Load;
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
        private TextBox txtFoodPortionId;
        private Label lblFood;
        private TextBox txtFoodCategoryId;
    }
}