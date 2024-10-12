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
            comboBox1 = new ComboBox();
            txtBeveragePortion = new TextBox();
            txtBeverageCalorie = new TextBox();
            txtBeverageName = new TextBox();
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
            grpbBeverage.Controls.Add(comboBox1);
            grpbBeverage.Controls.Add(txtBeveragePortion);
            grpbBeverage.Controls.Add(txtBeverageCalorie);
            grpbBeverage.Controls.Add(txtBeverageName);
            grpbBeverage.Controls.Add(btnBeverageCategoryAdd);
            grpbBeverage.Controls.Add(btnBeverageUpdate);
            grpbBeverage.Controls.Add(btnBeverageDelete);
            grpbBeverage.Controls.Add(btnBeverageAdd);
            grpbBeverage.Controls.Add(lblAdminName);
            grpbBeverage.Controls.Add(dgvBeverage);
            grpbBeverage.Location = new Point(12, 12);
            grpbBeverage.Name = "grpbBeverage";
            grpbBeverage.Size = new Size(932, 528);
            grpbBeverage.TabIndex = 3;
            grpbBeverage.TabStop = false;
            grpbBeverage.Enter += grpbBeverage_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 9;
            // 
            // txtBeveragePortion
            // 
            txtBeveragePortion.BorderStyle = BorderStyle.FixedSingle;
            txtBeveragePortion.Location = new Point(22, 172);
            txtBeveragePortion.Name = "txtBeveragePortion";
            txtBeveragePortion.PlaceholderText = " İçecek Porsiyon";
            txtBeveragePortion.Size = new Size(227, 27);
            txtBeveragePortion.TabIndex = 8;
            // 
            // txtBeverageCalorie
            // 
            txtBeverageCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageCalorie.Location = new Point(22, 124);
            txtBeverageCalorie.Name = "txtBeverageCalorie";
            txtBeverageCalorie.PlaceholderText = " İçecek Kalori";
            txtBeverageCalorie.Size = new Size(227, 27);
            txtBeverageCalorie.TabIndex = 7;
            // 
            // txtBeverageName
            // 
            txtBeverageName.BorderStyle = BorderStyle.FixedSingle;
            txtBeverageName.Location = new Point(22, 76);
            txtBeverageName.Name = "txtBeverageName";
            txtBeverageName.PlaceholderText = " İçecek Adı";
            txtBeverageName.Size = new Size(227, 27);
            txtBeverageName.TabIndex = 6;
            // 
            // btnBeverageCategoryAdd
            // 
            btnBeverageCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnBeverageCategoryAdd.Location = new Point(22, 366);
            btnBeverageCategoryAdd.Name = "btnBeverageCategoryAdd";
            btnBeverageCategoryAdd.Size = new Size(227, 50);
            btnBeverageCategoryAdd.TabIndex = 5;
            btnBeverageCategoryAdd.Text = "İçecek Kategorisi Ekle";
            btnBeverageCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // btnBeverageUpdate
            // 
            btnBeverageUpdate.FlatStyle = FlatStyle.Flat;
            btnBeverageUpdate.Location = new Point(22, 308);
            btnBeverageUpdate.Name = "btnBeverageUpdate";
            btnBeverageUpdate.Size = new Size(227, 50);
            btnBeverageUpdate.TabIndex = 4;
            btnBeverageUpdate.Text = "İçecek Güncelle";
            btnBeverageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBeverageDelete
            // 
            btnBeverageDelete.BackColor = Color.Red;
            btnBeverageDelete.FlatStyle = FlatStyle.Flat;
            btnBeverageDelete.Location = new Point(144, 254);
            btnBeverageDelete.Name = "btnBeverageDelete";
            btnBeverageDelete.Size = new Size(105, 50);
            btnBeverageDelete.TabIndex = 3;
            btnBeverageDelete.Text = "İçecek Sil";
            btnBeverageDelete.UseVisualStyleBackColor = false;
            // 
            // btnBeverageAdd
            // 
            btnBeverageAdd.BackColor = Color.LightGreen;
            btnBeverageAdd.FlatStyle = FlatStyle.Flat;
            btnBeverageAdd.Location = new Point(22, 254);
            btnBeverageAdd.Name = "btnBeverageAdd";
            btnBeverageAdd.Size = new Size(105, 50);
            btnBeverageAdd.TabIndex = 2;
            btnBeverageAdd.Text = "İçecek Ekle";
            btnBeverageAdd.UseVisualStyleBackColor = false;
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
            // dgvBeverage
            // 
            dgvBeverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeverage.Location = new Point(280, 40);
            dgvBeverage.Name = "dgvBeverage";
            dgvBeverage.RowHeadersWidth = 51;
            dgvBeverage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeverage.Size = new Size(630, 420);
            dgvBeverage.TabIndex = 0;
            // 
            // BeveragePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
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
        private TextBox txtBeverageName;
        private TextBox txtBeverageCalorie;
        private TextBox txtBeveragePortion;
        private ComboBox comboBox1;
    }
}