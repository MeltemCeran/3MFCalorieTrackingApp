namespace CalorieTrackingApp.PL
{
    partial class MealPanel
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
            dgvMeal = new DataGridView();
            grpbMeal = new GroupBox();
            lblMeal = new Label();
            txtMealName = new TextBox();
            btnMealUpdate = new Button();
            btnMealDelete = new Button();
            btnMealAdd = new Button();
            lblAdminName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeal).BeginInit();
            grpbMeal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMeal
            // 
            dgvMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeal.Location = new Point(280, 40);
            dgvMeal.Name = "dgvMeal";
            dgvMeal.RowHeadersWidth = 51;
            dgvMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeal.Size = new Size(630, 420);
            dgvMeal.TabIndex = 0;
            dgvMeal.CellClick += dgvMeal_CellClick;
            // 
            // grpbMeal
            // 
            grpbMeal.Controls.Add(lblMeal);
            grpbMeal.Controls.Add(txtMealName);
            grpbMeal.Controls.Add(btnMealUpdate);
            grpbMeal.Controls.Add(btnMealDelete);
            grpbMeal.Controls.Add(btnMealAdd);
            grpbMeal.Controls.Add(lblAdminName);
            grpbMeal.Controls.Add(dgvMeal);
            grpbMeal.Location = new Point(11, 12);
            grpbMeal.Name = "grpbMeal";
            grpbMeal.Size = new Size(933, 528);
            grpbMeal.TabIndex = 1;
            grpbMeal.TabStop = false;
            // 
            // lblMeal
            // 
            lblMeal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMeal.Location = new Point(16, 356);
            lblMeal.Name = "lblMeal";
            lblMeal.Size = new Size(227, 73);
            lblMeal.TabIndex = 6;
            lblMeal.Text = "Durum :";
            lblMeal.Visible = false;
            // 
            // txtMealName
            // 
            txtMealName.BorderStyle = BorderStyle.FixedSingle;
            txtMealName.Location = new Point(16, 135);
            txtMealName.Name = "txtMealName";
            txtMealName.PlaceholderText = " Öğün Adı";
            txtMealName.Size = new Size(227, 27);
            txtMealName.TabIndex = 5;
            // 
            // btnMealUpdate
            // 
            btnMealUpdate.FlatStyle = FlatStyle.Flat;
            btnMealUpdate.Location = new Point(16, 289);
            btnMealUpdate.Name = "btnMealUpdate";
            btnMealUpdate.Size = new Size(227, 51);
            btnMealUpdate.TabIndex = 4;
            btnMealUpdate.Text = "Öğün Güncelle";
            btnMealUpdate.UseVisualStyleBackColor = true;
            btnMealUpdate.Click += btnMealUpdate_Click;
            // 
            // btnMealDelete
            // 
            btnMealDelete.FlatStyle = FlatStyle.Flat;
            btnMealDelete.Location = new Point(16, 233);
            btnMealDelete.Name = "btnMealDelete";
            btnMealDelete.Size = new Size(227, 51);
            btnMealDelete.TabIndex = 3;
            btnMealDelete.Text = "Öğün Sil";
            btnMealDelete.UseVisualStyleBackColor = true;
            btnMealDelete.Click += btnMealDelete_Click;
            // 
            // btnMealAdd
            // 
            btnMealAdd.FlatStyle = FlatStyle.Flat;
            btnMealAdd.Location = new Point(16, 177);
            btnMealAdd.Name = "btnMealAdd";
            btnMealAdd.Size = new Size(227, 51);
            btnMealAdd.TabIndex = 2;
            btnMealAdd.Text = "Öğün Ekle";
            btnMealAdd.UseVisualStyleBackColor = true;
            btnMealAdd.Click += btnMealAdd_Click;
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
            // MealPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpbMeal);
            Name = "MealPanel";
            Text = "Öğünler";
            Load += MealPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeal).EndInit();
            grpbMeal.ResumeLayout(false);
            grpbMeal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMeal;
        private GroupBox grpbMeal;
        private Label lblAdminName;
        private Button btnMealAdd;
        private Button btnMealUpdate;
        private Button btnMealDelete;
        private TextBox txtMealName;
        private Label lblMeal;
    }
}