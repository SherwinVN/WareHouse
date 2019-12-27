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
            SQLDataSourceSearch = "SELECT * FROM sysDELUser order by UserName";
            Model = "USER";           
            Table = "sysDELUser";
            NameFieldCodePrimary = "ID";
            NameFieldNamePrimary = "UserName";
            DeveloverControlsNamePrimary = txtLastNameAndName;
            DeveloverControlsFocus = txtLastNameAndName;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
