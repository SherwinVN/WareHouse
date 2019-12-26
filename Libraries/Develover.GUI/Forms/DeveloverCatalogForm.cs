using System;
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
using Develover.Services;
using Develover.GUI.Controls;
using Develover.GUI.OverideClass;

namespace Develover.GUI.Forms
{
    public partial class DeveloverCatalogForm : DeveloverForm
    {
        Functions functions = new Functions();
        public string SQLDataSourceSearch;
        public string Model;
        public string Table;
        public string CodePrimary;
        public string NameFieldCodePrimary;
        public EnumPermission StatusUse;
        public IDeveloverControl DeveloverControlsFocus;

        public DeveloverCatalogForm()
        {
            InitializeComponent();
        }

        private void DeveloverCatalogForm_Load(object sender, EventArgs e)
        {
            LoadPermissionForm();
            StatusUse = EnumPermission.View;
            SetEnableBarButton();
        }

        protected virtual void SetNullControl(IDeveloverControl GroupControl)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Check:
                                ((CheckEdit)iDcontrol).Checked = false;
                                break;
                            case EnumTypeColumns.Gridlookup:
                                ((Control)iDcontrol).Text = "";
                                break;
                            case EnumTypeColumns.Text:
                                ((Control)iDcontrol).Text = "";
                                break;
                            case EnumTypeColumns.Combobox:
                                ((Control)iDcontrol).Text = "";
                                break;
                            case EnumTypeColumns.Date:
                                ((DateEdit)iDcontrol).DateTime = DateTime.Now;
                                break;
                            case EnumTypeColumns.Number:
                                ((Control)iDcontrol).Text = "0";
                                break;
                            case EnumTypeColumns.Time:
                                ((TimeEdit)iDcontrol).Time = DateTime.Now;
                                break;
                        }


                    }
                }

            }
        }

        protected virtual bool SetStatusEdit(IDeveloverControl GroupControl, bool Enable)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Check:
                                ((CheckEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Gridlookup:
                                ((GridLookUpEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Text:
                                ((TextEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Combobox:
                                ((ComboBoxEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Date:
                                ((DateEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Number:
                                ((CalcEdit)iDcontrol).ReadOnly = Enable;
                                break;
                            case EnumTypeColumns.Time:
                                ((TimeEdit)iDcontrol).ReadOnly = Enable;
                                break;
                        }


                    }
                }

            }

            return Enable;
        }

        private void DataBindingsControl(IDeveloverControl GroupControl, Object Datasource)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        ((Control)iDcontrol).DataBindings.Clear();
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Check:
                                ((Control)iDcontrol).DataBindings.Add(nameof(BaseCheckEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Gridlookup:
                                ((Control)iDcontrol).DataBindings.Add(nameof(GridLookUpEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Text:
                                ((Control)iDcontrol).DataBindings.Add(nameof(TextEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Combobox:
                                ((Control)iDcontrol).DataBindings.Add(nameof(ComboBoxEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Date:
                                ((Control)iDcontrol).DataBindings.Add(nameof(DateEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Number:
                                ((Control)iDcontrol).DataBindings.Add(nameof(CalcEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                            case EnumTypeColumns.Time:
                                ((Control)iDcontrol).DataBindings.Add(nameof(TimeEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                break;
                        }


                    }
                }

            }

        }

        public Dictionary<string, string> LoadListControlAndFile(IDeveloverControl GroupControl)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Number:
                                dictionary.Add(iDcontrol.FieldBinding, ((Control)iDcontrol).Text);
                                break;
                            case EnumTypeColumns.Check:
                                dictionary.Add(iDcontrol.FieldBinding, ((CheckEdit)iDcontrol).Checked ? "1" : "0");
                                break;
                            case EnumTypeColumns.Combobox:
                                dictionary.Add(iDcontrol.FieldBinding, ((Control)iDcontrol).Text);
                                break;
                            case EnumTypeColumns.Date:
                                dictionary.Add(iDcontrol.FieldBinding, DateTime.Parse(((Control)iDcontrol).Text).ToString("MM/dd/yyyy"));
                                break;
                            case EnumTypeColumns.Gridlookup:
                                dictionary.Add(iDcontrol.FieldBinding, ((Control)iDcontrol).Text);
                                break;
                            case EnumTypeColumns.Text:
                                dictionary.Add(iDcontrol.FieldBinding, ((Control)iDcontrol).Text);
                                break;
                            case EnumTypeColumns.Time:
                                dictionary.Add(iDcontrol.FieldBinding, ((Control)iDcontrol).Text);
                                break;
                        }
                    }

                }

            }

            return dictionary;
        }

        protected virtual void BarButtonNew_Click()
        {
            if (string.IsNullOrEmpty(CodePrimary)) return;
            if (EnumPermission.New == StatusUse)
            {
                CodePrimary = functions.GetGUID();
                functions.InsertIntoTable(LoadListControlAndFile(gro_general), Table, NameFieldCodePrimary, CodePrimary);
                LoadData();
            }
            else
            if (EnumPermission.Edit == StatusUse)
            {
                functions.UpdateTable(LoadListControlAndFile(gro_general), Table, NameFieldCodePrimary, CodePrimary);

                LoadData();
            }
            else
            {
                SetNullControl(gro_general);
                ((Control)DeveloverControlsFocus).Focus();
            }
        }

        protected virtual void BarButtonEdit_Click()
        {
            if (string.IsNullOrEmpty(CodePrimary)) return;
        }

        protected virtual void BarButtonCancel_Click()
        {
            LoadData();
        }

        protected virtual void BarButtonDelete_Click()
        {
            if (DelMessageBox.DelMessageBoxYN("Bạn có muốn xóa?", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                functions.DeleteRowTable(Table, NameFieldCodePrimary, CodePrimary);
               
                LoadData();
            }
        }

        protected virtual void BarButtonPrint_Click()
        {

        }

        private void SetVisibleItemToolBar()
        {
            BarButtonNew.Visibility = PermissionNew ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonEdit.Visibility = PermissionEdit ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonDelete.Visibility = PermissionDelete ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonPrint.Visibility = PermissionPrint ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        protected virtual void SetEnableBarButton()
        {
            LoadTextBarButton();
            switch (StatusUse)
            {
                case EnumPermission.New:
                    {

                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = true;
                        barButtonPrint.Enabled = false;
                        SetStatusEdit(gro_general, false);
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = true;
                        barButtonPrint.Enabled = false;
                        SetStatusEdit(gro_general, false);
                    }
                    break;
                case EnumPermission.View:
                    {
                        barButtonEdit.Enabled = true;
                        barButtonDelete.Enabled = true;
                        barButtonCancel.Enabled = false;
                        barButtonPrint.Enabled = true;
                        SetStatusEdit(gro_general, true);
                    }
                    break;
                case EnumPermission.Denial:
                    {
                        BarButtonNew.Enabled = false;
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = false;
                        barButtonPrint.Enabled = false;
                        SetStatusEdit(gro_general, true);
                    }
                    break;
            }
        }

        private void LoadTextBarButton()
        {
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit)
                BarButtonNew.Caption = StringMessage.TextButtonSave;
            else
                BarButtonNew.Caption = StringMessage.TextButtonNew;

            barButtonEdit.Caption = StringMessage.TextButtonEdit;
            barButtonDelete.Caption = StringMessage.TextButtonDelete;
            barButtonCancel.Caption = StringMessage.TextButtonCancel;
            barButtonPrint.Caption = StringMessage.TextButtonPrint;
        }

        public void LoadPermissionForm()
        {
            LoadPermission();
            SetVisibleItemToolBar();
        }

        protected virtual void InitForm()
        {
            using (DataTable data = functions.dataBase.GetDataTable("SELECT   ID, Code, Name, TableHeader, TableDetail FROM SysDELListVoucher WHERE code = '" + Model + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    Text = dr["Name"].ToString();
                    Table = dr["TableHeader"].ToString();
                }
            }
            grc_search.BuildGridControlsView(SQLDataSourceSearch, Table);
            LoadData();

        }

        protected virtual void LoadData()
        {
            int i = grv_search.FocusedRowHandle;
            grc_search.LoadData();
            DataBindingsControl(gro_general, grc_search.DataSource);
            grv_search.FocusedRowHandle = i;
        }



        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionNew) return;
            BarButtonNew_Click();
            StatusUse = StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit ? EnumPermission.View : StatusUse = EnumPermission.New;
            SetEnableBarButton();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionEdit) return;
            BarButtonEdit_Click();
            StatusUse = EnumPermission.Edit;
            SetEnableBarButton();
        }

        private void BarButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonCancel_Click();
            StatusUse = EnumPermission.View;
            SetEnableBarButton();
        }

        private void BarButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionDelete) return;
            BarButtonDelete_Click();
            StatusUse = EnumPermission.Delete;
            SetEnableBarButton();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionPrint) return;
            BarButtonPrint_Click();
            StatusUse = EnumPermission.Print;
            SetEnableBarButton();

        }

        private void gro_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grv_search_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CodePrimary = ((GridView)sender).GetFocusedRowCellValue(((GridView)sender).Columns[NameFieldCodePrimary])?.ToString();
        }
    }
}