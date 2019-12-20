namespace DeveloverWarehouse
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.laberrorLogin = new Develover.GUI.Controls.DeveloverLabelControlError();
            this.butLogin = new Develover.GUI.Controls.DeveloverSimpleButton();
            this.likForgetPassword = new Develover.GUI.Controls.DeveloverHyperlinkLabelControl();
            this.chkGhiNhoDangNhap = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labPassWord = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtUserName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.txtPassWord = new Develover.GUI.Controls.DeveloverTextEditPassword();
            this.labUserName = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNhoDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laberrorLogin
            // 
            this.laberrorLogin.Location = new System.Drawing.Point(36, 69);
            this.laberrorLogin.Name = "laberrorLogin";
            this.laberrorLogin.Size = new System.Drawing.Size(0, 13);
            this.laberrorLogin.TabIndex = 5;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(301, 19);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(70, 46);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Đăng nhâp";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // likForgetPassword
            // 
            this.likForgetPassword.Location = new System.Drawing.Point(217, 89);
            this.likForgetPassword.Name = "likForgetPassword";
            this.likForgetPassword.Size = new System.Drawing.Size(78, 13);
            this.likForgetPassword.TabIndex = 4;
            this.likForgetPassword.Text = "Quên mật khẩu?";
            // 
            // chkGhiNhoDangNhap
            // 
            this.chkGhiNhoDangNhap.Location = new System.Drawing.Point(36, 88);
            this.chkGhiNhoDangNhap.Name = "chkGhiNhoDangNhap";
            this.chkGhiNhoDangNhap.Properties.Caption = "Ghi nhớ đăng nhập?";
            this.chkGhiNhoDangNhap.Size = new System.Drawing.Size(158, 20);
            this.chkGhiNhoDangNhap.TabIndex = 3;
            // 
            // labPassWord
            // 
            this.labPassWord.Location = new System.Drawing.Point(36, 48);
            this.labPassWord.Name = "labPassWord";
            this.labPassWord.Size = new System.Drawing.Size(44, 13);
            this.labPassWord.TabIndex = 4;
            this.labPassWord.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(137, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(137, 45);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(158, 20);
            this.txtPassWord.TabIndex = 1;
            // 
            // labUserName
            // 
            this.labUserName.Location = new System.Drawing.Point(36, 24);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(72, 13);
            this.labUserName.TabIndex = 3;
            this.labUserName.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.laberrorLogin);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.likForgetPassword);
            this.Controls.Add(this.chkGhiNhoDangNhap);
            this.Controls.Add(this.labPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.labUserName);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNhoDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labUserName;
        private Develover.GUI.Controls.DeveloverTextEditPassword txtPassWord;
        private Develover.GUI.Controls.DeveloverTextEdit txtUserName;
        private Develover.GUI.Controls.DeveloverLabelControl labPassWord;
        private Develover.GUI.Controls.DeveloverCheckEdit chkGhiNhoDangNhap;
        private Develover.GUI.Controls.DeveloverHyperlinkLabelControl likForgetPassword;
        private Develover.GUI.Controls.DeveloverSimpleButton butLogin;
        private Develover.GUI.Controls.DeveloverLabelControlError laberrorLogin;
    }
}