using Develover.GUI.RepositoryItems;
using Develover.GUI.Services;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;
using static Develover.GUI.Services.Functions;

namespace Develover.GUI.Controls
{
    public class DeveloverGridLookUpEdit : GridLookUpEdit, IDeveloverControl
    {
        static DeveloverGridLookUpEdit() { DeveloverRepositoryItemGridLookUpEdit.RegisterDeveloverGridLookUpEdit(); }
        public override string EditorTypeName { get { return DeveloverRepositoryItemGridLookUpEdit.DeveloverGridLookUpEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new DeveloverRepositoryItemGridLookUpEdit Properties { get { return base.Properties as DeveloverRepositoryItemGridLookUpEdit; } }

        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        string sqldata_;
        string model_;

        public DeveloverGridLookUpEdit() : base()
        {
            Properties.NullText = "";
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Properties.PopupView = new DeveloverGridView();
            EnterMoveNextControl = true;
        }

        public void LoadData(DataTable data, string Model, string KeyMember = "", string DisplayMember = "", string ValueMember = "", string NullText = "")
        {
            Properties.LoadData(data, Model, KeyMember, DisplayMember, ValueMember, NullText);
        }
        public void LoadData(string sqlData, string model, string KeyMember = "", string ValueMember = "", string DisplayMember = "", string NullText = "")
        {
            sqldata_ = sqlData;
            LoadData();
            model_ = model;
            Properties.LoadData(sqldata_, model_, KeyMember,  ValueMember, DisplayMember,NullText);
        }

        public void LoadData() {

            Properties.LoadData();
        }

    }
}