namespace DeveloverWarehouse.Modules.File
{
    partial class GroupUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupUser));
            this.txtDescription = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.chkActive = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labAdress = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtNameGroup = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labNameGroup = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_information
            // 
            this.tab_information.Size = new System.Drawing.Size(461, 418);
            // 
            // gro_general
            // 
            this.gro_general.Controls.Add(this.labAdress);
            this.gro_general.Controls.Add(this.labNameGroup);
            this.gro_general.Controls.Add(this.chkActive);
            this.gro_general.Controls.Add(this.txtDescription);
            this.gro_general.Controls.Add(this.txtNameGroup);
            this.gro_general.Size = new System.Drawing.Size(459, 390);
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.Location = new System.Drawing.Point(323, 2);
            this.develoverSplitterControl1.Size = new System.Drawing.Size(10, 422);
            // 
            // gro_search
            // 
            this.gro_search.Size = new System.Drawing.Size(321, 422);
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.FieldBinding = "Description";
            this.txtDescription.IsGUID = false;
            this.txtDescription.Location = new System.Drawing.Point(124, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 66);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // chkActive
            // 
            this.chkActive.FieldBinding = "Active";
            this.chkActive.IsGUID = false;
            this.chkActive.Location = new System.Drawing.Point(124, 97);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái sử dụng";
            this.chkActive.Size = new System.Drawing.Size(284, 20);
            this.chkActive.TabIndex = 8;
            this.chkActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Check;
            // 
            // labAdress
            // 
            this.labAdress.FieldBinding = null;
            this.labAdress.IsGUID = false;
            this.labAdress.Location = new System.Drawing.Point(7, 30);
            this.labAdress.Name = "labAdress";
            this.labAdress.Size = new System.Drawing.Size(35, 13);
            this.labAdress.TabIndex = 7;
            this.labAdress.Text = "Ghi chú";
            this.labAdress.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.FieldBinding = "NameGroup";
            this.txtNameGroup.IsGUID = false;
            this.txtNameGroup.Location = new System.Drawing.Point(124, 5);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(284, 20);
            this.txtNameGroup.TabIndex = 1;
            this.txtNameGroup.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // labNameGroup
            // 
            this.labNameGroup.FieldBinding = null;
            this.labNameGroup.IsGUID = false;
            this.labNameGroup.Location = new System.Drawing.Point(7, 8);
            this.labNameGroup.Name = "labNameGroup";
            this.labNameGroup.Size = new System.Drawing.Size(47, 13);
            this.labNameGroup.TabIndex = 5;
            this.labNameGroup.Text = "Tên nhóm";
            this.labNameGroup.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // GroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("GroupUser.IconOptions.Image")));
            this.Name = "GroupUser";
            this.Text = "GroupUser";
            this.Load += new System.EventHandler(this.UOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            this.gro_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Develover.GUI.Controls.DeveloverCheckEdit chkActive;
        private Develover.GUI.Controls.DeveloverMemoEdit txtDescription;
        private Develover.GUI.Controls.DeveloverLabelControl labAdress;
        private Develover.GUI.Controls.DeveloverLabelControl labNameGroup;
        private Develover.GUI.Controls.DeveloverTextEdit txtNameGroup;
    }
}