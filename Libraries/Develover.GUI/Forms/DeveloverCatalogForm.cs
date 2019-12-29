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
using Develover.GUI.Controls;
using Develover.GUI.OverideClass;
using Develover.GUI.Services;

namespace Develover.GUI.Forms
{
    public partial class DeveloverCatalogForm : DeveloverForm
    {
        Functions functions = new Functions();
        public string SQLDataSourceSearch;
        public string CodeVoucher;
        private string Table;
        private string ModelName;
        public string CodePrimary;
        public string NameFieldCodePrimary;
        public EnumPermission StatusUse;
        public IDeveloverControl DeveloverControlsFocus;
        public IDeveloverControl[] ControlCheckDuplicate;
        public IDeveloverControl[] ControlCheckEmty;

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

        private void ClearDataBindingsControl(IDeveloverControl GroupControl)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        ((Control)iDcontrol).DataBindings.Clear();
                    }
                }

            }

        }

        public Dictionary<string, string> LoadListControlAndField(IDeveloverControl GroupControl)
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
        public string GetValueByTypeFieldColumns(EnumTypeColumns TypeFieldColumns, IDeveloverControl develoverControl)
        {

            switch (TypeFieldColumns)
            {
                case EnumTypeColumns.Number:
                    return ((Control)develoverControl).Text;
                case EnumTypeColumns.Check:
                    return ((CheckEdit)develoverControl).Checked ? "1" : "0";
                case EnumTypeColumns.Combobox:
                    return ((Control)develoverControl).Text;
                case EnumTypeColumns.Date:
                    return DateTime.Parse(((Control)develoverControl).Text).ToString("MM/dd/yyyy");
                case EnumTypeColumns.Gridlookup:
                    return ((Control)develoverControl).Text;
                case EnumTypeColumns.Text:
                    return ((Control)develoverControl).Text;
                case EnumTypeColumns.Time:
                    return ((Control)develoverControl).Text;
                default:
                    return "";
            }
        }
        protected virtual bool CheckDuplicate(IDeveloverControl[] develoverControls)
        {
            string Where = "1=1 ";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                Where += " AND [" + develoverControl.FieldBinding + "] = N'" + GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl) + "'";
            }
            return functions.CheckExistsValueInTable(Table, Where, NameFieldCodePrimary, CodePrimary);

        }
        protected virtual bool CheckEmty(IDeveloverControl[] develoverControls)
        {
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                if (string.IsNullOrEmpty(((Control)develoverControl).Text))
                {
                    return true;
                }
            }
            return false;
        }
        protected virtual bool BarButtonNew_Click()
        {
            if (EnumPermission.Edit == StatusUse || EnumPermission.New == StatusUse)
            {
                if (CheckDuplicate(ControlCheckDuplicate))
                {
                    DelMessageBox.DelMessageBoxOk(StringMessage.InfomationExistsObject);
                    return false;
                }
                if (CheckEmty(ControlCheckEmty))
                {
                    DelMessageBox.DelMessageBoxOk(StringMessage.CompelInput);
                    return false;
                }
                if (EnumPermission.New == StatusUse)
                {
                    CodePrimary = functions.GetGUID();

                    functions.InsertIntoTable(LoadListControlAndField(gro_general), Table, NameFieldCodePrimary, CodePrimary);
                    LoadData();
                }
                else
                if (EnumPermission.Edit == StatusUse)
                {
                    functions.UpdateTable(LoadListControlAndField(gro_general), Table, NameFieldCodePrimary, CodePrimary);
                    LoadData();
                }
            }
            else
            {
                SetNullControl(gro_general);
                ((Control)DeveloverControlsFocus).Focus();
            }
            return true;
        }

        protected virtual bool BarButtonEdit_Click()
        {
            return true;
        }

        protected virtual bool BarButtonCancel_Click()
        {
            LoadData();
            return true;
        }

        protected virtual bool BarButtonDelete_Click()
        {
            if (DelMessageBox.DelMessageBoxYN(StringMessage.QuestionDelete, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                functions.DeleteRowTable(Table, NameFieldCodePrimary, CodePrimary);
                SetNullControl(gro_general);
                LoadData();
            }

            return true;
        }

        protected virtual bool BarButtonPrint_Click()
        {
            return true;
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
                        if (String.IsNullOrEmpty(CodePrimary))
                        {
                            barButtonDelete.Enabled = false;
                            barButtonPrint.Enabled = false;
                        }
                        else
                        {
                            barButtonDelete.Enabled = true;
                            barButtonPrint.Enabled = true;
                        }
                        barButtonCancel.Enabled = false;
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
            using (DataTable data = functions.dataBase.GetDataTable("SELECT   ID, Code, Name, TableHeader,ModelName FROM SysDELListVoucher WHERE code = '" + CodeVoucher + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    Text = dr["Name"].ToString();
                    Table = dr["TableHeader"].ToString();
                    ModelName = dr["ModelName"].ToString();
                }
            }
            grc_search.BuildGridControlsView(SQLDataSourceSearch, ModelName);
            LoadData();
            SetEnableBarButton();
            LoadDataControls();
        }

        protected virtual void LoadData()
        {
            string code = CodePrimary;
            grc_search.LoadData();
            ClearDataBindingsControl(gro_general);
            DataBindingsControl(gro_general, grc_search.DataSource);
            if (grv_search.LocateByDisplayText(0, grv_search.Columns[NameFieldCodePrimary], code) >= 0)
            {
                grv_search.FocusedRowHandle = grv_search.LocateByDisplayText(0, grv_search.Columns[NameFieldCodePrimary], code);
                grv_search.ClearSelection();
                grv_search.SelectRow(grv_search.FocusedRowHandle);
            }
            else
                grv_search.FocusedRowHandle = grv_search.LocateByDisplayText(0, grv_search.Columns[NameFieldCodePrimary], CodePrimary);

        }

        protected virtual void LoadDataControls()
        {
           

        }

        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionNew) return;
            ClearDataBindingsControl(gro_general);
            if (!BarButtonNew_Click()) return;
            StatusUse = StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit ? EnumPermission.View : StatusUse = EnumPermission.New;
            SetEnableBarButton();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionEdit) return;
            if (string.IsNullOrEmpty(CodePrimary)) return;
            ClearDataBindingsControl(gro_general);
            if (!BarButtonEdit_Click()) return;
            StatusUse = EnumPermission.Edit;
            SetEnableBarButton();
        }

        private void BarButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!BarButtonCancel_Click()) return;
            StatusUse = EnumPermission.View;
            SetEnableBarButton();
        }

        private void BarButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionDelete) return;
            if (string.IsNullOrEmpty(CodePrimary)) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit) return;
            if (!BarButtonDelete_Click()) return;
            StatusUse = EnumPermission.Delete;
            SetEnableBarButton();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionPrint) return;
            if (string.IsNullOrEmpty(CodePrimary)) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit) return;
            if (!BarButtonPrint_Click()) return;
            StatusUse = EnumPermission.Print;
            SetEnableBarButton();
        }

        private void grv_search_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (EnumPermission.Edit == StatusUse) return;
            if (EnumPermission.New == StatusUse) return;

            CodePrimary = ((GridView)sender).GetFocusedRowCellValue(((GridView)sender).Columns[NameFieldCodePrimary])?.ToString();

        }
    }
}