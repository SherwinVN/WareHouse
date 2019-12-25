﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Develover.Utilities;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Forms
{
    public partial class DeveloverCatalogForm : DeveloverForm
    {
        public string SQLDataSourceSearch;
        public string Model;
        public IDeveloverControl[] DeveloverControls;
        public IDeveloverControl DeveloverControlsFocus;
        public string TitleForm;

        public string CodePrimary;
        public string NameFileCodePrimary;

        public EnumPermission StatusUse;
        public DeveloverCatalogForm()
        {
            InitializeComponent();
            grc_search.TypeGridEdit = false;
            StatusUse = EnumPermission.View;
            SetEnableBarButton();

        }
        private void DeveloverCatalogForm_Load(object sender, EventArgs e)
        {
            LoadPermissionForm();
        }


        public void InitForm()
        {
            LoadData();
            DataBindingsControl();
            Text = TitleForm;
        }

        public virtual void LoadData()
        {
            grc_search.BuildGridControls(SQLDataSourceSearch, Model);

        }

        public virtual void DataBindingsControl()
        {
            foreach (IDeveloverControl develoverControl in DeveloverControls)
            {
                switch (((IDeveloverControl)develoverControl).TypeFieldColumns)
                {
                    case EnumTypeColumns.Check:
                        ((Control)develoverControl).DataBindings.Add(nameof(BaseCheckEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Gridlookup:
                        ((Control)develoverControl).DataBindings.Add(nameof(GridLookUpEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Text:
                        ((Control)develoverControl).DataBindings.Add(nameof(TextEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Combobox:
                        ((Control)develoverControl).DataBindings.Add(nameof(ComboBoxEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Date:
                        ((Control)develoverControl).DataBindings.Add(nameof(DateEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Number:
                        ((Control)develoverControl).DataBindings.Add(nameof(CalcEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                    case EnumTypeColumns.Time:
                        ((Control)develoverControl).DataBindings.Add(nameof(TimeEdit.EditValue), grc_search.DataSource, ((IDeveloverControl)develoverControl).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                        break;
                }

            }

        }

        protected virtual void BarButtonNew_Click()
        {

        }

        protected virtual void BarButtonEdit_Click()
        {

        }

        protected virtual void BarButtonCancel_Click()
        {

        }

        protected virtual void BarButtonDelete_Click()
        {

        }

        protected virtual void BarButtonPrint_Click()
        {

        }

        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionNew) return;
            SetEnableBarButton();
            BarButtonNew_Click();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionEdit) return;
            SetEnableBarButton();
            BarButtonEdit_Click();
        }

        private void BarButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetEnableBarButton();
            BarButtonCancel_Click();
        }

        private void BarButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionDelete) return;
            SetEnableBarButton();
            BarButtonDelete_Click();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionPrint) return;
            SetEnableBarButton();
            BarButtonPrint_Click();

        }

        private void SetVisibleItemToolBar()
        {
            BarButtonNew.Visibility = PermissionNew ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonEdit.Visibility = PermissionEdit ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonDelete.Visibility = PermissionDelete ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonPrint.Visibility = PermissionPrint ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        private void SetEnableBarButton()
        {
            LoadTextBarButton();
            switch (StatusUse)
            {
                case EnumPermission.New:
                    {
                        barButtonEdit.Enable = false;
                        barButtonDelete.Enable = false;
                        barButtonCancel.Enable = true;
                        barButtonPrint.Enable = false;
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        barButtonEdit.Enable = false;
                        barButtonDelete.Enable = false;
                        barButtonCancel.Enable = true;
                        barButtonPrint.Enable = false;
                    }
                    break;
                case EnumPermission.View:
                    {
                        barButtonEdit.Enable = true;
                        barButtonDelete.Enable = true;
                        barButtonCancel.Enable = false;
                        barButtonPrint.Enable = true;
                    }
                    break;
                case EnumPermission.Denial:
                    {
                        BarButtonNew.Enable = false;
                        barButtonEdit.Enable = false;
                        barButtonDelete.Enable = false;
                        barButtonCancel.Enable = false;
                        barButtonPrint.Enable = false;
                    }
                    break;
            }
        }

        private void LoadTextBarButton()
        {
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit)
                BarButtonNew.Text = StringMessage.TextButtonSave;
            else
                BarButtonNew.Text = StringMessage.TextButtonNew;

            barButtonEdit.Enable = StringMessage.TextButtonEdit;
            barButtonDelete.Enable = StringMessage.TextButtonDelete;
            barButtonCancel.Enable = StringMessage.TextButtonCancel;
            barButtonPrint.Enable = StringMessage.TextButtonPrint;
        }

        public void LoadPermissionForm()
        {
            LoadPermission();
            SetVisibleItemToolBar();
        }

        private void gro_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grv_search_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CodePrimary = ((GridView)sender).GetFocusedRowCellValue(((GridView)sender).Columns[NameFileCodePrimary])?.ToString();
        }
    }
}