namespace DeveloverWarehouse.Modules.Accounting
{
    partial class Currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency));
            this.txtCurrencyName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.memDescription = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.chkActive = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.labCurrencyName = new Develover.GUI.Controls.DeveloverLabelControl();
            this.labDescription = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyName.Properties)).BeginInit();
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
            this.gro_general.Controls.Add(this.labCurrencyName);
            this.gro_general.Controls.Add(this.chkActive);
            this.gro_general.Controls.Add(this.memDescription);
            this.gro_general.Controls.Add(this.txtCurrencyName);
            this.gro_general.Size = new System.Drawing.Size(459, 382);
            this.gro_general.Paint += new System.Windows.Forms.PaintEventHandler(this.gro_general_Paint);
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
            // txtCurrencyName
            // 
            this.txtCurrencyName.FieldBinding = "CurrencyName";
            this.txtCurrencyName.IsGUID = false;
            this.txtCurrencyName.Location = new System.Drawing.Point(126, 5);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(284, 20);
            this.txtCurrencyName.TabIndex = 0;
            this.txtCurrencyName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            this.txtCurrencyName.EditValueChanged += new System.EventHandler(this.txtCurrencyName_EditValueChanged);
            // 
            // memDescription
            // 
            this.memDescription.FieldBinding = "Description";
            this.memDescription.IsGUID = false;
            this.memDescription.Location = new System.Drawing.Point(126, 28);
            this.memDescription.Name = "memDescription";
            this.memDescription.Size = new System.Drawing.Size(284, 66);
            this.memDescription.TabIndex = 1;
            this.memDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // chkActive
            // 
            this.chkActive.FieldBinding = "Active";
            this.chkActive.IsGUID = false;
            this.chkActive.Location = new System.Drawing.Point(126, 97);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái sử dụng";
            this.chkActive.Size = new System.Drawing.Size(284, 20);
            this.chkActive.TabIndex = 2;
            this.chkActive.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Check;
            // 
            // labCurrencyName
            // 
            this.labCurrencyName.FieldBinding = null;
            this.labCurrencyName.IsGUID = false;
            this.labCurrencyName.Location = new System.Drawing.Point(6, 5);
            this.labCurrencyName.Name = "labCurrencyName";
            this.labCurrencyName.Size = new System.Drawing.Size(71, 13);
            this.labCurrencyName.TabIndex = 3;
            this.labCurrencyName.Text = "Tên đơn vị tính";
            this.labCurrencyName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // labDescription
            // 
            this.labDescription.FieldBinding = null;
            this.labDescription.IsGUID = false;
            this.labDescription.Location = new System.Drawing.Point(6, 28);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(45, 13);
            this.labDescription.TabIndex = 4;
            this.labDescription.Text = "Chú thích";
            this.labDescription.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Currency.IconOptions.Image")));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Currency.IconOptions.SvgImage")));
            this.Name = "Currency";
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.UOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            this.gro_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Develover.GUI.Controls.DeveloverLabelControl labCurrencyName;
        private Develover.GUI.Controls.DeveloverCheckEdit chkActive;
        private Develover.GUI.Controls.DeveloverMemoEdit memDescription;
        private Develover.GUI.Controls.DeveloverTextEdit txtCurrencyName;
        private Develover.GUI.Controls.DeveloverLabelControl labDescription;
    }
}