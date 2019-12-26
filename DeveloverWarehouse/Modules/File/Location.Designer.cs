namespace DeveloverWarehouse.Modules.File
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.txtBranchID = new Develover.GUI.Controls.DeveloverTextEdit();
            this.memDescription = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.chkActive = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labBranchID = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labLocationName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtLocationName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.txtLocationCode = new Develover.GUI.Controls.DeveloverTextEdit();
            this.labLocationCode = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labDescription = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_information
            // 
            this.tab_information.Size = new System.Drawing.Size(461, 414);
            // 
            // gro_general
            // 
            this.gro_general.Controls.Add(this.labLocationCode);
            this.gro_general.Controls.Add(this.labDescription);
            this.gro_general.Controls.Add(this.labLocationName);
            this.gro_general.Controls.Add(this.labBranchID);
            this.gro_general.Controls.Add(this.chkActive);
            this.gro_general.Controls.Add(this.memDescription);
            this.gro_general.Controls.Add(this.txtLocationCode);
            this.gro_general.Controls.Add(this.txtLocationName);
            this.gro_general.Controls.Add(this.txtBranchID);
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
            // txtBranchID
            // 
            this.txtBranchID.FieldBinding = "BranchID";
            this.txtBranchID.Location = new System.Drawing.Point(131, 14);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(284, 20);
            this.txtBranchID.TabIndex = 0;
            this.txtBranchID.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // memDescription
            // 
            this.memDescription.FieldBinding = "Description";
            this.memDescription.Location = new System.Drawing.Point(131, 83);
            this.memDescription.Name = "memDescription";
            this.memDescription.Size = new System.Drawing.Size(284, 66);
            this.memDescription.TabIndex = 3;
            this.memDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // chkActive
            // 
            this.chkActive.FieldBinding = "Active";
            this.chkActive.Location = new System.Drawing.Point(131, 152);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái sử dụng";
            this.chkActive.Size = new System.Drawing.Size(284, 20);
            this.chkActive.TabIndex = 4;
            this.chkActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Check;
            // 
            // labBranchID
            // 
            this.labBranchID.FieldBinding = null;
            this.labBranchID.Location = new System.Drawing.Point(11, 14);
            this.labBranchID.Name = "labBranchID";
            this.labBranchID.Size = new System.Drawing.Size(69, 13);
            this.labBranchID.TabIndex = 5;
            this.labBranchID.Text = "Đơn vị quản lý";
            this.labBranchID.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labLocationName
            // 
            this.labLocationName.FieldBinding = null;
            this.labLocationName.Location = new System.Drawing.Point(11, 60);
            this.labLocationName.Name = "labLocationName";
            this.labLocationName.Size = new System.Drawing.Size(41, 13);
            this.labLocationName.TabIndex = 7;
            this.labLocationName.Text = "Vị trí kho";
            this.labLocationName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtLocationName
            // 
            this.txtLocationName.FieldBinding = "LocationName";
            this.txtLocationName.Location = new System.Drawing.Point(131, 60);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(284, 20);
            this.txtLocationName.TabIndex = 2;
            this.txtLocationName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.FieldBinding = "LocationCode";
            this.txtLocationCode.Location = new System.Drawing.Point(131, 37);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(284, 20);
            this.txtLocationCode.TabIndex = 1;
            this.txtLocationCode.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // labLocationCode
            // 
            this.labLocationCode.FieldBinding = null;
            this.labLocationCode.Location = new System.Drawing.Point(11, 37);
            this.labLocationCode.Name = "labLocationCode";
            this.labLocationCode.Size = new System.Drawing.Size(34, 13);
            this.labLocationCode.TabIndex = 6;
            this.labLocationCode.Text = "Mã kho";
            this.labLocationCode.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labDescription
            // 
            this.labDescription.FieldBinding = null;
            this.labDescription.Location = new System.Drawing.Point(11, 83);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(40, 13);
            this.labDescription.TabIndex = 8;
            this.labDescription.Text = "Diễn giải";
            this.labDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Location.IconOptions.Image")));
            this.Name = "Location";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            this.gro_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labBranchID;
        private Develover.GUI.Controls.DeveloverCheckEdit chkActive;
        private Develover.GUI.Controls.DeveloverMemoEdit memDescription;
        private Develover.GUI.Controls.DeveloverTextEdit txtBranchID;
        private Develover.GUI.Controls.DeveloverLabelControl labLocationName;
        private Develover.GUI.Controls.DeveloverLabelControl labLocationCode;
        private Develover.GUI.Controls.DeveloverTextEdit txtLocationCode;
        private Develover.GUI.Controls.DeveloverTextEdit txtLocationName;
        private Develover.GUI.Controls.DeveloverLabelControl labDescription;
    }
}