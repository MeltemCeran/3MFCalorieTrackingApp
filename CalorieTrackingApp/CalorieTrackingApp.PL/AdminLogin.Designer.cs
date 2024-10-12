namespace CalorieTrackingApp.PL
{
    partial class AdminLogin
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
            txtAdminName = new TextBox();
            txtPassword = new TextBox();
            grpbAdminLogin = new GroupBox();
            btnLogin = new Button();
            grpbAdminLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtAdminName
            // 
            txtAdminName.BorderStyle = BorderStyle.FixedSingle;
            txtAdminName.Location = new Point(35, 47);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.PlaceholderText = " Kullanıcı Adı";
            txtAdminName.Size = new Size(227, 27);
            txtAdminName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(35, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Şifre";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 2;
            // 
            // grpbAdminLogin
            // 
            grpbAdminLogin.Controls.Add(btnLogin);
            grpbAdminLogin.Controls.Add(txtAdminName);
            grpbAdminLogin.Controls.Add(txtPassword);
            grpbAdminLogin.Location = new Point(342, 138);
            grpbAdminLogin.Name = "grpbAdminLogin";
            grpbAdminLogin.Size = new Size(298, 213);
            grpbAdminLogin.TabIndex = 3;
            grpbAdminLogin.TabStop = false;
            grpbAdminLogin.Text = "Admin Giriş";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(35, 133);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(227, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpbAdminLogin);
            Name = "AdminLogin";
            Text = "AdminLogin";
            grpbAdminLogin.ResumeLayout(false);
            grpbAdminLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtAdminName;
        private TextBox txtPassword;
        private GroupBox grpbAdminLogin;
        private Button btnLogin;
    }
}