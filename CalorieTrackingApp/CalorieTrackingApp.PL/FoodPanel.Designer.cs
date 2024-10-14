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
            lblSelectedFood = new Label();
            txtFoodPortion = new TextBox();
            txtFoodCalorie = new TextBox();
            txtFoodName = new TextBox();
            btnFoodCategoryAdd = new Button();
            btnFoodUpdate = new Button();
            btnFoodDelete = new Button();
            btnFoodAdd = new Button();
            lblAdminName = new Label();
            dgvFood = new DataGridView();
            txtCategoryId = new TextBox();
            grpbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // grpbFood
            // 
            grpbFood.Controls.Add(txtCategoryId);
            grpbFood.Controls.Add(lblSelectedFood);
            grpbFood.Controls.Add(txtFoodPortion);
            grpbFood.Controls.Add(txtFoodCalorie);
            grpbFood.Controls.Add(txtFoodName);
            grpbFood.Controls.Add(btnFoodCategoryAdd);
            grpbFood.Controls.Add(btnFoodUpdate);
            grpbFood.Controls.Add(btnFoodDelete);
            grpbFood.Controls.Add(btnFoodAdd);
            grpbFood.Controls.Add(lblAdminName);
            grpbFood.Controls.Add(dgvFood);
            grpbFood.Location = new Point(10, 9);
            grpbFood.Margin = new Padding(3, 2, 3, 2);
            grpbFood.Name = "grpbFood";
            grpbFood.Padding = new Padding(3, 2, 3, 2);
            grpbFood.Size = new Size(816, 396);
            grpbFood.TabIndex = 2;
            grpbFood.TabStop = false;
            // 
            // lblSelectedFood
            // 
            lblSelectedFood.FlatStyle = FlatStyle.Flat;
            lblSelectedFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSelectedFood.Location = new Point(19, 359);
            lblSelectedFood.Name = "lblSelectedFood";
            lblSelectedFood.Size = new Size(777, 23);
            lblSelectedFood.TabIndex = 9;
            lblSelectedFood.Text = "Durum:";
            lblSelectedFood.Visible = false;
            // 
            // txtFoodPortion
            // 
            txtFoodPortion.BorderStyle = BorderStyle.FixedSingle;
            txtFoodPortion.Location = new Point(19, 129);
            txtFoodPortion.Margin = new Padding(3, 2, 3, 2);
            txtFoodPortion.Name = "txtFoodPortion";
            txtFoodPortion.PlaceholderText = " Yemek Porsiyon";
            txtFoodPortion.Size = new Size(199, 23);
            txtFoodPortion.TabIndex = 8;
            // 
            // txtFoodCalorie
            // 
            txtFoodCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtFoodCalorie.Location = new Point(19, 93);
            txtFoodCalorie.Margin = new Padding(3, 2, 3, 2);
            txtFoodCalorie.Name = "txtFoodCalorie";
            txtFoodCalorie.PlaceholderText = " Yemek Kalori";
            txtFoodCalorie.Size = new Size(199, 23);
            txtFoodCalorie.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.BorderStyle = BorderStyle.FixedSingle;
            txtFoodName.Location = new Point(19, 57);
            txtFoodName.Margin = new Padding(3, 2, 3, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = " Yemek Adı";
            txtFoodName.Size = new Size(199, 23);
            txtFoodName.TabIndex = 6;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnFoodCategoryAdd.Location = new Point(19, 274);
            btnFoodCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(199, 38);
            btnFoodCategoryAdd.TabIndex = 5;
            btnFoodCategoryAdd.Text = "Yemek Kategorisi Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            btnFoodCategoryAdd.Click += btnFoodCategoryAdd_Click;
            // 
            // btnFoodUpdate
            // 
            btnFoodUpdate.FlatStyle = FlatStyle.Flat;
            btnFoodUpdate.Location = new Point(19, 231);
            btnFoodUpdate.Margin = new Padding(3, 2, 3, 2);
            btnFoodUpdate.Name = "btnFoodUpdate";
            btnFoodUpdate.Size = new Size(199, 38);
            btnFoodUpdate.TabIndex = 4;
            btnFoodUpdate.Text = "Yemek Güncelle";
            btnFoodUpdate.UseVisualStyleBackColor = true;
            btnFoodUpdate.Click += btnFoodUpdate_Click;
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.FlatStyle = FlatStyle.Flat;
            btnFoodDelete.Location = new Point(126, 190);
            btnFoodDelete.Margin = new Padding(3, 2, 3, 2);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(92, 38);
            btnFoodDelete.TabIndex = 3;
            btnFoodDelete.Text = "Yemek Sil";
            btnFoodDelete.UseVisualStyleBackColor = true;
            btnFoodDelete.Click += btnFoodDelete_Click;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.FlatStyle = FlatStyle.Flat;
            btnFoodAdd.Location = new Point(19, 190);
            btnFoodAdd.Margin = new Padding(3, 2, 3, 2);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(92, 38);
            btnFoodAdd.TabIndex = 2;
            btnFoodAdd.Text = "Yemek Ekle";
            btnFoodAdd.UseVisualStyleBackColor = true;
            btnFoodAdd.Click += btnFoodAdd_Click;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(5, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(60, 15);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "Merhaba: ";
            // 
            // dgvFood
            // 
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(245, 30);
            dgvFood.Margin = new Padding(3, 2, 3, 2);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new Size(551, 315);
            dgvFood.TabIndex = 0;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(18, 162);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.PlaceholderText = "Yemek Kategori Id";
            txtCategoryId.Size = new Size(200, 23);
            txtCategoryId.TabIndex = 10;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(grpbFood);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtFoodPortion;
        private Label lblSelectedFood;
        private TextBox txtCategoryId;
    }
}