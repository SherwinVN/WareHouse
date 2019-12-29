using Develover.GUI;
using Develover.GUI.Forms;
using System;

namespace DeveloverWarehouse.Modules.File
{
    public partial class GroupUser : DeveloverCatalogForm, IDeveloverFormChild
    {
        public GroupUser()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM sysDELGroupUser ORDER BY NameGroup";
            CodeVoucher = "GROUPUSER";           
            NameFieldCodePrimary = "ID";
            ControlCheckDuplicate = new IDeveloverControl[] { txtNameGroup };
            ControlCheckEmty = new IDeveloverControl[] { txtNameGroup };
            DeveloverControlsFocus = txtNameGroup;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
