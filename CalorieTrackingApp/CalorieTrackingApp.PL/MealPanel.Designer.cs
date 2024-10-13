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
            lblMealMessage = new Label();
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
            dgvMeal.Location = new Point(245, 30);
            dgvMeal.Margin = new Padding(3, 2, 3, 2);
            dgvMeal.Name = "dgvMeal";
            dgvMeal.RowHeadersWidth = 51;
            dgvMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeal.Size = new Size(551, 315);
            dgvMeal.TabIndex = 0;
            dgvMeal.CellClick += dgvMeal_CellClick;
            // 
            // grpbMeal
            // 
            grpbMeal.Controls.Add(lblMealMessage);
            grpbMeal.Controls.Add(txtMealName);
            grpbMeal.Controls.Add(btnMealUpdate);
            grpbMeal.Controls.Add(btnMealDelete);
            grpbMeal.Controls.Add(btnMealAdd);
            grpbMeal.Controls.Add(lblAdminName);
            grpbMeal.Controls.Add(dgvMeal);
            grpbMeal.Location = new Point(10, 9);
            grpbMeal.Margin = new Padding(3, 2, 3, 2);
            grpbMeal.Name = "grpbMeal";
            grpbMeal.Padding = new Padding(3, 2, 3, 2);
            grpbMeal.Size = new Size(816, 396);
            grpbMeal.TabIndex = 1;
            grpbMeal.TabStop = false;
            // 
            // lblMealMessage
            // 
            lblMealMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMealMessage.Location = new Point(14, 267);
            lblMealMessage.Name = "lblMealMessage";
            lblMealMessage.Size = new Size(199, 55);
            lblMealMessage.TabIndex = 6;
            lblMealMessage.Text = "Durum :";
            lblMealMessage.Visible = false;
            // 
            // txtMealName
            // 
            txtMealName.BorderStyle = BorderStyle.FixedSingle;
            txtMealName.Location = new Point(14, 101);
            txtMealName.Margin = new Padding(3, 2, 3, 2);
            txtMealName.Name = "txtMealName";
            txtMealName.PlaceholderText = " Öğün Adı";
            txtMealName.Size = new Size(199, 23);
            txtMealName.TabIndex = 5;
            // 
            // btnMealUpdate
            // 
            btnMealUpdate.FlatStyle = FlatStyle.Flat;
            btnMealUpdate.Location = new Point(14, 217);
            btnMealUpdate.Margin = new Padding(3, 2, 3, 2);
            btnMealUpdate.Name = "btnMealUpdate";
            btnMealUpdate.Size = new Size(199, 38);
            btnMealUpdate.TabIndex = 4;
            btnMealUpdate.Text = "Öğün Güncelle";
            btnMealUpdate.UseVisualStyleBackColor = true;
            btnMealUpdate.Click += btnMealUpdate_Click;
            // 
            // btnMealDelete
            // 
            btnMealDelete.FlatStyle = FlatStyle.Flat;
            btnMealDelete.Location = new Point(14, 175);
            btnMealDelete.Margin = new Padding(3, 2, 3, 2);
            btnMealDelete.Name = "btnMealDelete";
            btnMealDelete.Size = new Size(199, 38);
            btnMealDelete.TabIndex = 3;
            btnMealDelete.Text = "Öğün Sil";
            btnMealDelete.UseVisualStyleBackColor = true;
            btnMealDelete.Click += btnMealDelete_Click;
            // 
            // btnMealAdd
            // 
            btnMealAdd.FlatStyle = FlatStyle.Flat;
            btnMealAdd.Location = new Point(14, 133);
            btnMealAdd.Margin = new Padding(3, 2, 3, 2);
            btnMealAdd.Name = "btnMealAdd";
            btnMealAdd.Size = new Size(199, 38);
            btnMealAdd.TabIndex = 2;
            btnMealAdd.Text = "Öğün Ekle";
            btnMealAdd.UseVisualStyleBackColor = true;
            btnMealAdd.Click += btnMealAdd_Click;
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
            // MealPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(grpbMeal);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblMealMessage;
    }
}