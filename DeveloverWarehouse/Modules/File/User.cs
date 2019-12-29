using Develover.GUI;
using Develover.GUI.Forms;
using System;

namespace DeveloverWarehouse.Modules.File
{
    public partial class User : DeveloverCatalogForm, IDeveloverFormChild
    {
        public User()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM sysDELUser ORDER BY UserName";
            CodeVoucher = "USER";           
            NameFieldCodePrimary = "ID";
            ControlCheckDuplicate = new IDeveloverControl[] { txtAccount };
            ControlCheckEmty = new IDeveloverControl[] { txtAccount,txtLastNameAndName };
            DeveloverControlsFocus = txtAccount;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
