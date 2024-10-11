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
            btnBeverageCategoryAdd = new Button();
            btnBeverageUpdate = new Button();
            btnBeverageDelete = new Button();
            btnBeverageAdd = new Button();
            lblAdminName = new Label();
            dgvBeverage = new DataGridView();
            grpbBeverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeverage).BeginInit();
            SuspendLayout();
            // 
            // grpbBeverage
            // 
            grpbBeverage.Controls.Add(btnBeverageCategoryAdd);
            grpbBeverage.Controls.Add(btnBeverageUpdate);
            grpbBeverage.Controls.Add(btnBeverageDelete);
            grpbBeverage.Controls.Add(btnBeverageAdd);
            grpbBeverage.Controls.Add(lblAdminName);
            grpbBeverage.Controls.Add(dgvBeverage);
            grpbBeverage.Location = new Point(12, 12);
            grpbBeverage.Name = "grpbBeverage";
            grpbBeverage.Size = new Size(932, 655);
            grpbBeverage.TabIndex = 3;
            grpbBeverage.TabStop = false;
            // 
            // btnBeverageCategoryAdd
            // 
            btnBeverageCategoryAdd.Location = new Point(247, 513);
            btnBeverageCategoryAdd.Name = "btnBeverageCategoryAdd";
            btnBeverageCategoryAdd.Size = new Size(199, 29);
            btnBeverageCategoryAdd.TabIndex = 5;
            btnBeverageCategoryAdd.Text = "İçecek Kategorisi Ekle";
            btnBeverageCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // btnBeverageUpdate
            // 
            btnBeverageUpdate.Location = new Point(724, 513);
            btnBeverageUpdate.Name = "btnBeverageUpdate";
            btnBeverageUpdate.Size = new Size(189, 29);
            btnBeverageUpdate.TabIndex = 4;
            btnBeverageUpdate.Text = "İçecek Güncelle";
            btnBeverageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBeverageDelete
            // 
            btnBeverageDelete.Location = new Point(602, 513);
            btnBeverageDelete.Name = "btnBeverageDelete";
            btnBeverageDelete.Size = new Size(105, 29);
            btnBeverageDelete.TabIndex = 3;
            btnBeverageDelete.Text = "İçecek Sil";
            btnBeverageDelete.UseVisualStyleBackColor = true;
            // 
            // btnBeverageAdd
            // 
            btnBeverageAdd.Location = new Point(471, 513);
            btnBeverageAdd.Name = "btnBeverageAdd";
            btnBeverageAdd.Size = new Size(105, 29);
            btnBeverageAdd.TabIndex = 2;
            btnBeverageAdd.Text = "İçecek Ekle";
            btnBeverageAdd.UseVisualStyleBackColor = true;
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
            // dgvBeverage
            // 
            dgvBeverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeverage.Location = new Point(280, 37);
            dgvBeverage.Name = "dgvBeverage";
            dgvBeverage.RowHeadersWidth = 51;
            dgvBeverage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeverage.Size = new Size(633, 420);
            dgvBeverage.TabIndex = 0;
            // 
            // BeveragePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 681);
            Controls.Add(grpbBeverage);
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
    }
}