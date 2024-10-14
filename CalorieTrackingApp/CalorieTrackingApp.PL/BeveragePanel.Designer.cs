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
            txtBeverageCategoryId = new TextBox();
            lblBeverage = new Label();
            txtBeveragePortionId = new TextBox();
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
            grpbBeverage.Controls.Add(txtBeverageCategoryId);
            grpbBeverage.Controls.Add(lblBeverage);
            grpbBeverage.Controls.Add(txtBeveragePortionId);
            grpbBeverage.Controls.Add(txtBeverageCalorie);
            grpbBeverage.Controls.Add(txtBeverageName);
            grpbBeverage.Controls.Add(btnBeverageCategoryAdd);
            grpbBeverage.Controls.Add(btnBeverageUpdate);
            grpbBeverage.Controls.Add(btnBeverageDelete);
            grpbBeverage.Controls.Add(btnBeverageAdd);
            grpbBeverage.Controls.Add(lblAdminName);
            grpbBeverage.Controls.Add(dgvBeverage);
            grpbBeverage.Location = new Point(11, 12);
            grpbBeverage.Name = "grpbBeverage";
            grpbBeverage.Size = new Size(933, 528);
            grpbBeverage.TabIndex = 3;
            grpbBeverage.TabStop = false;
            // 
            // txtBeverageCategoryId
            // 
            txtBeverageCategoryId.Location = new Point(22, 213);
            txtBeverageCategoryId.Margin = new Padding(3, 4, 3, 4);
            txtBeverageCategoryId.Name = "txtBeverageCategoryId";
            txtBeverageCategoryId.PlaceholderText = "İçecek Kategori Id";
            txtBeverageCategoryId.Size = new Size(227, 27);
            txtBeverageCategoryId.TabIndex = 11;
            // 
            // lblBeverage
            // 
            lblBeverage.FlatStyle = FlatStyle.Flat;
            lblBeverage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBeverage.Location = new Point(22, 476);
            lblBeverage.Name = "lblBeverage";
            lblBeverage.Size = new Size(888, 37);
            lblBeverage.TabIndex = 10;
            lblBeverage.Text = "Durum:";
            // 
            // txtBeveragePortionId
            // 
            txtBeveragePortionId.BorderStyle = BorderStyle.FixedSingle;
            txtBeveragePortionId.Location = new Point(22, 172);
            txtBeveragePortionId.Name = "txtBeveragePortionId";
            txtBeveragePortionId.PlaceholderText = " İçecek Porsiyon Id";
            txtBeveragePortionId.Size = new Size(227, 27);
            txtBeveragePortionId.TabIndex = 8;
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
            btnBeverageCategoryAdd.Location = new Point(22, 365);
            btnBeverageCategoryAdd.Name = "btnBeverageCategoryAdd";
            btnBeverageCategoryAdd.Size = new Size(227, 51);
            btnBeverageCategoryAdd.TabIndex = 5;
            btnBeverageCategoryAdd.Text = "İçecek Kategorisi Ekle";
            btnBeverageCategoryAdd.UseVisualStyleBackColor = true;
            btnBeverageCategoryAdd.Click += btnBeverageCategoryAdd_Click;
            // 
            // btnBeverageUpdate
            // 
            btnBeverageUpdate.FlatStyle = FlatStyle.Flat;
            btnBeverageUpdate.Location = new Point(22, 308);
            btnBeverageUpdate.Name = "btnBeverageUpdate";
            btnBeverageUpdate.Size = new Size(227, 51);
            btnBeverageUpdate.TabIndex = 4;
            btnBeverageUpdate.Text = "İçecek Güncelle";
            btnBeverageUpdate.UseVisualStyleBackColor = true;
            btnBeverageUpdate.Click += btnBeverageUpdate_Click;
            // 
            // btnBeverageDelete
            // 
            btnBeverageDelete.BackColor = Color.Red;
            btnBeverageDelete.FlatStyle = FlatStyle.Flat;
            btnBeverageDelete.Location = new Point(144, 253);
            btnBeverageDelete.Name = "btnBeverageDelete";
            btnBeverageDelete.Size = new Size(105, 51);
            btnBeverageDelete.TabIndex = 3;
            btnBeverageDelete.Text = "İçecek Sil";
            btnBeverageDelete.UseVisualStyleBackColor = false;
            btnBeverageDelete.Click += btnBeverageDelete_Click;
            // 
            // btnBeverageAdd
            // 
            btnBeverageAdd.BackColor = Color.LightGreen;
            btnBeverageAdd.FlatStyle = FlatStyle.Flat;
            btnBeverageAdd.Location = new Point(22, 253);
            btnBeverageAdd.Name = "btnBeverageAdd";
            btnBeverageAdd.Size = new Size(105, 51);
            btnBeverageAdd.TabIndex = 2;
            btnBeverageAdd.Text = "İçecek Ekle";
            btnBeverageAdd.UseVisualStyleBackColor = false;
            btnBeverageAdd.Click += btnBeverageAdd_Click;
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
            dgvBeverage.CellClick += dgvBeverage_CellClick;
            // 
            // BeveragePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpbBeverage);
            Name = "BeveragePanel";
            Text = "BeveragePanel";
            Load += BeveragePanel_Load;
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
        private TextBox txtBeverageName;
        private TextBox txtBeverageCalorie;
        private TextBox txtBeveragePortionId;
        private Label lblBeverage;
        private TextBox txtBeverageCategoryId;
        private DataGridView dgvBeverage;
    }
}