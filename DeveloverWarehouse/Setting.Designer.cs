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
            this.grActive = new Develover.GUI.Controls.DeveloverGroupControl();
            this.labTextLicense = new Develover.GUI.Controls.DeveloverLabelControlError();
            this.labCodePersonal = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtCodePersonal = new Develover.GUI.Controls.DeveloverTextEdit();
            this.butActive = new Develover.GUI.Controls.DeveloverSimpleButton();
            this.grSettingSQL = new Develover.GUI.Controls.DeveloverGroupControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.grActive)).BeginInit();
            this.grActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodePersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSettingSQL)).BeginInit();
            this.grSettingSQL.SuspendLayout();
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
            this.tnpSetting.RegularSize = new System.Drawing.Size(776, 353);
            this.tnpSetting.SelectedPage = this.tnpCustomer;
            this.tnpSetting.Size = new System.Drawing.Size(776, 353);
            this.tnpSetting.TabIndex = 7;
            this.tnpSetting.Text = "Cài đặt";
            // 
            // tnpCustomer
            // 
            this.tnpCustomer.Caption = "Người dùng";
            this.tnpCustomer.FieldBinding = null;
            this.tnpCustomer.Name = "tnpCustomer";
            this.tnpCustomer.Size = new System.Drawing.Size(776, 324);
            this.tnpCustomer.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // tnpSystem
            // 
            this.tnpSystem.Caption = "Hệ thống";
            this.tnpSystem.Controls.Add(this.grActive);
            this.tnpSystem.Controls.Add(this.grSettingSQL);
            this.tnpSystem.InvertTouchScroll = true;
            this.tnpSystem.Name = "tnpSystem";
            this.tnpSystem.Size = new System.Drawing.Size(776, 324);
            // 
            // grActive
            // 
            this.grActive.Controls.Add(this.labTextLicense);
            this.grActive.Controls.Add(this.labCodePersonal);
            this.grActive.Controls.Add(this.txtCodePersonal);
            this.grActive.Controls.Add(this.butActive);
            this.grActive.FieldBinding = null;
            this.grActive.Location = new System.Drawing.Point(374, 13);
            this.grActive.Name = "grActive";
            this.grActive.Size = new System.Drawing.Size(356, 100);
            this.grActive.TabIndex = 7;
            this.grActive.Text = "Kích hoạt";
            this.grActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labTextLicense
            // 
            this.labTextLicense.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTextLicense.FieldBinding = null;
            this.labTextLicense.Location = new System.Drawing.Point(7, 59);
            this.labTextLicense.Name = "labTextLicense";
            this.labTextLicense.Size = new System.Drawing.Size(335, 33);
            this.labTextLicense.TabIndex = 5;
            this.labTextLicense.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labCodePersonal
            // 
            this.labCodePersonal.FieldBinding = null;
            this.labCodePersonal.Location = new System.Drawing.Point(7, 37);
            this.labCodePersonal.Name = "labCodePersonal";
            this.labCodePersonal.Size = new System.Drawing.Size(69, 13);
            this.labCodePersonal.TabIndex = 3;
            this.labCodePersonal.Text = "Mã số cá nhân";
            this.labCodePersonal.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtCodePersonal
            // 
            this.txtCodePersonal.FieldBinding = null;
            this.txtCodePersonal.Location = new System.Drawing.Point(108, 34);
            this.txtCodePersonal.Name = "txtCodePersonal";
            this.txtCodePersonal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodePersonal.Size = new System.Drawing.Size(158, 20);
            this.txtCodePersonal.TabIndex = 5;
            this.txtCodePersonal.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // butActive
            // 
            this.butActive.FieldBinding = null;
            this.butActive.Location = new System.Drawing.Point(272, 32);
            this.butActive.Name = "butActive";
            this.butActive.Size = new System.Drawing.Size(70, 22);
            this.butActive.TabIndex = 2;
            this.butActive.Text = "Kích hoạt";
            this.butActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.butActive.Click += new System.EventHandler(this.butActive_Click);
            // 
            // grSettingSQL
            // 
            this.grSettingSQL.Controls.Add(this.laberror);
            this.grSettingSQL.Controls.Add(this.labServerName);
            this.grSettingSQL.Controls.Add(this.txtDatabaseName);
            this.grSettingSQL.Controls.Add(this.labUserSQL);
            this.grSettingSQL.Controls.Add(this.txtServerName);
            this.grSettingSQL.Controls.Add(this.labPasswordSQL);
            this.grSettingSQL.Controls.Add(this.labDatabaseName);
            this.grSettingSQL.Controls.Add(this.txtPassWord);
            this.grSettingSQL.Controls.Add(this.txtUserName);
            this.grSettingSQL.Controls.Add(this.butLogin);
            this.grSettingSQL.FieldBinding = null;
            this.grSettingSQL.Location = new System.Drawing.Point(12, 13);
            this.grSettingSQL.Name = "grSettingSQL";
            this.grSettingSQL.Size = new System.Drawing.Size(356, 161);
            this.grSettingSQL.TabIndex = 7;
            this.grSettingSQL.Text = "Cấu hình SQL";
            this.grSettingSQL.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // laberror
            // 
            this.laberror.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.laberror.FieldBinding = null;
            this.laberror.Location = new System.Drawing.Point(7, 128);
            this.laberror.Name = "laberror";
            this.laberror.Size = new System.Drawing.Size(259, 29);
            this.laberror.TabIndex = 5;
            this.laberror.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labServerName
            // 
            this.labServerName.FieldBinding = null;
            this.labServerName.Location = new System.Drawing.Point(7, 37);
            this.labServerName.Name = "labServerName";
            this.labServerName.Size = new System.Drawing.Size(40, 13);
            this.labServerName.TabIndex = 3;
            this.labServerName.Text = "Máy chủ";
            this.labServerName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.FieldBinding = null;
            this.txtDatabaseName.Location = new System.Drawing.Point(108, 103);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(158, 20);
            this.txtDatabaseName.TabIndex = 6;
            this.txtDatabaseName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labUserSQL
            // 
            this.labUserSQL.FieldBinding = null;
            this.labUserSQL.Location = new System.Drawing.Point(7, 59);
            this.labUserSQL.Name = "labUserSQL";
            this.labUserSQL.Size = new System.Drawing.Size(46, 13);
            this.labUserSQL.TabIndex = 4;
            this.labUserSQL.Text = "Tài khoản";
            this.labUserSQL.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtServerName
            // 
            this.txtServerName.FieldBinding = null;
            this.txtServerName.Location = new System.Drawing.Point(108, 34);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServerName.Size = new System.Drawing.Size(158, 20);
            this.txtServerName.TabIndex = 5;
            this.txtServerName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labPasswordSQL
            // 
            this.labPasswordSQL.FieldBinding = null;
            this.labPasswordSQL.Location = new System.Drawing.Point(7, 81);
            this.labPasswordSQL.Name = "labPasswordSQL";
            this.labPasswordSQL.Size = new System.Drawing.Size(44, 13);
            this.labPasswordSQL.TabIndex = 4;
            this.labPasswordSQL.Text = "Mật khẩu";
            this.labPasswordSQL.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labDatabaseName
            // 
            this.labDatabaseName.FieldBinding = null;
            this.labDatabaseName.Location = new System.Drawing.Point(7, 103);
            this.labDatabaseName.Name = "labDatabaseName";
            this.labDatabaseName.Size = new System.Drawing.Size(62, 13);
            this.labDatabaseName.TabIndex = 4;
            this.labDatabaseName.Text = "Cơ sở dữ liệu";
            this.labDatabaseName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtPassWord
            // 
            this.txtPassWord.FieldBinding = null;
            this.txtPassWord.Location = new System.Drawing.Point(108, 80);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(158, 20);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtUserName
            // 
            this.txtUserName.FieldBinding = null;
            this.txtUserName.Location = new System.Drawing.Point(108, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // butLogin
            // 
            this.butLogin.FieldBinding = null;
            this.butLogin.Location = new System.Drawing.Point(272, 32);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(70, 46);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Đăng nhâp";
            this.butLogin.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 353);
            this.Controls.Add(this.tnpSetting);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Setting.IconOptions.Image")));
            this.Name = "Setting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt hệ thống DEVELOVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tnpSetting)).EndInit();
            this.tnpSetting.ResumeLayout(false);
            this.tnpSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grActive)).EndInit();
            this.grActive.ResumeLayout(false);
            this.grActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodePersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSettingSQL)).EndInit();
            this.grSettingSQL.ResumeLayout(false);
            this.grSettingSQL.PerformLayout();
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
        private Develover.GUI.Controls.DeveloverGroupControl grSettingSQL;
        private Develover.GUI.Controls.DeveloverGroupControl grActive;
        private Develover.GUI.Controls.DeveloverLabelControlError labTextLicense;
        private Develover.GUI.Controls.DeveloverLabelControl labCodePersonal;
        private Develover.GUI.Controls.DeveloverTextEdit txtCodePersonal;
        private Develover.GUI.Controls.DeveloverSimpleButton butActive;
    }
}