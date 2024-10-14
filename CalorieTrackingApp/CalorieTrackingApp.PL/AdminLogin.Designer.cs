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
            txtAdminPassword = new TextBox();
            grpbAdminLogin = new GroupBox();
            btnLogin = new Button();
            grpbAdminLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtAdminName
            // 
            txtAdminName.BorderStyle = BorderStyle.FixedSingle;
            txtAdminName.Location = new Point(31, 35);
            txtAdminName.Margin = new Padding(3, 2, 3, 2);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.PlaceholderText = " Kullanıcı Adı";
            txtAdminName.Size = new Size(199, 23);
            txtAdminName.TabIndex = 1;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPassword.Location = new Point(31, 68);
            txtAdminPassword.Margin = new Padding(3, 2, 3, 2);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.PlaceholderText = " Şifre";
            txtAdminPassword.Size = new Size(199, 23);
            txtAdminPassword.TabIndex = 2;
            // 
            // grpbAdminLogin
            // 
            grpbAdminLogin.Controls.Add(btnLogin);
            grpbAdminLogin.Controls.Add(txtAdminName);
            grpbAdminLogin.Controls.Add(txtAdminPassword);
            grpbAdminLogin.Location = new Point(299, 104);
            grpbAdminLogin.Margin = new Padding(3, 2, 3, 2);
            grpbAdminLogin.Name = "grpbAdminLogin";
            grpbAdminLogin.Padding = new Padding(3, 2, 3, 2);
            grpbAdminLogin.Size = new Size(261, 160);
            grpbAdminLogin.TabIndex = 3;
            grpbAdminLogin.TabStop = false;
            grpbAdminLogin.Text = "Admin Giriş";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(31, 100);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 38);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(grpbAdminLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminLogin";
            Text = "AdminLogin";
            grpbAdminLogin.ResumeLayout(false);
            grpbAdminLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtAdminName;
        private TextBox txtAdminPassword;
        private GroupBox grpbAdminLogin;
        private Button btnLogin;
    }
}