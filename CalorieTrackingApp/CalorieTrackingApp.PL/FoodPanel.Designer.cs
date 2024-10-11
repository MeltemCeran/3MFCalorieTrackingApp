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
            btnFoodUpdate = new Button();
            btnFoodDelete = new Button();
            btnFoodAdd = new Button();
            lblAdminName = new Label();
            dgvFood = new DataGridView();
            btnFoodCategoryAdd = new Button();
            grpbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // grpbFood
            // 
            grpbFood.Controls.Add(btnFoodCategoryAdd);
            grpbFood.Controls.Add(btnFoodUpdate);
            grpbFood.Controls.Add(btnFoodDelete);
            grpbFood.Controls.Add(btnFoodAdd);
            grpbFood.Controls.Add(lblAdminName);
            grpbFood.Controls.Add(dgvFood);
            grpbFood.Location = new Point(12, 12);
            grpbFood.Name = "grpbFood";
            grpbFood.Size = new Size(932, 655);
            grpbFood.TabIndex = 2;
            grpbFood.TabStop = false;
            // 
            // btnFoodUpdate
            // 
            btnFoodUpdate.Location = new Point(724, 513);
            btnFoodUpdate.Name = "btnFoodUpdate";
            btnFoodUpdate.Size = new Size(189, 29);
            btnFoodUpdate.TabIndex = 4;
            btnFoodUpdate.Text = "Yemek Güncelle";
            btnFoodUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.Location = new Point(602, 513);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(105, 29);
            btnFoodDelete.TabIndex = 3;
            btnFoodDelete.Text = "Yemek Sil";
            btnFoodDelete.UseVisualStyleBackColor = true;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.Location = new Point(471, 513);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(105, 29);
            btnFoodAdd.TabIndex = 2;
            btnFoodAdd.Text = "Yemek Ekle";
            btnFoodAdd.UseVisualStyleBackColor = true;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(6, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(79, 20);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "Merhaba : ";
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(280, 37);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new Size(633, 420);
            dgvFood.TabIndex = 0;
            // 
            // btnFoodCategoryAdd
            // 
            btnFoodCategoryAdd.Location = new Point(247, 513);
            btnFoodCategoryAdd.Name = "btnFoodCategoryAdd";
            btnFoodCategoryAdd.Size = new Size(199, 29);
            btnFoodCategoryAdd.TabIndex = 5;
            btnFoodCategoryAdd.Text = "Yemek Kategorisi Ekle";
            btnFoodCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 676);
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
    }
}