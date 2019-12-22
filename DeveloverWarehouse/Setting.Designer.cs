namespace DeveloverWarehouse
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.tnpSetting = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpCustomer = new Develover.GUI.Controls.DeveloverTabNavigationPage();
            this.tnpSystem = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.develoverGroupControl1 = new Develover.GUI.Controls.DeveloverGroupControl();
            this.laberror = new Develover.GUI.Controls.DeveloverLabelControlError();
            this.labServerName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtDatabaseName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labUserSQL = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtServerName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labPasswordSQL = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labDatabaseName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtPassWord = new Develover.GUI.Controls.DeveloverTextEditPassword();
            this.txtUserName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.butLogin = new Develover.GUI.Controls.DeveloverSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tnpSetting)).BeginInit();
            this.tnpSetting.SuspendLayout();
            this.tnpSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGroupControl1)).BeginInit();
            this.develoverGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tnpSetting
            // 
            this.tnpSetting.Controls.Add(this.tnpCustomer);
            this.tnpSetting.Controls.Add(this.tnpSystem);
            this.tnpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tnpSetting.Location = new System.Drawing.Point(0, 0);
            this.tnpSetting.Name = "tnpSetting";
            this.tnpSetting.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpSystem,
            this.tnpCustomer});
            this.tnpSetting.RegularSize = new System.Drawing.Size(630, 282);
            this.tnpSetting.SelectedPage = this.tnpCustomer;
            this.tnpSetting.Size = new System.Drawing.Size(630, 282);
            this.tnpSetting.TabIndex = 7;
            this.tnpSetting.Text = "Cài đặt";
            // 
            // tnpCustomer
            // 
            this.tnpCustomer.Caption = "Người dùng";
            this.tnpCustomer.Name = "tnpCustomer";
            this.tnpCustomer.Size = new System.Drawing.Size(630, 253);
            // 
            // tnpSystem
            // 
            this.tnpSystem.Caption = "Hệ thống";
            this.tnpSystem.Controls.Add(this.develoverGroupControl1);
            this.tnpSystem.InvertTouchScroll = true;
            this.tnpSystem.Name = "tnpSystem";
            this.tnpSystem.Size = new System.Drawing.Size(630, 253);
            // 
            // develoverGroupControl1
            // 
            this.develoverGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.develoverGroupControl1.Controls.Add(this.laberror);
            this.develoverGroupControl1.Controls.Add(this.labServerName);
            this.develoverGroupControl1.Controls.Add(this.txtDatabaseName);
            this.develoverGroupControl1.Controls.Add(this.labUserSQL);
            this.develoverGroupControl1.Controls.Add(this.txtServerName);
            this.develoverGroupControl1.Controls.Add(this.labPasswordSQL);
            this.develoverGroupControl1.Controls.Add(this.labDatabaseName);
            this.develoverGroupControl1.Controls.Add(this.txtPassWord);
            this.develoverGroupControl1.Controls.Add(this.txtUserName);
            this.develoverGroupControl1.Controls.Add(this.butLogin);
            this.develoverGroupControl1.Location = new System.Drawing.Point(149, 31);
            this.develoverGroupControl1.Name = "develoverGroupControl1";
            this.develoverGroupControl1.Size = new System.Drawing.Size(354, 161);
            this.develoverGroupControl1.TabIndex = 7;
            this.develoverGroupControl1.Text = "Cấu hình SQL";
            // 
            // laberror
            // 
            this.laberror.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.laberror.Location = new System.Drawing.Point(7, 128);
            this.laberror.Name = "laberror";
            this.laberror.Size = new System.Drawing.Size(259, 29);
            this.laberror.TabIndex = 5;
            // 
            // labServerName
            // 
            this.labServerName.Location = new System.Drawing.Point(7, 37);
            this.labServerName.Name = "labServerName";
            this.labServerName.Size = new System.Drawing.Size(40, 13);
            this.labServerName.TabIndex = 3;
            this.labServerName.Text = "Máy chủ";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(108, 103);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(158, 20);
            this.txtDatabaseName.TabIndex = 6;
            // 
            // labUserSQL
            // 
            this.labUserSQL.Location = new System.Drawing.Point(7, 59);
            this.labUserSQL.Name = "labUserSQL";
            this.labUserSQL.Size = new System.Drawing.Size(46, 13);
            this.labUserSQL.TabIndex = 4;
            this.labUserSQL.Text = "Tài khoản";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(108, 34);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServerName.Size = new System.Drawing.Size(158, 20);
            this.txtServerName.TabIndex = 5;
            // 
            // labPasswordSQL
            // 
            this.labPasswordSQL.Location = new System.Drawing.Point(7, 81);
            this.labPasswordSQL.Name = "labPasswordSQL";
            this.labPasswordSQL.Size = new System.Drawing.Size(44, 13);
            this.labPasswordSQL.TabIndex = 4;
            this.labPasswordSQL.Text = "Mật khẩu";
            // 
            // labDatabaseName
            // 
            this.labDatabaseName.Location = new System.Drawing.Point(7, 103);
            this.labDatabaseName.Name = "labDatabaseName";
            this.labDatabaseName.Size = new System.Drawing.Size(62, 13);
            this.labDatabaseName.TabIndex = 4;
            this.labDatabaseName.Text = "Cơ sở dữ liệu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(108, 80);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(158, 20);
            this.txtPassWord.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(108, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(272, 32);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(70, 46);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Đăng nhâp";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 282);
            this.Controls.Add(this.tnpSetting);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Setting.IconOptions.Image")));
            this.KeyPreview = true;
            this.Name = "Setting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt hệ thống DEVELOVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tnpSetting)).EndInit();
            this.tnpSetting.ResumeLayout(false);
            this.tnpSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.develoverGroupControl1)).EndInit();
            this.develoverGroupControl1.ResumeLayout(false);
            this.develoverGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labServerName;
        private Develover.GUI.Controls.DeveloverTextEditPassword txtPassWord;
        private Develover.GUI.Controls.DeveloverTextEdit txtUserName;
        private Develover.GUI.Controls.DeveloverLabelControl labUserSQL;
        private Develover.GUI.Controls.DeveloverSimpleButton butLogin;
        private Develover.GUI.Controls.DeveloverLabelControlError laberror;
        private DevExpress.XtraBars.Navigation.TabPane tnpSetting;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpSystem;
        private Develover.GUI.Controls.DeveloverTabNavigationPage tnpCustomer;
        private Develover.GUI.Controls.DeveloverLabelControl labDatabaseName;
        private Develover.GUI.Controls.DeveloverLabelControl labPasswordSQL;
        private Develover.GUI.Controls.DeveloverTextEdit txtDatabaseName;
        private Develover.GUI.Controls.DeveloverTextEdit txtServerName;
        private Develover.GUI.Controls.DeveloverGroupControl develoverGroupControl1;
    }
}