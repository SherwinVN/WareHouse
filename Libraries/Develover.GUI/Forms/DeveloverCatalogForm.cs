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
        Functions functionsGUIService = new Functions();
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
            if (!CheckView()) return;
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
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        SetNullControl(iDcontrol);
                    }
                    else
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
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        SetStatusEdit(iDcontrol, Enable);
                    }
                    else
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

        protected virtual void DataBindingsControl(IDeveloverControl GroupControl, Object Datasource)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        DataBindingsControl(iDcontrol, Datasource);
                    }
                    else
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Check:
                                ((Control)iDcontrol).DataBindings.Add(nameof(BaseCheckEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                            case EnumTypeColumns.Gridlookup:
                                ((Control)iDcontrol).DataBindings.Add(nameof(GridLookUpEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, null);
                                break;
                            case EnumTypeColumns.Text:
                                ((Control)iDcontrol).DataBindings.Add(nameof(TextEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                            case EnumTypeColumns.Combobox:
                                ((Control)iDcontrol).DataBindings.Add(nameof(ComboBoxEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                            case EnumTypeColumns.Date:
                                ((Control)iDcontrol).DataBindings.Add(nameof(DateEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                            case EnumTypeColumns.Number:
                                ((Control)iDcontrol).DataBindings.Add(nameof(CalcEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                            case EnumTypeColumns.Time:
                                ((Control)iDcontrol).DataBindings.Add(nameof(TimeEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never);
                                break;
                        }


                    }
                }

            }

        }

        protected virtual void ClearDataBindingsControl(IDeveloverControl GroupControl)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        ClearDataBindingsControl(iDcontrol);
                    }
                    else
                      if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        ((Control)iDcontrol).DataBindings.Clear();
                    }
                }

            }

        }

        protected virtual Dictionary<string, string> LoadListControlAndField(IDeveloverControl GroupControl)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string text = "";
            Guid guid;
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        Dictionary<string, string> dictionary2 = LoadListControlAndField(iDcontrol);
                        foreach (string keys in dictionary2.Keys)
                        {
                            dictionary.Add(keys, dictionary2[keys]);

                        }
                    }
                    else
                      if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        switch (iDcontrol.TypeFieldColumns)
                        {
                            case EnumTypeColumns.Number:
                                text = ((Control)iDcontrol).Text;
                                break;
                            case EnumTypeColumns.Check:
                                text = ((CheckEdit)iDcontrol).Checked ? "1" : "0";
                                break;
                            case EnumTypeColumns.Combobox:
                                text = ((Control)iDcontrol).Text;
                                break;
                            case EnumTypeColumns.Date:
                                text = DateTime.Parse(((Control)iDcontrol).Text).ToString("MM/dd/yyyy");
                                break;
                            case EnumTypeColumns.Gridlookup:
                                text = ((GridLookUpEdit)iDcontrol).EditValue.ToString();
                                break;
                            case EnumTypeColumns.Text:
                                text = ((Control)iDcontrol).Text;
                                break;
                            case EnumTypeColumns.Time:
                                text = ((Control)iDcontrol).Text;
                                break;
                        }

                        if (iDcontrol.IsGUID)
                        {
                            functionsGUIService.CheckGuid(text, out guid);
                            text = guid.ToString();
                        }

                        dictionary.Add(iDcontrol.FieldBinding, text);

                    }

                }

            }

            return dictionary;
        }

        protected virtual string GetValueByTypeFieldColumns(EnumTypeColumns TypeFieldColumns, IDeveloverControl develoverControl)
        {

            string text = "";
            Guid guid;
            switch (TypeFieldColumns)
            {
                case EnumTypeColumns.Number:
                    text = decimal.Parse(((Control)develoverControl).Text).ToString();
                    break;
                case EnumTypeColumns.Check:
                    text = ((CheckEdit)develoverControl).Checked ? "1" : "0";
                    break;
                case EnumTypeColumns.Combobox:
                    text = ((Control)develoverControl).Text;
                    break;
                case EnumTypeColumns.Date:
                    text = DateTime.Parse(((Control)develoverControl).Text).ToString("MM/dd/yyyy");
                    break;
                case EnumTypeColumns.Gridlookup:
                    text = ((GridLookUpEdit)develoverControl).EditValue.ToString();
                    break;
                case EnumTypeColumns.Text:
                    text = ((Control)develoverControl).Text;
                    break;
                case EnumTypeColumns.Time:
                    text = ((Control)develoverControl).Text;
                    break;
            }
            if (develoverControl.IsGUID)
            {
                functionsGUIService.CheckGuid(text, out guid);
                text = guid.ToString();
            }

            return text;
        }

        protected virtual bool CheckDuplicate(IDeveloverControl[] develoverControls, string tableName, string nameFieldCodePrimary, string codePrimary)
        {
            string Where = "1=1 ";
            string value = "";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                if (!string.IsNullOrEmpty(develoverControl.FieldBinding))
                {
                    value = GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl);
                    Where += " AND [" + develoverControl.FieldBinding + "] = N'" + value + "'";
                }
            }

            return functionsGUIService.CheckExistsValueInTableByWhere(tableName, Where, nameFieldCodePrimary, codePrimary);
        }

        protected virtual bool CheckDuplicate(IDeveloverControl[] develoverControls, string tableName, string nameFieldCodePrimary)
        {
            string Where = "1=1 ";
            string value = "";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                if (!string.IsNullOrEmpty(develoverControl.FieldBinding))
                {
                    value = GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl);
                    Where += " AND [" + develoverControl.FieldBinding + "] = N'" + value + "'";
                }
            }
            return functionsGUIService.CheckExistsValueInTableByWhere(tableName, Where, nameFieldCodePrimary);

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
        protected virtual bool LoadColorControlNotEmty(IDeveloverControl[] develoverControls)
        {
            try
            {
                foreach (IDeveloverControl develoverControl in develoverControls)
                {
                    ((Control)develoverControl).BackColor = DeveloverOptions.ControlRequiedInputBackColor;
                    ((Control)develoverControl).ForeColor = DeveloverOptions.ControlRequiedInputForeColor;
                }

                return true;
            }
            catch (Exception ex)
            {
                DelMessageBox.DelMessageBoxError("Error:"+ex.Message);
                return false;
            }
        }

        protected virtual bool BarButtonNew_Click()
        {
            if (EnumPermission.Edit == StatusUse || EnumPermission.New == StatusUse)
            {

                if (CheckEmty(ControlCheckEmty))
                {
                    DelMessageBox.DelMessageBoxOk(StringMessage.CompelInput);
                    return false;
                }
                if (EnumPermission.New == StatusUse)
                {
                    if (CheckDuplicate(ControlCheckDuplicate, Table, NameFieldCodePrimary))
                    {
                        DelMessageBox.DelMessageBoxOk(StringMessage.InfomationExistsObject);
                        return false;
                    }
                    CodePrimary = functionsGUIService.GetGUID();

                    functionsGUIService.InsertIntoTable(LoadListControlAndField(gro_general), Table, NameFieldCodePrimary, CodePrimary);
                    LoadData();
                }
                else
                if (EnumPermission.Edit == StatusUse)
                {
                    if (CheckDuplicate(ControlCheckDuplicate, Table, NameFieldCodePrimary, CodePrimary))
                    {
                        DelMessageBox.DelMessageBoxOk(StringMessage.InfomationExistsObject);
                        return false;
                    }
                    functionsGUIService.UpdateTable(LoadListControlAndField(gro_general), Table, NameFieldCodePrimary, CodePrimary);
                    LoadData();
                }

                SetStatus("Lưu thành công");
            }
            else
            {
                SetStatus("Đang thêm mới");
                SetNullControl(gro_general);
                ((Control)DeveloverControlsFocus).Focus();
            }
            return true;
        }
        protected virtual void SetStatus(string stringStatus)
        {
            ((IDeveloverFormParent)this.MdiParent).SetStatusAsync("[" + Text+".] - " + stringStatus );
        }
        protected virtual bool BarButtonEdit_Click()
        {
            SetStatus("Đang sửa");
            return true;
        }

        protected virtual bool BarButtonCancel_Click()
        {
            SetStatus("Hủy hoạt động");
            LoadData();
            return true;
        }

        protected virtual bool BarButtonDelete_Click()
        {
            SetStatus("Đang xóa");
            if (DelMessageBox.DelMessageBoxYN(StringMessage.QuestionDelete, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                functionsGUIService.DeleteRowTable(Table, NameFieldCodePrimary, CodePrimary);
                SetNullControl(gro_general);
                LoadData();
                if (grv_search.RowCount > 0)
                    CodePrimary = grv_search.GetRowCellValue(0, NameFieldCodePrimary)?.ToString();
                SetStatus("Xóa thành công");
            }

            SetStatus("Hủy xóa");
            return true;
        }

        protected virtual bool BarButtonPrint_Click()
        {
            SetStatus("Đang in");

            return true;
        }

        protected virtual void SetVisibleItemToolBar()
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
                        if (String.IsNullOrEmpty(CodePrimary))
                        {
                            barButtonEdit.Enabled = false;
                            barButtonDelete.Enabled = false;
                            barButtonPrint.Enabled = false;
                        }
                        else
                        {
                            barButtonEdit.Enabled = true;
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

        protected virtual void LoadTextBarButton()
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

        protected virtual void LoadPermissionForm()
        {
            SetVisibleItemToolBar();
        }

        protected virtual void InitForm()
        {
            using (DataTable data = functionsGUIService.dataBase.GetDataTable("SELECT   ID, Code, Name, TableHeader,ModelName FROM SysDELListVoucher WHERE code = '" + CodeVoucher + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    Text = dr["Name"].ToString().ToUpper();
                    Table = dr["TableHeader"].ToString();
                    ModelName = dr["ModelName"].ToString();
                }
            }
            SetStatus("Đang mở");
            grc_search.BuildGridControlsView(SQLDataSourceSearch, ModelName);
            LoadData();
            SetEnableBarButton();
            LoadDataControls();
            LoadColorControlNotEmty(ControlCheckEmty);
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
            {
                grv_search.FocusedRowHandle = grv_search.LocateByDisplayText(0, grv_search.Columns[NameFieldCodePrimary], CodePrimary);
            }
        }

        protected virtual void LoadDataControls()
        {


        }

        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckNew()) return;
            ClearDataBindingsControl(gro_general);
            ((Control)DeveloverControlsFocus).Focus();
            if (!BarButtonNew_Click()) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit)
            {
                StatusUse = EnumPermission.View;
                WhenCloseForm_ = true;
            }
            else
            {
                StatusUse = EnumPermission.New;
                WhenCloseForm_ = false;
            }
            SetEnableBarButton();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckEdit()) return;
            if (string.IsNullOrEmpty(CodePrimary)) return;
            ClearDataBindingsControl(gro_general);
            ((Control)DeveloverControlsFocus).Focus();
            if (!BarButtonEdit_Click()) return;
            StatusUse = EnumPermission.Edit;
            WhenCloseForm_ = false;
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
            if (!CheckDelete()) return;
            if (string.IsNullOrEmpty(CodePrimary)) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit) return;
            if (!BarButtonDelete_Click()) return;
            StatusUse = EnumPermission.Delete;
            SetEnableBarButton();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckPrint()) return;
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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        {
                            BarButtonNew_ItemClick(null, null);
                        }
                        break;
                    case Keys.S:
                        {
                            if (StatusUse == EnumPermission.Edit || StatusUse == EnumPermission.New)
                                BarButtonNew_ItemClick(null, null);
                        }
                        break;
                    case Keys.E:
                        {
                            BarButtonEdit_ItemClick(null, null);

                        }
                        break;
                    case Keys.C:
                        {
                            BarButtonCancel_ItemClick(null, null);

                        }
                        break;
                    case Keys.P:
                        {

                            barButtonPrint_ItemClick(null, null);
                        }
                        break;
                }
            }
        }
      
   
    }
}