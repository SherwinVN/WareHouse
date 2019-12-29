using Develover.GUI.Controls;
using Develover.GUI.Services;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Data;
using static Develover.GUI.Services.Functions;
using static Develover.Utilities.DelTypeData;

namespace Develover.GUI.RepositoryItems
{
    [UserRepositoryItem("RegisterDeveloverGridLookUpEdit")]
    public class DeveloverRepositoryItemGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static DeveloverRepositoryItemGridLookUpEdit() { RegisterCustomGridLookUpEdit(); }

        public DeveloverRepositoryItemGridLookUpEdit() : base()
        {
            PopupView = new DeveloverGridView();
            ShowPopupShadow = true;
        }
        public static void RegisterCustomGridLookUpEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(DeveloverGridLookUpEditName,
              typeof(DeveloverGridLookUpEdit), typeof(DeveloverRepositoryItemGridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }
        public const string DeveloverGridLookUpEditName = "DeveloverGridLookUpEdit";

        public override string EditorTypeName { get { return DeveloverGridLookUpEditName; } }

        Functions functions = new Functions();
        GetObjects getObjects = new GetObjects();

        string sqlData_; string model_;


        protected override ColumnView CreateViewInstance()
        {
            switch (ViewType)
            {
                case GridLookUpViewType.BandedView:
                    return new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
                case GridLookUpViewType.AdvBandedView:
                    return new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            }
            return new DeveloverGridView();
        }
        protected override DevExpress.XtraGrid.GridControl CreateGrid()
        {
            return new DeveloverGridControl();
        }


        public void LoadData(DataTable data, string model, string keyMember = "", string displayMember = "", string valueMember = "", string nullText = "")
        {
            DisplayMember = displayMember;
            ValueMember = valueMember;
            KeyMember = keyMember;
            NullText = nullText;
            model_ = model;

            ((DeveloverGridView)PopupView).BuidColumnsView(getObjects.GetSysDelGridcolumnsView(model_));
            DataSource = data;
        }
        public void LoadData(string sqlData, string model, string keyMember = "", string valueMember = "", string displayMember = "", string nullText = "")
        {
            sqlData_ = sqlData;
            KeyMember = keyMember;
            ValueMember = valueMember;
            DisplayMember = displayMember;
            NullText = nullText;
            model_ = model;

            LoadData();
        }

        private void LoadData()
        {
            ((DeveloverGridView)PopupView).BuidColumnsView(getObjects.GetSysDelGridcolumnsView(model_));
            DataSource = functions.dataBase.GetDataTable(sqlData_);
        }
    }
}
