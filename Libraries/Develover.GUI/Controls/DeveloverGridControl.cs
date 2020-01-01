using Develover.GUI.Services;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using static Develover.GUI.Services.Functions;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridControl : GridControl, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        Functions functions = new Functions();
        GetObjects getObjects = new GetObjects();
        string sqldata_;
        string model_;
        bool edit;

        protected override BaseView CreateDefaultView()
        {
            return CreateView("DeveloverGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DeveloverGridViewInfoRegistrator());

        }

        public void BuildGridControls(string SQLData, List<TypeColumns> typeColumns, bool GridEdit = true)
        {
            DeveloverGridView develoverGridView = ((DeveloverGridView)this.DefaultView);
            develoverGridView.BuidColumns(typeColumns);
            DataSource = functions.dataBase.GetDataTable(SQLData);
        }

        public void BuildGridControls(string SQLData, string model)
        {
            DeveloverGridView develoverGridView = ((DeveloverGridView)this.DefaultView);
            sqldata_ = SQLData;
            model_ = model;

            UseEmbeddedNavigator = true;
            EmbeddedNavigator.Buttons.Append.Visible = false;
            EmbeddedNavigator.Buttons.Edit.Visible = false;
            EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            edit = true;
        }

        public void BuildGridControlsView(string sqlDate, string model)
        {
            sqldata_ = sqlDate;
            model_ = model;

            UseEmbeddedNavigator = true;
            EmbeddedNavigator.Buttons.Append.Visible = false;
            EmbeddedNavigator.Buttons.Edit.Visible = false;
            EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            EmbeddedNavigator.TextStringFormat = " {0} / {1}";

            edit = false;

        }

        public void LoadData()
        {
            if (edit)
                ((DeveloverGridView)this.DefaultView).BuidColumns(getObjects.GetSysDelGridcolumns(model_));
            else
                ((DeveloverGridView)this.DefaultView).BuidColumnsView(getObjects.GetSysDelGridcolumnsView(model_));
            DataSource = functions.dataBase.GetDataTable(sqldata_);
        }


    }
}
