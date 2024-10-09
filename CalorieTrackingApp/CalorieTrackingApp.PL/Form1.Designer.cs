namespace CalorieTrackingApp.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNextToLogin = new Button();
            gBoxStartScreen = new GroupBox();
            gBoxLogin = new GroupBox();
            btnForgotPassword = new Button();
            btnCreateAccount = new Button();
            btnSignIn = new Button();
            ckBoxRemember = new CheckBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdmin = new Button();
            gBoxSignIn = new GroupBox();
            txtPasswordAgain = new TextBox();
            lblPasswordAgain = new Label();
            txtUserPassword = new TextBox();
            lblUserPassword = new Label();
            txtUserEmail = new TextBox();
            lblUserEmail = new Label();
            button2 = new Button();
            lblUserSurname = new Label();
            lblUserName = new Label();
            txtUserSurname = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            gBoxStartScreen.SuspendLayout();
            gBoxLogin.SuspendLayout();
            gBoxSignIn.SuspendLayout();
            SuspendLayout();
            // 
            // btnNextToLogin
            // 
            btnNextToLogin.BackColor = Color.PaleGreen;
            btnNextToLogin.BackgroundImage = (Image)resources.GetObject("btnNextToLogin.BackgroundImage");
            btnNextToLogin.Font = new Font("Rockwell Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextToLogin.ForeColor = Color.DarkGreen;
            btnNextToLogin.Location = new Point(239, 421);
            btnNextToLogin.Name = "btnNextToLogin";
            btnNextToLogin.Size = new Size(85, 39);
            btnNextToLogin.TabIndex = 1;
            btnNextToLogin.Text = "NEXT";
            btnNextToLogin.UseVisualStyleBackColor = false;
            btnNextToLogin.Click += btnNextToSignIn_Click;
            // 
            // gBoxStartScreen
            // 
            gBoxStartScreen.BackgroundImage = Properties.Resources.Yeşil_Organik_Sağlıklı_Besin_Bilgilendirici_Instagram_Hikayesi;
            gBoxStartScreen.BackgroundImageLayout = ImageLayout.Stretch;
            gBoxStartScreen.Controls.Add(btnNextToLogin);
            gBoxStartScreen.Font = new Font("Rockwell Nova", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gBoxStartScreen.ForeColor = Color.ForestGreen;
            gBoxStartScreen.Location = new Point(26, 12);
            gBoxStartScreen.Name = "gBoxStartScreen";
            gBoxStartScreen.Size = new Size(324, 485);
            gBoxStartScreen.TabIndex = 3;
            gBoxStartScreen.TabStop = false;
            gBoxStartScreen.Text = "Track Your Day!";
            // 
            // gBoxLogin
            // 
            gBoxLogin.Controls.Add(btnForgotPassword);
            gBoxLogin.Controls.Add(btnCreateAccount);
            gBoxLogin.Controls.Add(btnSignIn);
            gBoxLogin.Controls.Add(ckBoxRemember);
            gBoxLogin.Controls.Add(lblPassword);
            gBoxLogin.Controls.Add(lblEmail);
            gBoxLogin.Controls.Add(txtPassword);
            gBoxLogin.Controls.Add(txtEmail);
            gBoxLogin.Controls.Add(label2);
            gBoxLogin.Controls.Add(label1);
            gBoxLogin.Controls.Add(btnAdmin);
            gBoxLogin.Location = new Point(356, 400);
            gBoxLogin.Name = "gBoxLogin";
            gBoxLogin.Size = new Size(282, 382);
            gBoxLogin.TabIndex = 4;
            gBoxLogin.TabStop = false;
            gBoxLogin.Text = "Giriş";
            gBoxLogin.Visible = false;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(43, 283);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(108, 23);
            btnForgotPassword.TabIndex = 12;
            btnForgotPassword.Text = "Şifremi Unuttum";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(48, 341);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(206, 23);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "ÜYELİK OLUŞTUR";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(48, 312);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(206, 23);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "OTURUM AÇ";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // ckBoxRemember
            // 
            ckBoxRemember.AutoSize = true;
            ckBoxRemember.Location = new Point(44, 258);
            ckBoxRemember.Name = "ckBoxRemember";
            ckBoxRemember.Size = new Size(90, 19);
            ckBoxRemember.TabIndex = 9;
            ckBoxRemember.Text = "Beni Hatırla!";
            ckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(44, 211);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Location = new Point(43, 90);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 4;
            label2.Text = "Uygulamamıza hoşgeldiniz";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(43, 64);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "LOGO";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(201, 35);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(75, 23);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // gBoxSignIn
            // 
            gBoxSignIn.Controls.Add(txtPasswordAgain);
            gBoxSignIn.Controls.Add(lblPasswordAgain);
            gBoxSignIn.Controls.Add(txtUserPassword);
            gBoxSignIn.Controls.Add(lblUserPassword);
            gBoxSignIn.Controls.Add(txtUserEmail);
            gBoxSignIn.Controls.Add(lblUserEmail);
            gBoxSignIn.Controls.Add(button2);
            gBoxSignIn.Controls.Add(lblUserSurname);
            gBoxSignIn.Controls.Add(lblUserName);
            gBoxSignIn.Controls.Add(txtUserSurname);
            gBoxSignIn.Controls.Add(txtUserName);
            gBoxSignIn.Controls.Add(label5);
            gBoxSignIn.Controls.Add(label6);
            gBoxSignIn.Location = new Point(356, 12);
            gBoxSignIn.Name = "gBoxSignIn";
            gBoxSignIn.Size = new Size(282, 382);
            gBoxSignIn.TabIndex = 13;
            gBoxSignIn.TabStop = false;
            gBoxSignIn.Text = "Üyelik Oluştur";
            gBoxSignIn.Visible = false;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(39, 293);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(211, 23);
            txtPasswordAgain.TabIndex = 18;
            // 
            // lblPasswordAgain
            // 
            lblPasswordAgain.AutoSize = true;
            lblPasswordAgain.Location = new Point(39, 275);
            lblPasswordAgain.Name = "lblPasswordAgain";
            lblPasswordAgain.Size = new Size(64, 15);
            lblPasswordAgain.TabIndex = 17;
            lblPasswordAgain.Text = "Şifre Tekrar";
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(39, 249);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(211, 23);
            txtUserPassword.TabIndex = 16;
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Location = new Point(39, 231);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(30, 15);
            lblUserPassword.TabIndex = 15;
            lblUserPassword.Text = "Şifre";
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(39, 205);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(211, 23);
            txtUserEmail.TabIndex = 14;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(39, 186);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(36, 15);
            lblUserEmail.TabIndex = 13;
            lblUserEmail.Text = "Email";
            // 
            // button2
            // 
            button2.Location = new Point(39, 324);
            button2.Name = "button2";
            button2.Size = new Size(206, 23);
            button2.TabIndex = 11;
            button2.Text = "Hesabımı Oluştur";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblUserSurname
            // 
            lblUserSurname.AutoSize = true;
            lblUserSurname.Location = new Point(39, 141);
            lblUserSurname.Name = "lblUserSurname";
            lblUserSurname.Size = new Size(57, 15);
            lblUserSurname.TabIndex = 8;
            lblUserSurname.Text = "Soyadınız";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(39, 97);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(40, 15);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Adınız";
            // 
            // txtUserSurname
            // 
            txtUserSurname.Location = new Point(39, 159);
            txtUserSurname.Name = "txtUserSurname";
            txtUserSurname.Size = new Size(211, 23);
            txtUserSurname.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(39, 115);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(211, 23);
            txtUserName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Location = new Point(39, 65);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 4;
            label5.Text = "Hesabını Oluşturalım";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Location = new Point(39, 39);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 3;
            label6.Text = "LOGO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 788);
            Controls.Add(gBoxLogin);
            Controls.Add(gBoxSignIn);
            Controls.Add(gBoxStartScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            gBoxStartScreen.ResumeLayout(false);
            gBoxLogin.ResumeLayout(false);
            gBoxLogin.PerformLayout();
            gBoxSignIn.ResumeLayout(false);
            gBoxSignIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNextToLogin;
        private GroupBox gBoxStartScreen;
        private GroupBox gBoxLogin;
        private Label label2;
        private Label label1;
        private Button btnAdmin;
        private Button btnCreateAccount;
        private Button btnSignIn;
        private CheckBox ckBoxRemember;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnForgotPassword;
        private GroupBox gBoxSignIn;
        private Button button2;
        private Label lblUserSurname;
        private Label lblUserName;
        private TextBox txtUserSurname;
        private TextBox txtUserName;
        private Label label5;
        private Label label6;
        private TextBox txtPasswordAgain;
        private Label lblPasswordAgain;
        private TextBox txtUserPassword;
        private Label lblUserPassword;
        private TextBox txtUserEmail;
        private Label lblUserEmail;
    }
}
