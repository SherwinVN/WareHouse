namespace DeveloverWarehouse.Modules.Inventory
{
    partial class Delivery
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.develoverLabelControl5 = new Develover.GUI.Controls.DeveloverLabelControl();
            this.Description = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.develoverLabelControl6 = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtAddress = new Develover.GUI.Controls.DeveloverTextEdit();
            this.develoverLabelControl7 = new Develover.GUI.Controls.DeveloverLabelControl();
            this.develoverLabelControl8 = new Develover.GUI.Controls.DeveloverLabelControl();
            this.txtContactName = new Develover.GUI.Controls.DeveloverTextEdit();
            this.lokCustomer = new Develover.GUI.Controls.DeveloverGridLookUpEdit();
            this.develoverGridView1 = new Develover.GUI.Controls.DeveloverGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groHeader)).BeginInit();
            this.groHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groVoucherInfo)).BeginInit();
            this.groVoucherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGroupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.Size = new System.Drawing.Size(10, 409);
            // 
            // gro_search
            // 
            this.gro_search.Size = new System.Drawing.Size(270, 409);
            // 
            // tabDetail
            // 
            this.tabDetail.Size = new System.Drawing.Size(550, 211);
            this.tabDetail.TabIndex = 1;
            // 
            // groHeader
            // 
            this.groHeader.AppearanceCaption.Options.UseTextOptions = true;
            this.groHeader.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groHeader.Controls.Add(this.lokCustomer);
            this.groHeader.Controls.Add(this.develoverLabelControl7);
            this.groHeader.Controls.Add(this.txtContactName);
            this.groHeader.Controls.Add(this.txtAddress);
            this.groHeader.Controls.Add(this.develoverLabelControl8);
            this.groHeader.Controls.Add(this.develoverLabelControl6);
            this.groHeader.Controls.Add(this.Description);
            this.groHeader.Controls.Add(this.develoverLabelControl5);
            this.groHeader.TabIndex = 0;
            this.groHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.groHeader_Paint);
            this.groHeader.Controls.SetChildIndex(this.groVoucherInfo, 0);
            this.groHeader.Controls.SetChildIndex(this.develoverLabelControl5, 0);
            this.groHeader.Controls.SetChildIndex(this.Description, 0);
            this.groHeader.Controls.SetChildIndex(this.develoverLabelControl6, 0);
            this.groHeader.Controls.SetChildIndex(this.develoverLabelControl8, 0);
            this.groHeader.Controls.SetChildIndex(this.txtAddress, 0);
            this.groHeader.Controls.SetChildIndex(this.txtContactName, 0);
            this.groHeader.Controls.SetChildIndex(this.develoverLabelControl7, 0);
            this.groHeader.Controls.SetChildIndex(this.lokCustomer, 0);
            // 
            // txtDateNo
            // 
            this.txtDateNo.EditValue = null;
            // 
            // txtVoucherNo
            // 
            // 
            // develoverLabelControl5
            // 
            this.develoverLabelControl5.FieldBinding = null;
            this.develoverLabelControl5.IsGUID = false;
            this.develoverLabelControl5.Location = new System.Drawing.Point(5, 31);
            this.develoverLabelControl5.Name = "develoverLabelControl5";
            this.develoverLabelControl5.Size = new System.Drawing.Size(56, 13);
            this.develoverLabelControl5.TabIndex = 2;
            this.develoverLabelControl5.Text = "Khách hàng";
            this.develoverLabelControl5.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // Description
            // 
            this.Description.FieldBinding = "Description";
            this.Description.IsGUID = false;
            this.Description.Location = new System.Drawing.Point(74, 95);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(265, 81);
            this.Description.TabIndex = 3;
            this.Description.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // develoverLabelControl6
            // 
            this.develoverLabelControl6.FieldBinding = null;
            this.develoverLabelControl6.IsGUID = false;
            this.develoverLabelControl6.Location = new System.Drawing.Point(5, 73);
            this.develoverLabelControl6.Name = "develoverLabelControl6";
            this.develoverLabelControl6.Size = new System.Drawing.Size(55, 13);
            this.develoverLabelControl6.TabIndex = 5;
            this.develoverLabelControl6.Text = "Người nhận";
            this.develoverLabelControl6.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtAddress
            // 
            this.txtAddress.FieldBinding = "Address";
            this.txtAddress.IsGUID = false;
            this.txtAddress.Location = new System.Drawing.Point(74, 49);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // develoverLabelControl7
            // 
            this.develoverLabelControl7.FieldBinding = null;
            this.develoverLabelControl7.IsGUID = false;
            this.develoverLabelControl7.Location = new System.Drawing.Point(5, 52);
            this.develoverLabelControl7.Name = "develoverLabelControl7";
            this.develoverLabelControl7.Size = new System.Drawing.Size(32, 13);
            this.develoverLabelControl7.TabIndex = 7;
            this.develoverLabelControl7.Text = "Địa chỉ";
            this.develoverLabelControl7.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverLabelControl8
            // 
            this.develoverLabelControl8.FieldBinding = null;
            this.develoverLabelControl8.IsGUID = false;
            this.develoverLabelControl8.Location = new System.Drawing.Point(5, 94);
            this.develoverLabelControl8.Name = "develoverLabelControl8";
            this.develoverLabelControl8.Size = new System.Drawing.Size(35, 13);
            this.develoverLabelControl8.TabIndex = 5;
            this.develoverLabelControl8.Text = "Ghi chú";
            this.develoverLabelControl8.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtContactName
            // 
            this.txtContactName.FieldBinding = "ContactName";
            this.txtContactName.IsGUID = false;
            this.txtContactName.Location = new System.Drawing.Point(74, 72);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(265, 20);
            this.txtContactName.TabIndex = 2;
            this.txtContactName.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Text;
            // 
            // lokCustomer
            // 
            this.lokCustomer.EnterMoveNextControl = true;
            this.lokCustomer.FieldBinding = "Customer";
            this.lokCustomer.IsGUID = true;
            this.lokCustomer.Location = new System.Drawing.Point(74, 26);
            this.lokCustomer.Name = "lokCustomer";
            this.lokCustomer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lokCustomer.Properties.Buttons.Add(  new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Thêm danh mục", null, null, DevExpress.Utils.ToolTipAnchor.Default));
            this.lokCustomer.Properties.NullText = "";
            this.lokCustomer.Properties.PopupView = this.develoverGridView1;
            this.lokCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lokCustomer.Properties.ValidateOnEnterKey = true;
            this.lokCustomer.Size = new System.Drawing.Size(265, 20);
            this.lokCustomer.TabIndex = 0;
            this.lokCustomer.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Gridlookup;
            // 
            // develoverGridView1
            // 
            this.develoverGridView1.FieldBinding = null;
            this.develoverGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.develoverGridView1.IndicatorWidth = 40;
            this.develoverGridView1.IsGUID = false;
            this.develoverGridView1.Name = "develoverGridView1";
            this.develoverGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.develoverGridView1.OptionsSelection.MultiSelect = true;
            this.develoverGridView1.OptionsView.ColumnAutoWidth = false;
            this.develoverGridView1.OptionsView.ShowGroupPanel = false;
            this.develoverGridView1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(838, 437);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delivery.IconOptions.Image")));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Delivery.IconOptions.SvgImage")));
            this.Name = "Delivery";
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groHeader)).EndInit();
            this.groHeader.ResumeLayout(false);
            this.groHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groVoucherInfo)).EndInit();
            this.groVoucherInfo.ResumeLayout(false);
            this.groVoucherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGroupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Develover.GUI.Controls.DeveloverLabelControl develoverLabelControl5;
        private Develover.GUI.Controls.DeveloverMemoEdit Description;
        private Develover.GUI.Controls.DeveloverLabelControl develoverLabelControl6;
        private Develover.GUI.Controls.DeveloverTextEdit txtAddress;
        private Develover.GUI.Controls.DeveloverLabelControl develoverLabelControl7;
        private Develover.GUI.Controls.DeveloverLabelControl develoverLabelControl8;
        private Develover.GUI.Controls.DeveloverTextEdit txtContactName;
        private Develover.GUI.Controls.DeveloverGridLookUpEdit lokCustomer;
        private Develover.GUI.Controls.DeveloverGridView develoverGridView1;
    }
}