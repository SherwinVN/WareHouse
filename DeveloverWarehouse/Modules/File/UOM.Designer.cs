namespace DeveloverWarehouse.Modules.File
{
    partial class UOM
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
            this.txtName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.memDescription = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.chkActive = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labOUMName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labDescription = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_information
            // 
            this.tab_information.Size = new System.Drawing.Size(461, 414);
            // 
            // gro_general
            // 
            this.gro_general.Controls.Add(this.labDescription);
            this.gro_general.Controls.Add(this.labOUMName);
            this.gro_general.Controls.Add(this.chkActive);
            this.gro_general.Controls.Add(this.memDescription);
            this.gro_general.Controls.Add(this.txtName);
            this.gro_general.Size = new System.Drawing.Size(459, 385);
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
            // txtName
            // 
            this.txtName.FieldBinding = null;
            this.txtName.Location = new System.Drawing.Point(129, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // memDescription
            // 
            this.memDescription.FieldBinding = null;
            this.memDescription.Location = new System.Drawing.Point(129, 50);
            this.memDescription.Name = "memDescription";
            this.memDescription.Size = new System.Drawing.Size(284, 66);
            this.memDescription.TabIndex = 1;
            this.memDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // chkActive
            // 
            this.chkActive.FieldBinding = null;
            this.chkActive.Location = new System.Drawing.Point(129, 119);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái sử dụng";
            this.chkActive.Size = new System.Drawing.Size(284, 20);
            this.chkActive.TabIndex = 2;
            this.chkActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labOUMName
            // 
            this.labOUMName.FieldBinding = null;
            this.labOUMName.Location = new System.Drawing.Point(9, 27);
            this.labOUMName.Name = "labOUMName";
            this.labOUMName.Size = new System.Drawing.Size(71, 13);
            this.labOUMName.TabIndex = 3;
            this.labOUMName.Text = "Tên đơn vị tính";
            this.labOUMName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labDescription
            // 
            this.labDescription.FieldBinding = null;
            this.labDescription.Location = new System.Drawing.Point(9, 50);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(45, 13);
            this.labDescription.TabIndex = 4;
            this.labDescription.Text = "Chú thích";
            this.labDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // UOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "UOM";
            this.Text = "UOM";
            this.Load += new System.EventHandler(this.UOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            this.gro_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labOUMName;
        private Develover.GUI.Controls.DeveloverCheckEdit chkActive;
        private Develover.GUI.Controls.DeveloverMemoEdit memDescription;
        private Develover.GUI.Controls.DeveloverTextEdit txtName;
        private Develover.GUI.Controls.DeveloverLabelControl labDescription;
    }
}