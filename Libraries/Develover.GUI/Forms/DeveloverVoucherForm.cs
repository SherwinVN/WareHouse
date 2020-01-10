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
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;

namespace Develover.GUI.Forms
{
    public partial class DeveloverVoucherForm : DeveloverForm
    {
        readonly Functions functionsGUIService = new Functions();
        public string ViewSearch;
        public string ViewVouvher;
        public string VoucherID;
        private string TableHeader;
        private string TableDetail;
        private string ModelName;
        public string CodeVoucher;
        public EnumPermission StatusUse = EnumPermission.View;
        public IDeveloverControl DeveloverControlsFocus;
        public IDeveloverControl[] ControlCheckExit;
        public IDeveloverControl[] ControlCheckEmty;

        public DeveloverVoucherForm()
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
            ((DataTable)grcDetai.DataSource).Rows.Clear();
        }

        protected virtual bool SetStatusReadOnly(IDeveloverControl GroupControl, bool Enable)
        {
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (iDcontrol is DeveloverGroupControl)
                    {
                        SetStatusReadOnly(iDcontrol, Enable);
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

        protected virtual string GetValueByTypeFieldColumns(IDeveloverControl develoverControl)
        {

            string text = "";
            Guid guid;
            switch (develoverControl.TypeFieldColumns)
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
        protected virtual Type GetTypeControl(IDeveloverControl develoverControl)
        {

            Type type = null; ;
            switch (develoverControl.TypeFieldColumns)
            {
                case EnumTypeColumns.Number:
                    type = typeof(Double);
                    break;
                case EnumTypeColumns.Check:
                    type = typeof(bool);
                    break;
                case EnumTypeColumns.Combobox:
                    type = typeof(string);
                    break;
                case EnumTypeColumns.Date:
                    type = typeof(DateTime);
                    break;
                case EnumTypeColumns.Gridlookup:
                    type = typeof(string);
                    break;
                case EnumTypeColumns.Text:
                    type = typeof(string);
                    break;
                case EnumTypeColumns.Time:
                    type = typeof(Timer);
                    break;
            }

            return type;
        }
        protected virtual bool CheckExitValue(IDeveloverControl[] develoverControls)
        {
            string Where = " 1=1 ";
            string value = "";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                Where = " 1=1 ";
                value = "";
                if (!string.IsNullOrEmpty(develoverControl.FieldBinding))
                {
                    value = GetValueByTypeFieldColumns(develoverControl);
                    Where += " AND [" + develoverControl.FieldBinding + "] = N'" + value + "'";
                    if (functionsGUIService.CheckExistsValueInTableByWhere(TableHeader, Where, "VoucherID", VoucherID))
                    {
                        ((Control)develoverControl).BackColor = DeveloverOptions.ControlExistsValueBackColor;
                        ((Control)develoverControl).ForeColor = DeveloverOptions.ControlExistsValueForeColor;
                        ((Control)develoverControl).Focus();
                        return true;
                    }
                }
            }
            return false;
        }

        protected virtual bool CheckEmty(IDeveloverControl[] develoverControls)
        {
            if (grvDetail.RowCount > 0)
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
            else
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
                DelMessageBox.DelMessageBoxError("Error:" + ex.Message);
                return false;
            }
        }

        protected virtual List<string> GetlistColumnTableHeader(IDeveloverControl GroupControl)
        {
            List<string> listColumn = new List<string>();
            foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
            {
                if (iDcontrol is IDeveloverControl)
                {
                    if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                    {
                        listColumn.Add(iDcontrol.FieldBinding);
                    }
                }
            }
            return listColumn;
        }

        protected virtual List<string> GetlistColumnTableDetail(string modelName)
        {
            List<string> listColumn = new List<string>();
            using (DataTable data = functionsGUIService.dataBase.GetDataTable("SELECT * FROM sysDELGridColumns WHERE Model = '" + modelName + "' ORDER BY OrderNo"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    listColumn.Add(dr["Name"]?.ToString());
                }
            }
            return listColumn;
        }

        protected virtual List<string> GetlistColumnTableDetail(GridView gridView)
        {
            List<string> listColumn = new List<string>();

            foreach (GridColumn cl in gridView.Columns)
            {
                listColumn.Add(cl.FieldName);
            }

            return listColumn;
        }
        protected virtual bool CreateTableHeaderTemp(string tableNameCopy, string tableNameAs, List<string> listColumn)
        {
            try
            {

                string sql = "IF(EXISTS(SELECT name FROM sysObjects WHERE name = '" + tableNameAs + "')) DROP TABLE " + tableNameAs;
                functionsGUIService.dataBase.ExecuteNonQuery(sql);
                sql = "SELECT top 0 " + string.Join(",", listColumn.ToArray()) + " INTO " + tableNameAs + " FROM " + tableNameCopy;
                if (functionsGUIService.dataBase.ExecuteNonQuery(sql) != 1)
                {
                    return true;
                }

            }
            catch
            {
            }
            return true;
        }

        protected virtual bool CreateTableHeaderTemp(string tableNameCopy, string tableNameAs)
        {
            try
            {

                string sql = "IF EXISTS(SELECT name FROM sysObjects WHERE name = '" + tableNameAs + "') DROP TABLE " + tableNameAs;
                functionsGUIService.dataBase.ExecuteNonQuery(sql);
                sql = "SELECT * INTO " + tableNameAs + " FROM " + tableNameCopy + " WHERE 1 = 2";
                if (functionsGUIService.dataBase.ExecuteNonQuery(sql) >= 0)
                {
                    return true;
                }

            }
            catch
            {
            }
            return false;
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

                    if (CheckExitValue(ControlCheckExit))
                    {
                        DelMessageBox.DelMessageBoxOk(StringMessage.InfomationExistsObject);
                        return false;
                    }
                    VoucherID = functionsGUIService.GetGUID();

                    string tableNameHeader = ("Header" + ModelName + VoucherID.Replace("-", "")).ToUpper();
                    string tableNameDetail = ("Detail" + ModelName + VoucherID.Replace("-", "")).ToUpper();

                    if (CreateTableHeaderTemp(TableHeader, tableNameHeader))
                    {
                        if (functionsGUIService.InsertIntoTable(LoadListControlAndField(groHeader), tableNameHeader, "VoucherID", VoucherID))
                        {
                            if (CreateTableHeaderTemp(TableDetail, tableNameDetail, GetlistColumnTableDetail(grvDetail)))
                            {
                                if (functionsGUIService.dataBase.bulkcopy(((DataTable)grcDetai.DataSource), tableNameDetail, GetlistColumnTableDetail(grvDetail).ToArray()))
                                {
                                    functionsGUIService.dataBase.ExecuteProcedure("PROPOSTVOUCHER", new string[] { "model", "VoucherID" }, new string[] { ModelName, VoucherID });
                                }
                            }
                        }
                    }

                    LoadData();
                }
                else
                if (EnumPermission.Edit == StatusUse)
                {
                    if (CheckExitValue(ControlCheckExit))
                    {
                        DelMessageBox.DelMessageBoxOk(StringMessage.InfomationExistsObject);
                        return false;
                    }
                    functionsGUIService.UpdateTable(LoadListControlAndField(groHeader), TableHeader, "VoucherID", VoucherID);
                    LoadData();
                }
            }
            else
            {
                SetNullControl(groHeader);
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
                DeleteVoucher();
                SetNullControl(groHeader);
                LoadData();
                if (grvSearch.RowCount > 0)
                    VoucherID = grvSearch.GetRowCellValue(0, "VoucherID")?.ToString();
            }

