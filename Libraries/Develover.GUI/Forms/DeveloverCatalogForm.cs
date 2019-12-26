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
using Develover.Core;
using Develover.Services;

namespace Develover.GUI.Forms
{
    public partial class DeveloverCatalogForm : DeveloverForm
    {
        public string SQLDataSourceSearch;
        public string Model;
        public List<IDeveloverControl> DeveloverControls;
        public IDeveloverControl DeveloverControlsFocus;

        public string CodePrimary;
        public string NameFileCodePrimary;
        Functions functions = new Functions();
        public EnumPermission StatusUse;


        public DeveloverCatalogForm()
        {
            InitializeComponent();

            grc_search.TypeGridEdit = false;
            StatusUse = EnumPermission.View;
            SetEnableBarButton();
            DeveloverControls = new List<IDeveloverControl>();

        }
        private void DeveloverCatalogForm_Load(object sender, EventArgs e)
        {
            LoadPermissionForm();
        }


        public void InitForm()
        {
            using (DataTable data = sqlDataProvider.GetDataTable("SELECT   ID, Code, Name, TableHeader, TableDetail FROM SysDELListVoucher WHERE code = '" + Model + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    Text = dr["Name"].ToString();
                }
            }
            LoadData();
            DataBindingsControl();
        }

        public virtual void LoadData()
        {
            grc_search.BuildGridControls(SQLDataSourceSearch, Model);

        }

        public virtual void DataBindingsControl()
        {
            LoadListControlBinding();
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

        private void LoadListControlBinding()
        {
            using (DataTable data = sqlDataProvider.GetDataTable("SELECT NameControl, NameColumn, TypeControl FROM SysDELBinDingData WHERE Model = '" + Model + "' "))
            {

                foreach (DataRow dr in data.Rows)
                {
                    ((IDeveloverControl)gro_general.Controls[dr["NameControl"]?.ToString()]).FieldBinding = dr["NameColumn"]?.ToString();
                    ((IDeveloverControl)gro_general.Controls[dr["NameControl"]?.ToString()]).TypeFieldColumns = GetTypeColumn(dr["TypeControl"]?.ToString());

                    DeveloverControls.Add(((IDeveloverControl)gro_general.Controls[dr["NameControl"]?.ToString()]));
                }
            }
        }

        protected virtual void BarButtonNew_Click()
        {
            if (EnumPermission.New == StatusUse)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                List<Dictionary<string, string>> lists = new List<Dictionary<string, string>>();

                foreach (IDeveloverControl iDC in DeveloverControls)
                {
                    switch (iDC.TypeFieldColumns)
                    {
                        case EnumTypeColumns.Number:
                            dictionary.Add(iDC.FieldBinding, ((Control)iDC).Text);
                            break;
                        case EnumTypeColumns.Check:
                            dictionary.Add(iDC.FieldBinding, ((CheckEdit)iDC).Checked.ToString());
                            break;

                        case EnumTypeColumns.Combobox:
                            dictionary.Add(iDC.FieldBinding, ((Control)iDC).Text);
                            break;

                        case EnumTypeColumns.Date:
                            dictionary.Add(iDC.FieldBinding, DateTime.Parse(((Control)iDC).Text).ToString("MM/dd/yyyy"));
                            break;

                        case EnumTypeColumns.Gridlookup:
                            dictionary.Add(iDC.FieldBinding, ((Control)iDC).Text);
                            break;

                        case EnumTypeColumns.Text:
                            dictionary.Add(iDC.FieldBinding, ((Control)iDC).Text);
                            break;

                        case EnumTypeColumns.Time:
                            dictionary.Add(iDC.FieldBinding, ((Control)iDC).Text);
                            break;



                    }
                    lists.Add(dictionary);
                }

                functions.InsertIntoTable(lists, Model);
            }


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
            if (!PermissionNew) return;
            StatusUse = StatusUse == EnumPermission.New || StatusUse == EnumPermission.Edit ? EnumPermission.View : StatusUse = EnumPermission.New;
            SetEnableBarButton();
            BarButtonNew_Click();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionEdit) return;
            StatusUse = EnumPermission.Edit;
            SetEnableBarButton();
            BarButtonEdit_Click();
        }

        private void BarButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StatusUse = EnumPermission.View;
            SetEnableBarButton();
            BarButtonCancel_Click();
        }


        private void BarButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionDelete) return;
            StatusUse = EnumPermission.Delete;
            SetEnableBarButton();
            BarButtonDelete_Click();
        }

        private void barButtonPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PermissionPrint) return;
            StatusUse = EnumPermission.Print;
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

                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = true;
                        barButtonPrint.Enabled = false;
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = true;
                        barButtonPrint.Enabled = false;
                    }
                    break;
                case EnumPermission.View:
                    {
                        barButtonEdit.Enabled = true;
                        barButtonDelete.Enabled = true;
                        barButtonCancel.Enabled = false;
                        barButtonPrint.Enabled = true;
                    }
                    break;
                case EnumPermission.Denial:
                    {
                        BarButtonNew.Enabled = false;
                        barButtonEdit.Enabled = false;
                        barButtonDelete.Enabled = false;
                        barButtonCancel.Enabled = false;
                        barButtonPrint.Enabled = false;
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

        private void gro_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grv_search_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CodePrimary = ((GridView)sender).GetFocusedRowCellValue(((GridView)sender).Columns[NameFileCodePrimary])?.ToString();
        }
    }
}