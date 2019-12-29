namespace DeveloverWarehouse.Modules.File
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txtLastNameAndName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.txtAdress = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.chkActive = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labLastNameAndName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labAdress = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtAccount = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labUserName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtPassword = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labPassword = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastNameAndName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_information
            // 
            this.tab_information.Size = new System.Drawing.Size(461, 414);
            // 
            // gro_general
            // 
            this.gro_general.Controls.Add(this.labAdress);
            this.gro_general.Controls.Add(this.labPassword);
            this.gro_general.Controls.Add(this.labUserName);
            this.gro_general.Controls.Add(this.labLastNameAndName);
            this.gro_general.Controls.Add(this.chkActive);
            this.gro_general.Controls.Add(this.txtAdress);
            this.gro_general.Controls.Add(this.txtPassword);
            this.gro_general.Controls.Add(this.txtAccount);
            this.gro_general.Controls.Add(this.txtLastNameAndName);
            this.gro_general.Size = new System.Drawing.Size(459, 382);
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.Location = new System.Drawing.Point(323, 2);
            this.develoverSplitterControl1.Size = new System.Drawing.Size(10, 418);
            // 
            // gro_search
            // 
            this.gro_search.Size = new System.Drawing.Size(321, 418);
            // 
            // txtLastNameAndName
            // 
            this.txtLastNameAndName.FieldBinding = "Name";
            this.txtLastNameAndName.Location = new System.Drawing.Point(124, 49);
            this.txtLastNameAndName.Name = "txtLastNameAndName";
            this.txtLastNameAndName.Size = new System.Drawing.Size(284, 20);
            this.txtLastNameAndName.TabIndex = 2;
            this.txtLastNameAndName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // txtAdress
            // 
            this.txtAdress.FieldBinding = "Address";
            this.txtAdress.Location = new System.Drawing.Point(124, 72);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(284, 66);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // chkActive
            // 
            this.chkActive.FieldBinding = "Active";
            this.chkActive.Location = new System.Drawing.Point(124, 141);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái sử dụng";
            this.chkActive.Size = new System.Drawing.Size(284, 20);
            this.chkActive.TabIndex = 8;
            this.chkActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Check;
            // 
            // labLastNameAndName
            // 
            this.labLastNameAndName.FieldBinding = null;
            this.labLastNameAndName.Location = new System.Drawing.Point(7, 52);
            this.labLastNameAndName.Name = "labLastNameAndName";
            this.labLastNameAndName.Size = new System.Drawing.Size(49, 13);
            this.labLastNameAndName.TabIndex = 6;
            this.labLastNameAndName.Text = "Họ và Tên";
            this.labLastNameAndName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labAdress
            // 
            this.labAdress.FieldBinding = null;
            this.labAdress.Location = new System.Drawing.Point(7, 74);
            this.labAdress.Name = "labAdress";
            this.labAdress.Size = new System.Drawing.Size(32, 13);
            this.labAdress.TabIndex = 7;
            this.labAdress.Text = "Địa chỉ";
            this.labAdress.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtAccount
            // 
            this.txtAccount.FieldBinding = "UserName";
            this.txtAccount.Location = new System.Drawing.Point(124, 5);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(284, 20);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // labUserName
            // 
            this.labUserName.FieldBinding = null;
            this.labUserName.Location = new System.Drawing.Point(7, 8);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(46, 13);
            this.labUserName.TabIndex = 4;
            this.labUserName.Text = "Tài khoản";
            this.labUserName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtPassword
            // 
            this.txtPassword.FieldBinding = "PassWord";
            this.txtPassword.Location = new System.Drawing.Point(124, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // labPassword
            // 
            this.labPassword.FieldBinding = null;
            this.labPassword.Location = new System.Drawing.Point(7, 30);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(44, 13);
            this.labPassword.TabIndex = 5;
            this.labPassword.Text = "Mật khẩu";
            this.labPassword.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("User.IconOptions.SvgImage")));
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            this.gro_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastNameAndName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labLastNameAndName;
        private Develover.GUI.Controls.DeveloverCheckEdit chkActive;
        private Develover.GUI.Controls.DeveloverMemoEdit txtAdress;
        private Develover.GUI.Controls.DeveloverTextEdit txtLastNameAndName;
        private Develover.GUI.Controls.DeveloverLabelControl labAdress;
        private Develover.GUI.Controls.DeveloverLabelControl labPassword;
        private Develover.GUI.Controls.DeveloverLabelControl labUserName;
        private Develover.GUI.Controls.DeveloverTextEdit txtPassword;
        private Develover.GUI.Controls.DeveloverTextEdit txtAccount;
    }
}