            return true;
        }

        protected virtual bool BarButtonPrint_Click()
        {
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
                        grvDetail.OptionsBehavior.Editable = !SetStatusReadOnly(groHeader, false);
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = true;
                        barButtonPrint.Enabled = false;
                        grvDetail.OptionsBehavior.Editable = !SetStatusReadOnly(groHeader, false);
                    }
                    break;
                case EnumPermission.View:
                    {
                        if (String.IsNullOrEmpty(VoucherID))
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
                        grvDetail.OptionsBehavior.Editable = !SetStatusReadOnly(groHeader, true);
                    }
                    break;
                case EnumPermission.Denial:
                    {
                        BarButtonNew.Enabled = false;
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = false;
                        barButtonPrint.Enabled = false;
                        grvDetail.OptionsBehavior.Editable = !SetStatusReadOnly(groHeader, true);
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

            VoucherID = functionsGUIService.GetDefaulString();
            using (DataTable data = functionsGUIService.dataBase.GetDataTable("SELECT   ID, Code, Name, TableHeader,TableDetail,ModelName FROM SysDELListVoucher WHERE code = '" + CodeVoucher + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    Text = dr["Name"].ToString().ToUpper();
                    TableHeader = dr["TableHeader"].ToString();
                    TableDetail = dr["TableDetail"].ToString();
                    ModelName = dr["ModelName"].ToString();
                }
            }
            SetStatus("Đang mở");
            grcSearch.BuildGridControlsView("SElECT * FROM " + ViewSearch, ModelName + "Search");
            grcDetai.BuildGridControls("SElECT * FROM " + ViewVouvher + " WHERE VoucherID ='" + VoucherID + "'", ModelName);
            SetEnableBarButton();
            LoadColorControlNotEmty(ControlCheckEmty);
            LoadDataControls();
            LoadData();
        }

        protected virtual void LoadData()
        {
            string code = VoucherID;
            grcSearch.LoadData();
            grcDetai.LoadData();
            ClearDataBindingsControl(groHeader);
            DataBindingsControl(groHeader, grcSearch.DataSource);
            if (grvSearch.LocateByDisplayText(0, grvSearch.Columns["VoucherID"], code) >= 0)
            {
                grvSearch.FocusedRowHandle = grvSearch.LocateByDisplayText(0, grvSearch.Columns["VoucherID"], code);
                grvSearch.ClearSelection();
                grvSearch.SelectRow(grvSearch.FocusedRowHandle);
            }
            else
            {
                grvSearch.FocusedRowHandle = grvSearch.LocateByDisplayText(0, grvSearch.Columns["VoucherID"], VoucherID);
            }
        }

        protected virtual void LoadDataControls()
        {


        }

        protected virtual bool DeleteVoucher()
        {
            throw new NotImplementedException();
        }

        protected virtual void SetStatus(string stringStatus)
        {
            ((IDeveloverFormParent)this.MdiParent).SetStatusAsync("[" + Text + ".] - " + stringStatus);
        }

        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckNew()) return;
            ClearDataBindingsControl(groHeader);
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
            if (string.IsNullOrEmpty(VoucherID)) return;
            ClearDataBindingsControl(groHeader);
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
            if (string.IsNullOrEmpty(VoucherID)) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit) return;
            if (!BarButtonDelete_Click()) return;
            StatusUse = EnumPermission.Delete;
            SetEnableBarButton();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckPrint()) return;
            if (string.IsNullOrEmpty(VoucherID)) return;
            if (StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit) return;
            if (!BarButtonPrint_Click()) return;
            StatusUse = EnumPermission.Print;
            SetEnableBarButton();
        }

        private void grv_search_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (EnumPermission.Edit == StatusUse) return;
            if (EnumPermission.New == StatusUse) return;

            //   CodePrimary = ((GridView)sender).GetFocusedRowCellValue(((GridView)sender).Columns[NameFieldCodePrimary])?.ToString();

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