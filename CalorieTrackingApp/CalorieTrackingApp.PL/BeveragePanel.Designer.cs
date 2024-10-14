namespace CalorieTrackingApp.PL
{
    partial class BeveragePanel
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
            grpbBeverage = new GroupBox();
            lblBeverageCategory = new Label();
            txtBeveragePortion = new TextBox();
            txtBeverageCalorie = new TextBox();
            txtBeverageName = new TextBox();
            btnBeverageCategoryAdd = new Button();
            btnBeverageUpdate = new Button();
            btnBeverageDelete = new Button();
            btnBeverageAdd = new Button();
            lblAdminName = new Label();
            dgvBeverage = new DataGridView();
            txtBeverageCategory = new TextBox();
            grpbBeverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeverage).BeginInit();
            SuspendLayout();
            // 
            // grpbBeverage
            // 
            grpbBeverage.Controls.Add(txtBeverageCategory);
            grpbBeverage.Controls.Add(lblBeverageCategory);
            grpbBeverage.Controls.Add(txtBeveragePortion);
            grpbBeverage.Controls.Add(txtBeverageCalorie);
            grpbBeverage.Controls.Add(txtBeverageName);
            grpbBeverage.Controls.Add(btnBeverageCategoryAdd);
            grpbBeverage.Controls.Add(btnBeverageUpdate);
            grpbBeverage.Controls.Add(btnBeverageDelete);
            grpbBeverage.Controls.Add(btnBeverageAdd);
            grpbBeverage.Controls.Add(lblAdminName);
            grpbBeverage.Controls.Add(dgvBeverage);
            grpbBeverage.Location = new Point(10, 9);
            grpbBeverage.Margin = new Padding(3, 2, 3, 2);
            grpbBeverage.Name = "grpbBeverage";
            grpbBeverage.Padding = new Padding(3, 2, 3, 2);
            grpbBeverage.Size = new Size(816, 396);
            grpbBeverage.TabIndex = 3;
            grpbBeverage.TabStop = false;
            
            // 
            // lblBeverageCategory
            // 
            lblBeverageCategory.FlatStyle = FlatStyle.Flat;
            lblBeverageCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBeverageCategory.Location = new Point(19, 357);
            lblBeverageCategory.Name = "lblBeverageCategory";
            lblBeverageCategory.Size = new Size(777, 28);
            lblBeverageCategory.TabIndex = 10;
            lblBeverageCategory.Text = "Durum:";
            // 
            // txtBeveragePortion
            // 
            txtBeveragePortion.BorderStyle = BorderStyle.FixedSingle;
            txtBeveragePortion.Location = new Point(19, 129);
            txtBeveragePortion.Margin = new Padding(3, 2, 3, 2);
            txtBeveragePortion.Name = "txtBeveragePortion";
            txtBeveragePortion.PlaceholderText = " İçecek Porsiyon";
            txtBeveragePortion.Size = new Size(199, 23);
            txtBeveragePortion.TabIndex = 8;
            // 
            // txtBeverageCalorie
            // 
            txtBeverageCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageCalorie.Location = new Point(19, 93);
            txtBeverageCalorie.Margin = new Padding(3, 2, 3, 2);
            txtBeverageCalorie.Name = "txtBeverageCalorie";
            txtBeverageCalorie.PlaceholderText = " İçecek Kalori";
            txtBeverageCalorie.Size = new Size(199, 23);
            txtBeverageCalorie.TabIndex = 7;
            // 
            // txtBeverageName
            // 
            txtBeverageName.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageName.Location = new Point(19, 57);
            txtBeverageName.Margin = new Padding(3, 2, 3, 2);
            txtBeverageName.Name = "txtBeverageName";
            txtBeverageName.PlaceholderText = " İçecek Adı";
            txtBeverageName.Size = new Size(199, 23);
            txtBeverageName.TabIndex = 6;
            // 
            // btnBeverageCategoryAdd
            // 
            btnBeverageCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnBeverageCategoryAdd.Location = new Point(19, 274);
            btnBeverageCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            btnBeverageCategoryAdd.Name = "btnBeverageCategoryAdd";
            btnBeverageCategoryAdd.Size = new Size(199, 38);
            btnBeverageCategoryAdd.TabIndex = 5;
            btnBeverageCategoryAdd.Text = "İçecek Kategorisi Ekle";
            btnBeverageCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // btnBeverageUpdate
            // 
            btnBeverageUpdate.FlatStyle = FlatStyle.Flat;
            btnBeverageUpdate.Location = new Point(19, 231);
            btnBeverageUpdate.Margin = new Padding(3, 2, 3, 2);
            btnBeverageUpdate.Name = "btnBeverageUpdate";
            btnBeverageUpdate.Size = new Size(199, 38);
            btnBeverageUpdate.TabIndex = 4;
            btnBeverageUpdate.Text = "İçecek Güncelle";
            btnBeverageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBeverageDelete
            // 
            btnBeverageDelete.BackColor = Color.Red;
            btnBeverageDelete.FlatStyle = FlatStyle.Flat;
            btnBeverageDelete.Location = new Point(126, 190);
            btnBeverageDelete.Margin = new Padding(3, 2, 3, 2);
            btnBeverageDelete.Name = "btnBeverageDelete";
            btnBeverageDelete.Size = new Size(92, 38);
            btnBeverageDelete.TabIndex = 3;
            btnBeverageDelete.Text = "İçecek Sil";
            btnBeverageDelete.UseVisualStyleBackColor = false;
            // 
            // btnBeverageAdd
            // 
            btnBeverageAdd.BackColor = Color.LightGreen;
            btnBeverageAdd.FlatStyle = FlatStyle.Flat;
            btnBeverageAdd.Location = new Point(19, 190);
            btnBeverageAdd.Margin = new Padding(3, 2, 3, 2);
            btnBeverageAdd.Name = "btnBeverageAdd";
            btnBeverageAdd.Size = new Size(92, 38);
            btnBeverageAdd.TabIndex = 2;
            btnBeverageAdd.Text = "İçecek Ekle";
            btnBeverageAdd.UseVisualStyleBackColor = false;
            btnBeverageAdd.Click += btnBeverageAdd_Click;
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
            // dgvBeverage
            // 
            dgvBeverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeverage.Location = new Point(245, 30);
            dgvBeverage.Margin = new Padding(3, 2, 3, 2);
            dgvBeverage.Name = "dgvBeverage";
            dgvBeverage.RowHeadersWidth = 51;
            dgvBeverage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeverage.Size = new Size(551, 315);
            dgvBeverage.TabIndex = 0;
            // 
            // txtBeverageCategory
            // 
            txtBeverageCategory.Location = new Point(19, 160);
            txtBeverageCategory.Name = "txtBeverageCategory";
            txtBeverageCategory.PlaceholderText = "İçecek Kategori";
            txtBeverageCategory.Size = new Size(199, 23);
            txtBeverageCategory.TabIndex = 11;
            // 
            // BeveragePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(grpbBeverage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BeveragePanel";
            Text = "BeveragePanel";
            grpbBeverage.ResumeLayout(false);
            grpbBeverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeverage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbBeverage;
        private Button btnBeverageCategoryAdd;
        private Button btnBeverageUpdate;
        private Button btnBeverageDelete;
        private Button btnBeverageAdd;
        private Label lblAdminName;
        private DataGridView dgvBeverage;
        private TextBox txtBeverageName;
        private TextBox txtBeverageCalorie;
        private TextBox txtBeveragePortion;
        private Label lblBeverageCategory;
        private TextBox txtBeverageCategory;
    }
}