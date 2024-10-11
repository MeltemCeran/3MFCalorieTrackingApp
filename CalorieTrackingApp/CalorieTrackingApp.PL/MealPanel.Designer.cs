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
            dgvMeal.Location = new Point(261, 26);
            dgvMeal.Name = "dgvMeal";
            dgvMeal.RowHeadersWidth = 51;
            dgvMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeal.Size = new Size(610, 420);
            dgvMeal.TabIndex = 0;
            // 
            // grpbMeal
            // 
            grpbMeal.Controls.Add(btnMealUpdate);
            grpbMeal.Controls.Add(btnMealDelete);
            grpbMeal.Controls.Add(btnMealAdd);
            grpbMeal.Controls.Add(lblAdminName);
            grpbMeal.Controls.Add(dgvMeal);
            grpbMeal.Location = new Point(12, 12);
            grpbMeal.Name = "grpbMeal";
            grpbMeal.Size = new Size(890, 655);
            grpbMeal.TabIndex = 1;
            grpbMeal.TabStop = false;
            // 
            // btnMealUpdate
            // 
            btnMealUpdate.Location = new Point(685, 465);
            btnMealUpdate.Name = "btnMealUpdate";
            btnMealUpdate.Size = new Size(189, 44);
            btnMealUpdate.TabIndex = 4;
            btnMealUpdate.Text = "Öğün Güncelle";
            btnMealUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMealDelete
            // 
            btnMealDelete.Location = new Point(480, 465);
            btnMealDelete.Name = "btnMealDelete";
            btnMealDelete.Size = new Size(105, 44);
            btnMealDelete.TabIndex = 3;
            btnMealDelete.Text = "Öğün Sil";
            btnMealDelete.UseVisualStyleBackColor = true;
            // 
            // btnMealAdd
            // 
            btnMealAdd.Location = new Point(261, 465);
            btnMealAdd.Name = "btnMealAdd";
            btnMealAdd.Size = new Size(105, 44);
            btnMealAdd.TabIndex = 2;
            btnMealAdd.Text = "Öğün Ekle";
            btnMealAdd.UseVisualStyleBackColor = true;
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
            // MealPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 679);
            Controls.Add(grpbMeal);
            Name = "MealPanel";
            Text = "Öğünler";
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
    }
}