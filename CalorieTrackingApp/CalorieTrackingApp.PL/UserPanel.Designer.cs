namespace CalorieTrackingApp.PL
{
    partial class UserPanel
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
            grpbUserPanel = new GroupBox();
            groupBox2 = new GroupBox();
            cmbBeveragePortion = new ComboBox();
            groupBox1 = new GroupBox();
            cmbFoodPortion = new ComboBox();
            btnUpdate = new Button();
            btnDeleteUserPanel = new Button();
            btnAddFood = new Button();
            btnMonthlyRecord = new Button();
            btnWeeklyRecord = new Button();
            btnDailyRecord = new Button();
            dtpUserPanel = new DateTimePicker();
            grpbBeverageAdd = new GroupBox();
            cmbBeverageAddUserPanel = new ComboBox();
            grpbFoodAdd = new GroupBox();
            cmbFoodAddUserPanel = new ComboBox();
            grpbBeverageCategoryAdd = new GroupBox();
            cmbBeverageCategoryAddUserPanel = new ComboBox();
            grpbFoodCategoryAdd = new GroupBox();
            cmbFoodCategoryAddUserPanel = new ComboBox();
            grpbMealAdd = new GroupBox();
            cmbMealAddUserPanel = new ComboBox();
            lblUserName = new Label();
            dgvUserRecord = new DataGridView();
            grpbUserPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            grpbBeverageAdd.SuspendLayout();
            grpbFoodAdd.SuspendLayout();
            grpbBeverageCategoryAdd.SuspendLayout();
            grpbFoodCategoryAdd.SuspendLayout();
            grpbMealAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRecord).BeginInit();
            SuspendLayout();
            // 
            // grpbUserPanel
            // 
            grpbUserPanel.Controls.Add(groupBox2);
            grpbUserPanel.Controls.Add(groupBox1);
            grpbUserPanel.Controls.Add(btnUpdate);
            grpbUserPanel.Controls.Add(btnDeleteUserPanel);
            grpbUserPanel.Controls.Add(btnAddFood);
            grpbUserPanel.Controls.Add(btnMonthlyRecord);
            grpbUserPanel.Controls.Add(btnWeeklyRecord);
            grpbUserPanel.Controls.Add(btnDailyRecord);
            grpbUserPanel.Controls.Add(dtpUserPanel);
            grpbUserPanel.Controls.Add(grpbBeverageAdd);
            grpbUserPanel.Controls.Add(grpbFoodAdd);
            grpbUserPanel.Controls.Add(grpbBeverageCategoryAdd);
            grpbUserPanel.Controls.Add(grpbFoodCategoryAdd);
            grpbUserPanel.Controls.Add(grpbMealAdd);
            grpbUserPanel.Controls.Add(lblUserName);
            grpbUserPanel.Controls.Add(dgvUserRecord);
            grpbUserPanel.Location = new Point(10, 9);
            grpbUserPanel.Margin = new Padding(3, 2, 3, 2);
            grpbUserPanel.Name = "grpbUserPanel";
            grpbUserPanel.Padding = new Padding(3, 2, 3, 2);
            grpbUserPanel.Size = new Size(816, 454);
            grpbUserPanel.TabIndex = 0;
            grpbUserPanel.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbBeveragePortion);
            groupBox2.Location = new Point(664, 241);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(115, 47);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Porsiyon";
            // 
            // cmbBeveragePortion
            // 
            cmbBeveragePortion.FormattingEnabled = true;
            cmbBeveragePortion.Location = new Point(10, 20);
            cmbBeveragePortion.Margin = new Padding(3, 2, 3, 2);
            cmbBeveragePortion.Name = "cmbBeveragePortion";
            cmbBeveragePortion.Size = new Size(99, 23);
            cmbBeveragePortion.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbFoodPortion);
            groupBox1.Location = new Point(670, 71);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(115, 47);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porsiyon";
            // 
            // cmbFoodPortion
            // 
            cmbFoodPortion.FormattingEnabled = true;
            cmbFoodPortion.Location = new Point(10, 20);
            cmbFoodPortion.Margin = new Padding(3, 2, 3, 2);
            cmbFoodPortion.Name = "cmbFoodPortion";
            cmbFoodPortion.Size = new Size(99, 23);
            cmbFoodPortion.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(545, 388);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 38);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUserPanel
            // 
            btnDeleteUserPanel.Location = new Point(424, 388);
            btnDeleteUserPanel.Margin = new Padding(3, 2, 3, 2);
            btnDeleteUserPanel.Name = "btnDeleteUserPanel";
            btnDeleteUserPanel.Size = new Size(115, 38);
            btnDeleteUserPanel.TabIndex = 19;
            btnDeleteUserPanel.Text = "Sil";
            btnDeleteUserPanel.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(566, 309);
            btnAddFood.Margin = new Padding(3, 2, 3, 2);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(155, 36);
            btnAddFood.TabIndex = 18;
            btnAddFood.Text = "Ekle";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnMonthlyRecord
            // 
            btnMonthlyRecord.Location = new Point(147, 323);
            btnMonthlyRecord.Margin = new Padding(3, 2, 3, 2);
            btnMonthlyRecord.Name = "btnMonthlyRecord";
            btnMonthlyRecord.Size = new Size(115, 38);
            btnMonthlyRecord.TabIndex = 16;
            btnMonthlyRecord.Text = "Aylık Rapor";
            btnMonthlyRecord.UseVisualStyleBackColor = true;
            // 
            // btnWeeklyRecord
            // 
            btnWeeklyRecord.Location = new Point(213, 281);
            btnWeeklyRecord.Margin = new Padding(3, 2, 3, 2);
            btnWeeklyRecord.Name = "btnWeeklyRecord";
            btnWeeklyRecord.Size = new Size(115, 38);
            btnWeeklyRecord.TabIndex = 15;
            btnWeeklyRecord.Text = "Haftalık Rapor";
            btnWeeklyRecord.UseVisualStyleBackColor = true;
            // 
            // btnDailyRecord
            // 
            btnDailyRecord.Location = new Point(78, 281);
            btnDailyRecord.Margin = new Padding(3, 2, 3, 2);
            btnDailyRecord.Name = "btnDailyRecord";
            btnDailyRecord.Size = new Size(115, 38);
            btnDailyRecord.TabIndex = 14;
            btnDailyRecord.Text = "Günlük Rapor";
            btnDailyRecord.UseVisualStyleBackColor = true;
            // 
            // dtpUserPanel
            // 
            dtpUserPanel.Format = DateTimePickerFormat.Short;
            dtpUserPanel.Location = new Point(16, 37);
            dtpUserPanel.Margin = new Padding(3, 2, 3, 2);
            dtpUserPanel.Name = "dtpUserPanel";
            dtpUserPanel.Size = new Size(156, 23);
            dtpUserPanel.TabIndex = 1;
            dtpUserPanel.ValueChanged += dtpUserPanel_ValueChanged;
            // 
            // grpbBeverageAdd
            // 
            grpbBeverageAdd.Controls.Add(cmbBeverageAddUserPanel);
            grpbBeverageAdd.Location = new Point(424, 241);
            grpbBeverageAdd.Margin = new Padding(3, 2, 3, 2);
            grpbBeverageAdd.Name = "grpbBeverageAdd";
            grpbBeverageAdd.Padding = new Padding(3, 2, 3, 2);
            grpbBeverageAdd.Size = new Size(204, 47);
            grpbBeverageAdd.TabIndex = 11;
            grpbBeverageAdd.TabStop = false;
            grpbBeverageAdd.Text = "İçecek Ekle";
            // 
            // cmbBeverageAddUserPanel
            // 
            cmbBeverageAddUserPanel.FormattingEnabled = true;
            cmbBeverageAddUserPanel.Location = new Point(10, 20);
            cmbBeverageAddUserPanel.Margin = new Padding(3, 2, 3, 2);
            cmbBeverageAddUserPanel.Name = "cmbBeverageAddUserPanel";
            cmbBeverageAddUserPanel.Size = new Size(190, 23);
            cmbBeverageAddUserPanel.TabIndex = 1;
            // 
            // grpbFoodAdd
            // 
            grpbFoodAdd.Controls.Add(cmbFoodAddUserPanel);
            grpbFoodAdd.Location = new Point(424, 71);
            grpbFoodAdd.Margin = new Padding(3, 2, 3, 2);
            grpbFoodAdd.Name = "grpbFoodAdd";
            grpbFoodAdd.Padding = new Padding(3, 2, 3, 2);
            grpbFoodAdd.Size = new Size(204, 47);
            grpbFoodAdd.TabIndex = 8;
            grpbFoodAdd.TabStop = false;
            grpbFoodAdd.Text = "Yemek Seçiniz";
            // 
            // cmbFoodAddUserPanel
            // 
            cmbFoodAddUserPanel.FormattingEnabled = true;
            cmbFoodAddUserPanel.Location = new Point(10, 20);
            cmbFoodAddUserPanel.Margin = new Padding(3, 2, 3, 2);
            cmbFoodAddUserPanel.Name = "cmbFoodAddUserPanel";
            cmbFoodAddUserPanel.Size = new Size(190, 23);
            cmbFoodAddUserPanel.TabIndex = 4;
            // 
            // grpbBeverageCategoryAdd
            // 
            grpbBeverageCategoryAdd.Controls.Add(cmbBeverageCategoryAddUserPanel);
            grpbBeverageCategoryAdd.Location = new Point(424, 190);
            grpbBeverageCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            grpbBeverageCategoryAdd.Name = "grpbBeverageCategoryAdd";
            grpbBeverageCategoryAdd.Padding = new Padding(3, 2, 3, 2);
            grpbBeverageCategoryAdd.Size = new Size(204, 47);
            grpbBeverageCategoryAdd.TabIndex = 10;
            grpbBeverageCategoryAdd.TabStop = false;
            grpbBeverageCategoryAdd.Text = "İçecek Kategori Ekle";
            // 
            // cmbBeverageCategoryAddUserPanel
            // 
            cmbBeverageCategoryAddUserPanel.FormattingEnabled = true;
            cmbBeverageCategoryAddUserPanel.Location = new Point(8, 20);
            cmbBeverageCategoryAddUserPanel.Margin = new Padding(3, 2, 3, 2);
            cmbBeverageCategoryAddUserPanel.Name = "cmbBeverageCategoryAddUserPanel";
            cmbBeverageCategoryAddUserPanel.Size = new Size(190, 23);
            cmbBeverageCategoryAddUserPanel.TabIndex = 6;
            // 
            // grpbFoodCategoryAdd
            // 
            grpbFoodCategoryAdd.Controls.Add(cmbFoodCategoryAddUserPanel);
            grpbFoodCategoryAdd.Location = new Point(424, 20);
            grpbFoodCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            grpbFoodCategoryAdd.Name = "grpbFoodCategoryAdd";
            grpbFoodCategoryAdd.Padding = new Padding(3, 2, 3, 2);
            grpbFoodCategoryAdd.Size = new Size(204, 47);
            grpbFoodCategoryAdd.TabIndex = 7;
            grpbFoodCategoryAdd.TabStop = false;
            grpbFoodCategoryAdd.Text = "Yemek Kategori Ekle";
            // 
            // cmbFoodCategoryAddUserPanel
            // 
            cmbFoodCategoryAddUserPanel.FormattingEnabled = true;
            cmbFoodCategoryAddUserPanel.Location = new Point(10, 20);
            cmbFoodCategoryAddUserPanel.Margin = new Padding(3, 2, 3, 2);
            cmbFoodCategoryAddUserPanel.Name = "cmbFoodCategoryAddUserPanel";
            cmbFoodCategoryAddUserPanel.Size = new Size(190, 23);
            cmbFoodCategoryAddUserPanel.TabIndex = 3;
            // 
            // grpbMealAdd
            // 
            grpbMealAdd.Controls.Add(cmbMealAddUserPanel);
            grpbMealAdd.Location = new Point(213, 20);
            grpbMealAdd.Margin = new Padding(3, 2, 3, 2);
            grpbMealAdd.Name = "grpbMealAdd";
            grpbMealAdd.Padding = new Padding(3, 2, 3, 2);
            grpbMealAdd.Size = new Size(204, 47);
            grpbMealAdd.TabIndex = 6;
            grpbMealAdd.TabStop = false;
            grpbMealAdd.Text = "Öğün Seçiniz";
            // 
            // cmbMealAddUserPanel
            // 
            cmbMealAddUserPanel.FormattingEnabled = true;
            cmbMealAddUserPanel.Location = new Point(10, 20);
            cmbMealAddUserPanel.Margin = new Padding(3, 2, 3, 2);
            cmbMealAddUserPanel.Name = "cmbMealAddUserPanel";
            cmbMealAddUserPanel.Size = new Size(190, 23);
            cmbMealAddUserPanel.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(57, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Merhaba:";
            // 
            // dgvUserRecord
            // 
            dgvUserRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRecord.Location = new Point(16, 91);
            dgvUserRecord.Margin = new Padding(3, 2, 3, 2);
            dgvUserRecord.Name = "dgvUserRecord";
            dgvUserRecord.RowHeadersWidth = 51;
            dgvUserRecord.Size = new Size(381, 146);
            dgvUserRecord.TabIndex = 0;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 472);
            Controls.Add(grpbUserPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserPanel";
            Text = "UserPanel";
            Load += UserPanel_Load;
            grpbUserPanel.ResumeLayout(false);
            grpbUserPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpbBeverageAdd.ResumeLayout(false);
            grpbFoodAdd.ResumeLayout(false);
            grpbBeverageCategoryAdd.ResumeLayout(false);
            grpbFoodCategoryAdd.ResumeLayout(false);
            grpbMealAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserRecord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbUserPanel;
        private DataGridView dgvUserRecord;
        private ComboBox cmbMealAddUserPanel;
        private Label lblMealUserPanel;
        private Label lblUserName;
        private Label lblFoodCategoryUserPanel;
        private ComboBox cmbFoodCategoryUserPanel;
        private GroupBox grpbMealAdd;
        private GroupBox grpbFoodCategoryAdd;
        private ComboBox cmbFoodCategoryAddUserPanel;
        private GroupBox grpbFoodAdd;
        private ComboBox cmbFoodAddUserPanel;
        private GroupBox grpbBeverageAdd;
        private ComboBox cmbBeverageAddUserPanel;
        private GroupBox grpbBeverageCategoryAdd;
        private ComboBox cmbBeverageCategoryAddUserPanel;
        private DateTimePicker dtpUserPanel;
        private Button btnWeeklyRecord;
        private Button btnDailyRecord;
        private Button btnMonthlyRecord;
        private Button btnUpdate;
        private Button btnDeleteUserPanel;
        private Button btnAddFood;
        private GroupBox groupBox1;
        private ComboBox cmbFoodPortion;
        private GroupBox groupBox2;
        private ComboBox cmbBeveragePortion;
    }
}